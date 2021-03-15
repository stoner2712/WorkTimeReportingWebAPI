using AutoMapper;
using DiplomaProject.DataTransferObjects;
using DiplomaProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.Services.ProjectServiceNS
{
    public class ProjectService : IProjectService
    {
        private IMapper mapper;
        private readonly DiplomaProjectDbContext diplomaProjectDbContext;

        public ProjectService(IMapper mapper, DiplomaProjectDbContext diplomaProjectDbContext)
        {
            this.mapper = mapper;
            this.diplomaProjectDbContext = diplomaProjectDbContext;
        }

        public async Task<IEnumerable<ProjectDto>> Get()
        {
            var allProjects = await this.diplomaProjectDbContext.Projects.ToListAsync();
            return this.mapper.Map<List<Project>, List<ProjectDto>>(allProjects);
        }

        public async Task<ProjectDto> Get(int id)
        {
            var project = await this.diplomaProjectDbContext.Projects.FirstOrDefaultAsync(p => p.ProjectId == id);
            if (project == null)
            {
                throw new ArgumentException("Id not existing");
            }
            return this.mapper.Map<ProjectDto>(project);
        }

        public async Task<ProjectDto> Create(ProjectCreateDto projectDto)
        {
            var project = this.mapper.Map<Project>(projectDto);
            await this.diplomaProjectDbContext.AddAsync(project);
            await this.diplomaProjectDbContext.SaveChangesAsync();
            return this.mapper.Map<ProjectDto>(project);
        }

        public async Task<ProjectDto> Update(int id, ProjectUpdateDto projectUpdateDto)
        {
            var project = await this.diplomaProjectDbContext.Projects.FirstOrDefaultAsync(p => p.ProjectId == id);
            if (project == null)
            {
                throw new ArgumentException("Id not existing");
            }
            project.PricePerHour = projectUpdateDto.PricePerHour;
            this.diplomaProjectDbContext.Update(project);
            await this.diplomaProjectDbContext.SaveChangesAsync();
            return this.mapper.Map<ProjectDto>(project);
        }

        public async Task<ProjectDto> Delete(int id)
        {
            var project = await this.diplomaProjectDbContext.Projects.FirstOrDefaultAsync(p => p.ProjectId == id);
            if (project == null)
            {
                throw new ArgumentException("Id not existing");
            }
            this.diplomaProjectDbContext.Remove(project);
            await this.diplomaProjectDbContext.SaveChangesAsync();
            return null;
        }

        public async Task<IEnumerable<ProjectDto>> GetAllProjectsForAnEmployee(int employeeId)
        {
            var allProjectsForAnEmployee = await this.diplomaProjectDbContext.Projects.Where(p => p.EmployeesProject.Any(ep => ep.EmployeeId == employeeId)).ToListAsync();
            return this.mapper.Map<List<Project>, List<ProjectDto>>(allProjectsForAnEmployee).OrderBy(p => p.ProjectId);
        }

        public async Task<IEnumerable<ProjectDto>> GetAllProjectsFromAClient(int clientId)
        {
            var allProjectsFromAClient = await this.diplomaProjectDbContext.Projects.Where(p => p.ClientId == clientId).ToListAsync();
            return this.mapper.Map<List<Project>, List<ProjectDto>>(allProjectsFromAClient).OrderBy(p => p.ProjectId);
        }
    }
}
