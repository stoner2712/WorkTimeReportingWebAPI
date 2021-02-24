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
        public ActionResult<IEnumerable> Get()
        {
            var clients = diplomaProjectDbContext.Clients;
            return Ok(clients);
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public Client Get(int id)
        {
            var client = diplomaProjectDbContext.Clients.FirstOrDefault(e => e.ClientId == id);
            return client;
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
