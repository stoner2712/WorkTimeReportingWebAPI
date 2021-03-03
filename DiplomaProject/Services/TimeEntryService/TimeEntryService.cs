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
        public Task<TimeEntryDto> Create(TimeEntryCreateDto timeEntryCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task<TimeEntryDto> Update(int id, TimeEntryUpdateDto timeEntryUpdateDto)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TimeEntryDto> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TimeEntryDto>> Get()
        {
            var allTimeEntries = await this.diplomaProjectDbContext.TimeEntries.ToListAsync();
            return this.mapper.Map<List<TimeEntry>, List<TimeEntryDto>>(allTimeEntries);
        }
    }
}
