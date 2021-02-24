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
    public class EmployeeProjectController : ControllerBase
    {

        private readonly DiplomaProjectDbContext diplomaProjectDbContext;
        public EmployeeProjectController(DiplomaProjectDbContext context)
        {
            diplomaProjectDbContext = context;
        }

        // GET: api/<EmployeeProjectController>
        [HttpGet]
        public ActionResult<IEnumerable> Get()
        {
            var employeesProjectsList = diplomaProjectDbContext.EmployeeProjects;
            return Ok(employeesProjectsList);
        }

        // GET api/<EmployeeProjectController>/5
        [HttpGet("{id}")]
        public EmployeeProject Get(int id)
        {
            var ep = diplomaProjectDbContext.EmployeeProjects.FirstOrDefault(e => e.EmployeeId == id);
            return ep;
        }

        // POST api/<EmployeeProjectController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeProjectController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeProjectController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
