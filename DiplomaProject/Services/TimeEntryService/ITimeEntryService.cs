using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiplomaProject.DataTransferObjects;

namespace DiplomaProject.Services.TimeEntryServiceNS
{
    public interface ITimeEntryService
    {
        Task<TimeEntryDto> Get(int id);
        Task<IEnumerable<TimeEntryDto>> Get();
        Task<TimeEntryDto> Update(int id, TimeEntryUpdateDto timeEntryUpdateDto);
        Task<TimeEntryDto> Create(TimeEntryCreateDto timeEntryCreateDto);
        Task<TimeEntryDto> Delete(int id);
    }
}
