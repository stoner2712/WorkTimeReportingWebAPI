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
    public class ClientController : ControllerBase
    {
        private readonly DiplomaProjectDbContext diplomaProjectDbContext;
        public ClientController(DiplomaProjectDbContext context)
        {
            diplomaProjectDbContext = context;
        }

        // GET: api/<ClientController>
        [HttpGet]
        public IEnumerable Get()
        {
            var faker = new Faker("en");

            for (int i = 0; i < 100; i++)
            {
                var client = new Client()
                {
                    ClientName = faker.Company.CompanyName(),
                    BuildingNumber = faker.Address.BuildingNumber(),
                    StreetName = faker.Address.StreetName(),
                    PostCode = faker.Address.ZipCode(),
                    City = faker.Address.City(),
                    Country = faker.Address.Country(),
                };
                diplomaProjectDbContext.Clients.Add(client);
            }
            diplomaProjectDbContext.SaveChanges();

            IEnumerable<Client> clients = diplomaProjectDbContext.Clients.ToList();
            return clients;
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClientController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
