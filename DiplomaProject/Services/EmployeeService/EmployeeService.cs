using AutoMapper;
using System.Threading.Tasks;
using DiplomaProject.DataTransferObjects;
using DiplomaProject.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DiplomaProject.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private IMapper mapper;
        private readonly DiplomaProjectDbContext diplomaProjectDbContext;

        public EmployeeService(IMapper mapper, DiplomaProjectDbContext diplomaProjectDbContext)
        {
            this.mapper = mapper;
            this.diplomaProjectDbContext = diplomaProjectDbContext;
        }

        public Task<EmployeeDto> Create(EmployeeCreateDto employeeCreateDto)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<EmployeeDto> Update(int id, EmployeeUpdateDto employeeUpdateDto)
        {
            throw new System.NotImplementedException();
        }

        public Task<EmployeeDto> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<EmployeeDto>> Get()
        {
            var allEmployees = await this.diplomaProjectDbContext.Employees.ToListAsync();
            return this.mapper.Map<List<Employee>, List<EmployeeDto>>(allEmployees);
        }
    }
}