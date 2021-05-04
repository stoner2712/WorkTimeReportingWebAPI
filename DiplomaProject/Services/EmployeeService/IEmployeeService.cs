using System.Collections.Generic;
using System.Threading.Tasks;
using DiplomaProject.DataTransferObjects;
using DiplomaProject.Models;

namespace DiplomaProject.Services.EmployeeServiceNS
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> Get();
        Task<EmployeeDto> Get(int id);
        Task<EmployeeDto> Create(EmployeeCreateDto employeeCreateDto);
        Task<EmployeeDto> Update(int id, EmployeeUpdateDto employeeUpdateDto);
        Task<EmployeeDto> Delete(int id);    // tu dodałem EmployeeDto, bo nie działało bez tego
        Task<IEnumerable<EmployeeDto>> GetAllEmployeesWorkingOnProject(int projectId);
        Task<Employee> GetEmployeeByUserName(string userName);
    }
}
