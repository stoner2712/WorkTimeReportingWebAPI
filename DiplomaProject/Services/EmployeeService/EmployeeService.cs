using AutoMapper;
using System.Threading.Tasks;
using DiplomaProject.DataTransferObjects;
using DiplomaProject.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace DiplomaProject.Services.EmployeeServiceNS
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

        public async Task<EmployeeDto> Create(EmployeeCreateDto employeeDto)
        {
            // mapujemy employeeDto na Employee, i z employeeDto tworzymy obiekt employee
            var employee = this.mapper.Map<Employee>(employeeDto); // w IEmployeeService jest Create(EmployeeCreateDto employeeCreateDto) czy tu tez ma byc employeeCreateDto
            //wołam teraz baza danych czyli diplomaProjectDbContext i chcemy do niej dodac (Add) nowego employee
            // dodajemy parametr employee, który nazywa sie entity wg metody Add, która ma parametr (Employee entity)
            await this.diplomaProjectDbContext.AddAsync(employee);
            await this.diplomaProjectDbContext.SaveChangesAsync();
            // teraz zwracamy w przeglądarce stworzony obiekt employee:          ???
            // deklarujemy typ zwracany: EmployeeDto                             ????
            // mapujemy employee na DataTransferObject, czyli -> EmployeeDto      ???
            return this.mapper.Map<EmployeeDto>(employee);
        }

        public async Task<EmployeeDto> Delete(int id)
        {
            var employee = await this.diplomaProjectDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == id);
            if (employee == null)
            {
                throw new ArgumentException("Id not existing");
            }
            this.diplomaProjectDbContext.Remove(employee);
            await this.diplomaProjectDbContext.SaveChangesAsync();
            //return this.mapper.Map<EmployeeDto>(employee);          // to też działa, ale co lepsze. Po drugie gdy nie było id to wywala błąd...zamisat catch BadRequest
            return null;
        }

        public async Task<EmployeeDto> Update(int id, EmployeeUpdateDto employeeUpdateDto)
        {
            var employee = await this.diplomaProjectDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == id);
            if(employee == null)
            {
                throw new ArgumentException("Id not existing");
            }
            employee.FirstName = employeeUpdateDto.FirstName;
            employee.LastName = employeeUpdateDto.LastName;
            employee.DateOfBirth = employeeUpdateDto.DateOfBirth;
            employee.JobTitle = employeeUpdateDto.JobTitle;
            //employee.StreetName = "Mickiewicza";   // mozna na sztywno ustawić i będzie wpisywac się dla kazdego updatowanego
            this.diplomaProjectDbContext.Update(employee);
            await this.diplomaProjectDbContext.SaveChangesAsync();
            return this.mapper.Map<EmployeeDto>(employee); //wyświetlamy tego pracownika po zmianach zmapowane na EmployeeDto
        }

        public async Task<EmployeeDto> Get(int id)
        {
            var employee = await this.diplomaProjectDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == id);
            if(employee == null)
            {
                throw new ArgumentException("Id not existing");
            }
            return this.mapper.Map<EmployeeDto>(employee);
        }

        public async Task<IEnumerable<EmployeeDto>> Get()
        {
            var allEmployees = await this.diplomaProjectDbContext.Employees.ToListAsync();
            return this.mapper.Map<List<Employee>, List<EmployeeDto>>(allEmployees);
        }

        public async Task<IEnumerable<EmployeeDto>> GetAllEmployeesWorkingOnProject(int projectId)
        {
            var allEmployeesWorkingOnProject = await this.diplomaProjectDbContext.Employees.Where(e => e.EmployeeProjects.Any(ep => ep.ProjectId == projectId)).ToListAsync();
            return this.mapper.Map<List<Employee>, List<EmployeeDto>>(allEmployeesWorkingOnProject).OrderBy(e => e.EmployeeId);
        }
    }
}