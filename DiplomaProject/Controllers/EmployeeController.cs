using Bogus;
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
        private readonly DiplomaProjectDbContext diplomaProjectDbContext;
        public EmployeeController(DiplomaProjectDbContext context)
        {
            diplomaProjectDbContext = context;
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
        public Employee Get(int id)   // pobieranie danych, tu można wrzucic pracowników lub array stringów
                                                  // i w ten sposób mam endpoint żeby pobierać tych pracowników
        {
            
            var employee = diplomaProjectDbContext.Employees.FirstOrDefault(e=>e.EmployeeId==id);  // e, to predykat kt zwraca true or false, '=>' ozn lambda
            return employee;
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public string Post([FromBody] string value)
        {
            Console.WriteLine("cos tam " + value);
            return "bye";
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
