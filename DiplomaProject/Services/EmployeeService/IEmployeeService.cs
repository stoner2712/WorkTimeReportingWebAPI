using System.Collections.Generic;
using System.Threading.Tasks;
using DiplomaProject.DataTransferObjects;

namespace DiplomaProject.Services.EmployeeServiceNS
{
    public interface IEmployeeService
    {
        Task<EmployeeDto> Get(int id);
        Task<IEnumerable<EmployeeDto>> Get();
        Task<EmployeeDto> Update(int id, EmployeeUpdateDto employeeUpdateDto);
        Task<EmployeeDto> Create(EmployeeCreateDto employeeCreateDto);
        Task<EmployeeDto> Delete(int id);    // tu dodałem EmployeeDto, bo nie działało bez tego
    }
}
