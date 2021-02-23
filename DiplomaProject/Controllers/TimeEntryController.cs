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
    public class TimeEntryController : ControllerBase
    {
        private readonly DiplomaProjectDbContext diplomaProjectDbContext;
        public TimeEntryController(DiplomaProjectDbContext context)
        {
            diplomaProjectDbContext = context;
        }

        // GET: api/<InvoicesController>
        [HttpGet]
        public ActionResult<IEnumerable> Get()
        {
            var timeentries = diplomaProjectDbContext.TimeEntries;
            return Ok(timeentries);
        }

        // GET api/<TimeEntryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TimeEntryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TimeEntryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TimeEntryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
