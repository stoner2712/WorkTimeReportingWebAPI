using System.Collections.Generic;
using System.Threading.Tasks;
using DiplomaProject.DataTransferObjects;

namespace DiplomaProject.Services.EmployeeService
{
    public interface IEmployeeService
    {
        Task<EmployeeDto> Get(int id);
        Task<IEnumerable<EmployeeDto>> Get();
        Task<EmployeeDto> Update(int id, EmployeeUpdateDto employeeUpdateDto);
        Task<EmployeeDto> Create(EmployeeCreateDto employeeCreateDto);
        Task Delete(int id);
    }
}
