using AutoMapper;
using DiplomaProject.DataTransferObjects;
using DiplomaProject.Models;
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

        public TimeEntryService(IMapper mapper, DiplomaProjectDbContext diplomaProjectDbContext)
        {
            this.mapper = mapper;
            this.diplomaProjectDbContext = diplomaProjectDbContext;
        }
        public async Task<TimeEntryDto> Create(TimeEntryCreateDto timeEntryDto)
        {
            var timeentry = this.mapper.Map<TimeEntry>(timeEntryDto);
            await this.diplomaProjectDbContext.AddAsync(timeentry);
            await this.diplomaProjectDbContext.SaveChangesAsync();
            return this.mapper.Map<TimeEntryDto>(timeentry);
        }

        public async Task<TimeEntryDto> Update(int id, TimeEntryUpdateDto timeEntryUpdateDto)
        {
            var timeentry = await this.diplomaProjectDbContext.TimeEntries.FirstOrDefaultAsync(te => te.TimeEntryId == id);
            timeentry.Date = timeEntryUpdateDto.Date;
            timeentry.AmountOfHours = timeEntryUpdateDto.AmountOfHours;
            timeentry.Comment = timeEntryUpdateDto.Comment;
            this.diplomaProjectDbContext.Update(timeentry);
            await this.diplomaProjectDbContext.SaveChangesAsync();
            return this.mapper.Map<TimeEntryDto>(timeentry);
        }

        public async Task<TimeEntryDto> Delete(int id)
        {
            var timeentry = await this.diplomaProjectDbContext.TimeEntries.FirstOrDefaultAsync(te => te.TimeEntryId == id);
            this.diplomaProjectDbContext.Remove(timeentry);
            await this.diplomaProjectDbContext.SaveChangesAsync();
            return null;
        }

        public async Task<TimeEntryDto> Get(int id)
        {
            var timeentry = await this.diplomaProjectDbContext.TimeEntries.FirstOrDefaultAsync(te => te.TimeEntryId == id);
            return this.mapper.Map<TimeEntryDto>(timeentry);
        }

        public async Task<IEnumerable<TimeEntryDto>> Get()
        {
            var allTimeEntries = await this.diplomaProjectDbContext.TimeEntries.ToListAsync();
            return this.mapper.Map<List<TimeEntry>, List<TimeEntryDto>>(allTimeEntries);
        }
    }
}
