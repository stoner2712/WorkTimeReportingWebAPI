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
    public class ProjectController : ControllerBase
    {
        private readonly DiplomaProjectDbContext diplomaProjectDbContext;
        public ProjectController(DiplomaProjectDbContext context)
        {
            diplomaProjectDbContext = context;
        }

        // GET: api/<InvoicesController>
        [HttpGet]
        public ActionResult<IEnumerable> Get()
        {
            var projects = diplomaProjectDbContext.Projects;
            return Ok(projects);
        }

        // GET api/<ProjectController>/5
        [HttpGet("{id}")]
        public Project Get(int id)
        {
            var project = diplomaProjectDbContext.Projects.FirstOrDefault(e => e.ProjectId == id);
            return project;
        }

        // POST api/<ProjectController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProjectController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProjectController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
