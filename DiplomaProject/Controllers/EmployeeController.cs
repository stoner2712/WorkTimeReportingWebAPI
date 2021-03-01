using AutoMapper;
using Bogus;
using DiplomaProject.DataTransferObjects;
using DiplomaProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DiplomaProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IMapper _mapper;

        private readonly DiplomaProjectDbContext diplomaProjectDbContext;
        public EmployeeController(DiplomaProjectDbContext context, IMapper mapper)
        {
            diplomaProjectDbContext = context;
            _mapper = mapper;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public ActionResult<IEnumerable> Get()
        {
            var employees = diplomaProjectDbContext.Employees;           // await wraca w to miejsce w kodzie i zawsze musi być połączony z async
                                                                         // odczyt z bazy danych to blokująca operacja i async pozwala na dzalsze działanie aplikacji
            return Ok(employees);
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public EmployeeDto Get(int id)   // pobieranie danych, tu można wrzucic pracowników lub array stringów
                                         // i w ten sposób mam endpoint żeby pobierać tych pracowników

        {
            var employee = diplomaProjectDbContext.Employees.FirstOrDefault(e => e.EmployeeId == id); // e, to predykat kt zwraca true or false, '=>' ozn lambda
            // 2 breakpointy na linia wyżej i return
            // tworzymy zmienna employeDto, żeby do nie zapisać to co po znaku = 
            var employeeDto = _mapper.Map<EmployeeDto>(employee); // EmployeeDto = destination, nawiasy okrągłe, to wywołanie tej metody, i wew jest source
            return employeeDto;
        }

        // POST api/<EmployeeController>
        [HttpPost]
        // metoda POST zwracająca typ EmployeeDto
        public EmployeeDto Post([FromBody] EmployeeDtoCreate employeeDto)
        {
            // mapujemy teraz employeeDto na Employee, i z employeeDto tworzymy Employee
            // wyciągamy też employee z employeeDto, stad var employee 
            var employee = _mapper.Map<Employee>(employeeDto);
            //wołam teraz baza danych czyli diplomaProjectDbContext i chcemy do niej dodac (Add) nowego employee
            // dodajemy parametr employee, który nazywa sie entity wg metody Add, która ma parametr (Employee entity)
            diplomaProjectDbContext.Add(employee); // dodajemy employee do bazy danych -> diplomaProjectDbContext
            diplomaProjectDbContext.SaveChanges(); // zachowujemy zmiany w bazie danych
            // teraz zwracamy w przeglądarce stworzony obiekt employee:
            // deklarujemy typ zwracany: EmployeeDto
            // mapujemy employee na DataTransferObject, czyli -> EmployeeDto
            return _mapper.Map<EmployeeDto>(employee); //zwracamy nowego employee na EmployeeDto (to co widzi Klient)
        }

        /// <summary>
        /// Update an Employee by {id}
        /// </summary>
        /// <param name="id"></param>
        /// <param name="employeeDto"></param>
        /// <returns></returns>
        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public EmployeeDto Put(int id, [FromBody] EmployeeDtoUpdate employeeDto)
        {
            var employee = diplomaProjectDbContext.Employees.FirstOrDefault(e => e.EmployeeId == id); // wyszukujemy employee po id
            employee.FirstName = employeeDto.FirstName;
            employee.LastName = employeeDto.LastName;
            employee.DateOfBirth = employeeDto.DateOfBirth;
            employee.JobTitle = employeeDto.JobTitle;
            //employee.StreetName = "Mickiewicza";   // mozna na sztywno ustawić i będzie wpisywac się dla kazdego updatowanego
            diplomaProjectDbContext.Update(employee);
            diplomaProjectDbContext.SaveChanges();  // zachowujemy zmiany w bazie
            return _mapper.Map<EmployeeDto>(employee); //wyświetlamy tego pracownika po zmianach zmapowane na EmployeeDto
        }

        /// <summary>
        /// DELETE an Employee by {id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var employee = diplomaProjectDbContext.Employees.FirstOrDefault(e => e.EmployeeId == id);
            diplomaProjectDbContext.Remove(employee);
            diplomaProjectDbContext.SaveChanges();
            return Ok();
        }
    }
}