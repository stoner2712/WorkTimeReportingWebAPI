using AutoMapper;
using DiplomaProject.DataTransferObjects;
using DiplomaProject.Models;
using DiplomaProject.Services.TimeEntryServiceNS;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DiplomaProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeEntryController : ControllerBase
    {
        private ITimeEntryService  timeEntryService;
        private IMapper _mapper;
        private readonly DiplomaProjectDbContext diplomaProjectDbContext;
        //private HttpStatusCode _httpStatusCode;
        public TimeEntryController(ITimeEntryService timeEntryService, IMapper mapper, DiplomaProjectDbContext diplomaProjectDbContext) //HttpStatusCode httpStatusCode
        {
            this.timeEntryService = timeEntryService;
            this.diplomaProjectDbContext = diplomaProjectDbContext;
            _mapper = mapper;
            //_httpStatusCode = httpStatusCode;
        }

        /// <summary>
        /// Find all the time entries
        /// </summary>
        /// <returns></returns>
        // GET: api/<TimeEntryController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable>> Get()
        {
            try
            {
                var allTimeEntries = await this.timeEntryService.Get();
                return Ok(allTimeEntries);
            }
            catch (Exception te)
            {
                return BadRequest(te);
            }
        }

        /// <summary>
        /// Find a time entry - search by [id]
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<TimeEntryController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable>> Get(int id)
        {
            try
            {
                var timeEntryResult = await this.timeEntryService.Get(id);
                return Ok(timeEntryResult);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Create a time entry
        /// </summary>
        /// <param name="timeEntryDto"></param>
        /// <returns></returns>
        // POST api/<TimeEntryController>
        [HttpPost]
        public ActionResult<TimeEntryDto> Post([FromBody] TimeEntryCreateDto timeEntryDto)
        {
            var timeentry = _mapper.Map<TimeEntry>(timeEntryDto);
            diplomaProjectDbContext.Add(timeentry);
            diplomaProjectDbContext.SaveChanges();
            return Ok(_mapper.Map<TimeEntryDto>(timeentry));
        }

        /// <summary>
        /// Update a time entry - search by [id]
        /// </summary>
        /// <param name="id"></param>
        /// <param name="timeEntryDto"></param>
        // PUT api/<TimeEntryController>/5
        [HttpPut("{id}")]
        public ActionResult<TimeEntryDto> Put(int id, [FromBody] TimeEntryUpdateDto timeEntryDto)
        {
            var timeentry = diplomaProjectDbContext.TimeEntries.FirstOrDefault(te => te.TimeEntryId == id);

            //if (id == null)
            //{
            //    //return NotFound("[id] number does not exist, please type in different [id].");
            //    return new HttpStatusCode(HttpStatusCode.BadRequest);
            //}
            //TimeEntry timeEntry = diplomaProjectDbContext.TimeEntries.Find(id);

            if (timeentry == null)
            {
                return NotFound("Time entry with id " + id + " does not exist, please type in different id.");
                //return HttpNotFound;
            }
            else
            {
                timeentry.Date = timeEntryDto.Date;
                timeentry.AmountOfHours = timeEntryDto.AmountOfHours;
                timeentry.Comment = timeEntryDto.Comment;
                diplomaProjectDbContext.Update(timeentry);
                diplomaProjectDbContext.SaveChanges();
                return _mapper.Map<TimeEntryDto>(timeentry);
            }
        }

        /// <summary>
        /// Delete a time entry - search by [id]
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // DELETE api/<TimeEntryController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var timeentry = diplomaProjectDbContext.TimeEntries.FirstOrDefault(te => te.TimeEntryId == id);
            if (timeentry == null)
            {
                return NotFound("Time entry with id " + id + " does not exist, please type in different id.");
            }
            else
            {
                diplomaProjectDbContext.Remove(timeentry);
                diplomaProjectDbContext.SaveChanges();
                return Ok("Time entry with id " + timeentry.TimeEntryId + " has been successfully deleted.");
            }
        }
    }
}
