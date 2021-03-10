using DiplomaProject.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.Services.ProjectServiceNS
{
    public interface IProjectService
    {
        Task<IEnumerable<ProjectDto>> Get();
        Task<ProjectDto> Get(int id);
        Task<ProjectDto> Create(ProjectCreateDto projectCreateDto);
        Task<ProjectDto> Update(int id, ProjectUpdateDto projectUpdateDto);
        Task<ProjectDto> Delete(int id);
    }
}
