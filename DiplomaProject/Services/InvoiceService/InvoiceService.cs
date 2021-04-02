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
            var invoiceId = await this.diplomaProjectDbContext.Invoices.FirstOrDefaultAsync(i => i.ProjectId == invoiceCreateDto.ProjectId && i.Month == invoiceCreateDto.Month);
            // check if invoice already exist, if yes, return a relevant message 
            if (invoice.ProjectId == invoiceCreateDto.ProjectId && invoice.Month == invoiceCreateDto.Month)
            {
                throw new ArgumentException("An invoice with id number " + invoiceId.InvoiceId + " already exists for project id " + invoiceId.ProjectId + " and month " + invoiceId.Month);
            }
            await this.diplomaProjectDbContext.AddAsync(invoice);
            await this.diplomaProjectDbContext.SaveChangesAsync();
            var timeEntries = await this.diplomaProjectDbContext.TimeEntries.Where(te => te.ProjectId == invoiceCreateDto.ProjectId && te.Date.Month == invoiceCreateDto.Month).ToListAsync();
            foreach (var timeEntry in timeEntries)
            {
                timeEntry.InvoiceId = invoice.InvoiceId;   //przy\pisanie id danego invoice do time entries - krotek, czyli przypisuję FK w tabeli TimeEntry
                invoice.Amount = invoice.Amount + timeEntry.AmountOfHours;
            }
            // invoice.TotalToPay = invoice.Amount * invoice.HourlyRate;
            invoice.TotalToPay = invoice.Amount * invoice.Project.PricePerHour;
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
            invoice.Status = invoice.Status;
            this.diplomaProjectDbContext.Update(invoice);
            await this.diplomaProjectDbContext.SaveChangesAsync();
            return this.mapper.Map<InvoiceDto>(invoice);
        }

        public async Task<InvoiceDto> Delete(int id)
        {
            var invoice = await this.diplomaProjectDbContext.Invoices.FirstOrDefaultAsync(i => i.InvoiceId == id);
            // poprawić -> znależć timeentries kt należa do tego invoice i ustawić na null w kolejnosci: 1st ustawic na null, 2nd save 3rd delete
            if (invoice == null)
            {
                throw new ArgumentException("Id not existing");
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

            // OPCJA 2 - Wzór:
            //public List<Person> GetCommonFriends(List<Person> people)
            //{
            //    List<Person> common = new List<Person>();
            //    foreach (Person friend in people[0].Friends)
            //        if (people[1].Friends.Contains(friend))
            //            common.Add(friend);
            //    return common;
            //}

            // kod

            //var result = new List<InvoiceForClientDto>();

            //foreach (var invoice in invoicesForProjectsPerClient)
            //{
            //    var dto = new InvoiceForClientDto()
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
            //        Status = invoice.Status,
            //    };
            //    result.Add(dto);
            //} 
            //return result;
        }

        public async Task<IEnumerable<InvoiceForTimeEntryDto>> GetInvoiceWithTimeEntriesPerProject(int projectId)
        {
            var invoiceWithAllTimeEntriesPerProject = await this.diplomaProjectDbContext.Invoices.Where(i => i.ProjectId == projectId)
                .Include(i => i.TimeEntries).Include(i => i.Project).ToListAsync();
            if (invoiceWithAllTimeEntriesPerProject == null) // dlaczego to nie działa?
            {
                throw new ArgumentException("Invoice for a given project is not existing");
            }

            //var result = this.mapper.Map<List<Invoice>, List<InvoiceForTimeEntryDto>>(invoiceWithAllTimeEntriesPerProject).OrderBy(i => i.ProjectId);
            //return result.ToList();    // does not work...

            var result = new List<InvoiceForTimeEntryDto>();

            foreach (var invoice in invoiceWithAllTimeEntriesPerProject)
            {

                var dto = new InvoiceForTimeEntryDto()
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
                    Status = invoice.Status,
                    TimeEntries = new List<TimeEntryDto>(),
                };

                foreach (var timeEntry in invoice.TimeEntries)
                {
                    var dto2 = new TimeEntryDto()
                    {
                        TimeEntryId = timeEntry.TimeEntryId,
                        Date = timeEntry.Date,
                        AmountOfHours = timeEntry.AmountOfHours,
                        Comment = timeEntry.Comment,
                    };
                    dto.TimeEntries.Add(dto2);
                };
                result.Add(dto);
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
