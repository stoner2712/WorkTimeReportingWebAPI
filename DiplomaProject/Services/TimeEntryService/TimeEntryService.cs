using AutoMapper;
using DiplomaProject.DataTransferObjects;
using DiplomaProject.Models;
using DiplomaProject.Services.InvoiceServiceNS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.Services.TimeEntryServiceNS
{
    public class TimeEntryService : ITimeEntryService
    {
        private IMapper mapper;
        private readonly DiplomaProjectDbContext diplomaProjectDbContext;

        private readonly IInvoiceService invoiceService;

        public TimeEntryService(IMapper mapper, DiplomaProjectDbContext diplomaProjectDbContext, IInvoiceService invoiceService)
        {
            this.mapper = mapper;
            this.diplomaProjectDbContext = diplomaProjectDbContext;
            this.invoiceService = invoiceService;
        }
        public async Task<TimeEntryDto> Create(TimeEntryCreateDto timeEntryDto)
        {

            var timeEntry = this.mapper.Map<TimeEntry>(timeEntryDto);
            var isPeriodClosedCheck = invoiceService.CheckIfInvoicePeriodIsClosed(timeEntry.Date.Month, timeEntry.ProjectId);
            if (isPeriodClosedCheck)
            {
                throw new ArgumentException("This action stopped due to invoice period already closed");
            }

            await this.diplomaProjectDbContext.AddAsync(timeEntry);
            await this.diplomaProjectDbContext.SaveChangesAsync();
            return this.mapper.Map<TimeEntryDto>(timeEntry);
        }

        public async Task<TimeEntryDto> Update(int timeEntryId, TimeEntryUpdateDto timeEntryUpdateDto)
        {
            var timeEntry = await this.diplomaProjectDbContext.TimeEntries.FirstOrDefaultAsync(te => te.TimeEntryId == timeEntryId);
            if (timeEntry == null)
            {
                throw new ArgumentException("Id not existing");
            }

            var isPeriodClosedCheck = invoiceService.CheckIfInvoicePeriodIsClosed(timeEntry.Date.Month, timeEntry.ProjectId);
            if (isPeriodClosedCheck)
            {
                throw new ArgumentException("This action stopped due to invoice period already closed");
            }

            var invoicePeriodClosed = await this.diplomaProjectDbContext.Invoices.Where(i => i.IsInvoicePeriodClosed == true).ToListAsync();

            foreach (var invoice in invoicePeriodClosed)
            {
                if (timeEntryUpdateDto.Date.Month == invoice.Month)
                {
                    throw new ArgumentException("This period for this project is closed. Please check the date.");
                }
            }

            timeEntry.Date = timeEntryUpdateDto.Date;
            timeEntry.AmountOfHours = timeEntryUpdateDto.AmountOfHours;
            timeEntry.Comment = timeEntryUpdateDto.Comment;
            this.diplomaProjectDbContext.Update(timeEntry);
            await this.diplomaProjectDbContext.SaveChangesAsync();
            return this.mapper.Map<TimeEntryDto>(timeEntry);
        }

        public async Task<TimeEntryDto> Delete(int id)
        {
            var timeEntry = await this.diplomaProjectDbContext.TimeEntries.FirstOrDefaultAsync(te => te.TimeEntryId == id);
            if (timeEntry == null)
            {
                throw new ArgumentException("Id not existing");
            }

            var isPeriodClosedCheck = invoiceService.CheckIfInvoicePeriodIsClosed(timeEntry.Date.Month, timeEntry.ProjectId);
            if (isPeriodClosedCheck)
            {
                throw new ArgumentException("This action stopped due to invoice period already closed");
            }

            this.diplomaProjectDbContext.Remove(timeEntry);
            await this.diplomaProjectDbContext.SaveChangesAsync();
            return null;
        }

        public async Task<TimeEntryDto> Get(int id)
        {
            var timeEntry = await this.diplomaProjectDbContext.TimeEntries.FirstOrDefaultAsync(te => te.TimeEntryId == id);
            if (timeEntry == null)
            {
                throw new ArgumentException("Id not existing");
            }
            return this.mapper.Map<TimeEntryDto>(timeEntry);
        }

        public async Task<IEnumerable<TimeEntryDto>> Get()
        {
            var allTimeEntries = await this.diplomaProjectDbContext.TimeEntries.ToListAsync();
            return this.mapper.Map<List<TimeEntry>, List<TimeEntryDto>>(allTimeEntries);
        }

        public async Task<IEnumerable<TimeEntryDto>> GetTimeEntriesForEmployee(int employeeId, int monthNumber) 
        {
            var allTimeEntriesForEmployeePerMonth = await this.diplomaProjectDbContext.TimeEntries.Where(te => te.EmployeeId == employeeId && te.Date.Month == monthNumber).ToListAsync();
            return this.mapper.Map<IEnumerable<TimeEntry>, List<TimeEntryDto>>(allTimeEntriesForEmployeePerMonth).OrderBy(te => te.TimeEntryId);
        }

        public async Task<IEnumerable<TimeEntryDto>> GetAllTimeEntriesForGivenMonth(int monthNumber)
        {
            var allTimeEntriesForGivenMonth = await this.diplomaProjectDbContext.TimeEntries.Where(te => te.Date.Month == monthNumber).ToListAsync();
            return this.mapper.Map<IEnumerable<TimeEntry>, List<TimeEntryDto>>(allTimeEntriesForGivenMonth).OrderBy(te => te.TimeEntryId);
        }

        public async Task<IEnumerable<TimeEntryDto>> GetTimeEntriesForProjectPerMonth(int projectId, int monthNumber)
        {
            var allTimeEntriesForProjectPerMonth = await this.diplomaProjectDbContext.TimeEntries.Where(te => te.ProjectId == projectId && te.Date.Month == monthNumber).ToListAsync();
            return this.mapper.Map<List<TimeEntry>, List<TimeEntryDto>>(allTimeEntriesForProjectPerMonth).OrderBy(te => te.TimeEntryId);
        }

        public async Task<IEnumerable<TimeEntryDto>> GetAllTimeEntriesForProjectFromBegining(int projectId)
        {
            var allTimeEntriesForProjectFromBegining = await this.diplomaProjectDbContext.TimeEntries.Where(te => te.ProjectId == projectId).ToListAsync();
            return this.mapper.Map<List<TimeEntry>, List<TimeEntryDto>>(allTimeEntriesForProjectFromBegining).OrderBy(te => te.TimeEntryId);
        }
    }
}