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
            var faker = new Faker("en");

            //sprawdzenie jak działa Bogus Faker -> wstaw breakpoint przed "for" żeby nie leciało 1000 razy
            for (int i = 0; i < 100; i++)
            {
                var employee = new Employee()
                {
                    FirstName = faker.Name.FirstName(),
                    LastName = faker.Name.LastName(),
                    DateOfBirth = faker.Date.Between(new DateTime(1950,01,01),new DateTime(1999,12,31)),
                    BuildingNumber = faker.Address.BuildingNumber(),
                    StreetName = faker.Address.StreetName(),
                    PostCode = faker.Address.ZipCode(),
                    City = faker.Address.City(),
                    Country = faker.Address.Country(),
                    JobTitle = faker.Name.JobTitle(),
                };
                diplomaProjectDbContext.Employees.Add(employee);
            }
            diplomaProjectDbContext.SaveChanges();

            IEnumerable<Employee> employees = diplomaProjectDbContext.Employees.ToList();
            return BadRequest(employees);
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public string Get(int id)   // pobieranie danych, tu można wrzucic pracowników lub array stringów
                                    // i w ten sposób mam endpoint żeby pobierać tych pracowników
        {
            return "bla bla";
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
