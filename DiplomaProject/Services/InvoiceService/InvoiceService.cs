using AutoMapper;
using DiplomaProject.DataTransferObjects;
using DiplomaProject.Models;
using DiplomaProject.Services.InvoiceServiceNS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.Services.InvoiceServiceNS
{
    public class InvoiceService : IInvoiceService
    {
        private IMapper mapper;
        private readonly DiplomaProjectDbContext diplomaProjectDbContext;

        public InvoiceService(IMapper mapper, DiplomaProjectDbContext diplomaProjectDbContext)
        {
            this.mapper = mapper;
            this.diplomaProjectDbContext = diplomaProjectDbContext;
        }

        public async Task<IEnumerable<InvoiceDto>> Get()
        {
            var invoice = await this.diplomaProjectDbContext.Invoices.ToListAsync();
            return this.mapper.Map<List<Invoice>, List<InvoiceDto>>(invoice);
        }

        public async Task<InvoiceDto> Get(int id)
        {
            var invoice = await this.diplomaProjectDbContext.Invoices.FirstOrDefaultAsync(i => i.InvoiceId == id);
            if (invoice == null)
            {
                throw new ArgumentException("Id not existing");
            }

            return this.mapper.Map<InvoiceDto>(invoice);
        }

        public async Task<InvoiceDto> Create(InvoiceCreateDto invoiceCreateDto)
        {
            var invoice = this.mapper.Map<Invoice>(invoiceCreateDto);
            var existingInvoice = await this.diplomaProjectDbContext.Invoices.Where(i => i.ProjectId == invoiceCreateDto.ProjectId && i.Month == invoiceCreateDto.Month)
                .FirstOrDefaultAsync();
            // check if invoice already exist, if yes, return a relevant message 
            if (existingInvoice != null)
            {
                throw new ArgumentException("An invoice with id number " + existingInvoice.InvoiceId + " already exists for project id " + existingInvoice.ProjectId
                    + " and month " + existingInvoice.Month);
            }

            await this.diplomaProjectDbContext.AddAsync(invoice);
            await this.diplomaProjectDbContext.SaveChangesAsync();
            var timeEntries = await this.diplomaProjectDbContext.TimeEntries.Where(te => te.ProjectId == invoiceCreateDto.ProjectId && te.Date.Month == invoiceCreateDto.Month).ToListAsync();
            decimal totalAmountOfHours = 0;
            foreach (var timeEntry in timeEntries)
            {
                timeEntry.InvoiceId = invoice.InvoiceId;   //przypisanie id danego invoice do time entries - krotek, czyli przypisuję FK w tabeli TimeEntry
                //invoice.AmountOfHours = invoice.AmountOfHours + timeEntry.AmountOfHours;
                //invoice.AmountOfHours += timeEntry.AmountOfHours;  // to samo co powyżej, ale zastosowano DRY
                totalAmountOfHours = totalAmountOfHours + timeEntry.AmountOfHours;
            }

            //invoice.TotalToPay = invoice.AmountOfHours * invoice.HourlyRate;   // 1st v
            //invoice.TotalToPay = invoice.AmountOfHours * invoice.Project.PricePerHour;  // 2nd v
            Project project = await this.diplomaProjectDbContext.Projects.Where(p => p.ProjectId == invoice.ProjectId).FirstOrDefaultAsync();
            invoice.TotalToPay = totalAmountOfHours * project.PricePerHour;
            invoice.AmountOfHours = totalAmountOfHours;
            await this.diplomaProjectDbContext.SaveChangesAsync();
            return this.mapper.Map<InvoiceDto>(invoice);
        }

        public async Task<InvoiceDto> Update(int id, InvoiceUpdateDto invoiceUpdateDto)
        {
            var invoice = await this.diplomaProjectDbContext.Invoices.Include(i => i.Project).FirstOrDefaultAsync(i => i.InvoiceId == id);
            if (invoice == null)
            {
                throw new ArgumentException("Id not existing");
            }

            invoice.Date = invoiceUpdateDto.Date;
            invoice.DueDate = invoiceUpdateDto.DueDate;
            invoice.Month = invoiceUpdateDto.Month;
            invoice.Discount = invoiceUpdateDto.Discount;
            invoice.Tax = invoiceUpdateDto.Tax;
            invoice.TotalToPay = RecalculateInvoice(invoice);
            invoice.IsInvoicePaid = invoice.IsInvoicePaid;
            this.diplomaProjectDbContext.Update(invoice);
            await this.diplomaProjectDbContext.SaveChangesAsync();
            return this.mapper.Map<InvoiceDto>(invoice);
        }

        public async Task<InvoiceDto> Delete(int id)
        {
            var invoice = await this.diplomaProjectDbContext.Invoices.FirstOrDefaultAsync(i => i.InvoiceId == id);
            if (invoice == null)
            {
                throw new ArgumentException("Id not existing");
            }

            // wyszukanie wszystkich timeEntries dla danego invoice i ustawienie ich na null 
            var timeEntries = await this.diplomaProjectDbContext.TimeEntries.Where(te => te.InvoiceId == id).ToListAsync();
            foreach (var element in timeEntries)
            {
                element.InvoiceId = null;
            }

            this.diplomaProjectDbContext.Remove(invoice);
            await this.diplomaProjectDbContext.SaveChangesAsync();
            return null;

        }

        public async Task<IEnumerable<InvoiceDto>> GetAllInvoicesForGivenProject(int projectId)
        {
            var allInvoicesForGivenProject = await this.diplomaProjectDbContext.Invoices.Where(i => i.ProjectId == projectId).ToListAsync();
            return this.mapper.Map<List<Invoice>, List<InvoiceDto>>(allInvoicesForGivenProject).OrderBy(i => i.InvoiceId);
        }

        public async Task<IEnumerable<InvoiceForClientDto>> GetInvoicesForProjectsPerClient(int clientId)
        {

            var invoicesForProjectsPerClient = await this.diplomaProjectDbContext.Invoices.Where(i => i.Project.ClientId == clientId)
                .Include(i => i.Project.Client).ToListAsync();
            if (invoicesForProjectsPerClient == null)
            {
                throw new ArgumentException("Id not existing");
            }
            return this.mapper.Map<List<Invoice>, List<InvoiceForClientDto>>(invoicesForProjectsPerClient).OrderBy(i => i.InvoiceId);

            // OPCJA 2

            //var result = new List<InvoiceForClientDto>();

            //foreach (var invoice in invoicesForProjectsPerClient)
            //{
            //    var invoiceForTimeEntries = new InvoiceForClientDto()
            //    {
            //        InvoiceId = invoice.InvoiceId,
            //        ProjectId = invoice.ProjectId,
            //        ProjectName = invoice.Project.ProjectName,
            //        ClientId = invoice.Project.ClientId,
            //        ClientName = invoice.Project.Client.ClientName,
            //        Date = invoice.Date,
            //        DueDate = invoice.DueDate,
            //        Month = invoice.Month,
            //        Discount = invoice.Discount,
            //        Tax = invoice.Tax,
            //        TotalToPay = invoice.TotalToPay,
            //        IsInvoicePaid = invoice.IsInvoicePaid,
            //    };
            //    result.Add(invoiceForTimeEntries);
            //} 
            //return result;
        }

        public async Task<IEnumerable<InvoiceForTimeEntryDto>> GetInvoiceWithTimeEntriesPerProject(int projectId)
        {
            var invoiceWithAllTimeEntriesPerProject = await this.diplomaProjectDbContext.Invoices.Where(i => i.ProjectId == projectId)
                .Include(i => i.TimeEntries).Include(i => i.Project).ToListAsync();
            if (invoiceWithAllTimeEntriesPerProject.Count == 0)  // dlaczego z null nie działa? 🤔
            {
                throw new ArgumentException("Invoice for a given project is not existing");
            }

            //var result = this.mapper.Map<List<Invoice>, List<InvoiceForTimeEntryDto>>(invoiceWithAllTimeEntriesPerProject).OrderBy(i => i.ProjectId);
            //return result.ToList();    // does not work...

            var result = new List<InvoiceForTimeEntryDto>();

            foreach (var invoice in invoiceWithAllTimeEntriesPerProject)
            {

                var invoiceForTimeEntriesDto = new InvoiceForTimeEntryDto()
                {
                    ProjectId = invoice.ProjectId,
                    ProjectName = invoice.Project.ProjectName,
                    InvoiceId = invoice.InvoiceId,
                    Date = invoice.Date,
                    DueDate = invoice.DueDate,
                    Month = invoice.Month,
                    Discount = invoice.Discount,
                    Tax = invoice.Tax,
                    TotalToPay = invoice.TotalToPay,
                    IsInvoicePaid = invoice.IsInvoicePaid,
                    TimeEntries = new List<TimeEntryDto>(),
                };

                foreach (var timeEntry in invoice.TimeEntries)
                {
                    var timeEntriesDto = new TimeEntryDto()
                    {
                        TimeEntryId = timeEntry.TimeEntryId,
                        Date = timeEntry.Date,
                        AmountOfHours = timeEntry.AmountOfHours,
                        Comment = timeEntry.Comment,
                    };
                    invoiceForTimeEntriesDto.TimeEntries.Add(timeEntriesDto);
                };
                result.Add(invoiceForTimeEntriesDto);
            }
            return result;
        }

        // DRY - do not repeat yourself
        private decimal RecalculateInvoice(Invoice invoice)
        {
            var timeEntries = this.diplomaProjectDbContext.TimeEntries.Where(te => te.Date.Month == invoice.Month).ToList();
            decimal totalAmountOfHours = 0;
            foreach (var timeEntry in timeEntries)
            {
                Debug.WriteLine("to jest iteracja");
                totalAmountOfHours = totalAmountOfHours + timeEntry.AmountOfHours;
            }
            var pricePerHour = invoice.Project.PricePerHour;
            var recalculateInvoice = totalAmountOfHours * pricePerHour;
            return recalculateInvoice;
        }
    }
}
