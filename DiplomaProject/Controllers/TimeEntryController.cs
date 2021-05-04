using AutoMapper;
using DiplomaProject.DataTransferObjects;
using DiplomaProject.Models;
using DiplomaProject.Services.TimeEntryServiceNS;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    [ApiController]
    public class TimeEntryController : ControllerBase
    {
        private ITimeEntryService timeEntryService;
        public TimeEntryController(ITimeEntryService timeEntryService)
        {
            this.timeEntryService = timeEntryService;
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
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                var timeentry = await this.timeEntryService.Get(id);
                return Ok(timeentry);
            }
            catch (ArgumentException e)  //wyjątki zaczynamy od bardziej szczegółowych do ogólnych, bo gdyby na odwrót, to ogólny złapałby all i szczegółowy nigdy by sie nie wywołał
            {
                return BadRequest(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Create a new time entry
        /// </summary>
        /// <param name="timeEntryDto"></param>
       /// <returns></returns>
        // POST api/<TimeEntryController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] TimeEntryCreateDto timeEntryDto)
        {
            try
            {
                var timeentry = await this.timeEntryService.Create(timeEntryDto);
                return Ok(timeentry); //zwracamy nowe timeentry na TimeEntryDto (to co widzi Klient)   ????
            }
            catch (ArgumentException e)
            {
                return Ok(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Update a time entry - search by [id]
        /// </summary>
        /// <param name="id"></param>
        /// <param name="timeEntryUpdateDto"></param>
        // PUT api/<TimeEntryController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] TimeEntryUpdateDto timeEntryUpdateDto)
        {
            try
            {
                var timeentry = await this.timeEntryService.Update(id, timeEntryUpdateDto);
                return Ok(timeentry);
            }
            catch (ArgumentException e)  //wyjątki zaczynamy od bardziej szczegółowych do ogólnych, bo gdyby na odwrót, to ogólny złapałby all i szczegółowy nigdy by sie nie wywołał
            {
                return BadRequest(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Delete a time entry - search by [id]
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // DELETE api/<TimeEntryController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var timeentry = await this.timeEntryService.Delete(id);
                return Ok();
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Find all the time entries for an employee in a given month - search by employee {id} and month number
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="monthNumber"></param>
        /// <param name="test"></param>
        /// <returns></returns>
        [HttpGet("Employee/{employeeId}/Month/{monthNumber}")]
        public async Task<ActionResult> GetTimeEntriesForEmployee(int employeeId, int monthNumber, int test)
        {
            try
            {
                var timeEntriesForEmployee = await this.timeEntryService.GetTimeEntriesForEmployee(employeeId, monthNumber);
                return Ok(timeEntriesForEmployee);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Find all the time entries for all the employees in a given month - search by month number
        /// </summary>
        /// <param name="monthNumber"></param>
        /// <returns></returns>
        [HttpGet("Month/{monthNumber}")]
        public async Task<ActionResult> GetAllTimeEntriesForGivenMonth(int monthNumber)
        {
            try
            {
                var allTimeEntriesForGivenMonth = await this.timeEntryService.GetAllTimeEntriesForGivenMonth(monthNumber);
                return Ok(allTimeEntriesForGivenMonth);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Find all the time entries for a project in a given month - search by project {id} and month number
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="monthNumber"></param>
        /// <returns></returns>
        [HttpGet("Project/{projectId}/Month{monthNumber}")]
        public async Task<ActionResult> GetTimeEntriesForProjectPerMonth(int projectId, int monthNumber)
        {
            try
            {
                var getAllTimeEntriesForProjectPerMonth = await this.timeEntryService.GetTimeEntriesForProjectPerMonth(projectId, monthNumber);
                return Ok(getAllTimeEntriesForProjectPerMonth);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Find all the time entries for a project from the begining - search by project {id} 
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        [HttpGet("Project/{projectId}")]
        public async Task<ActionResult> GetAllTimeEntriesForProjectFromBegining(int projectId)
        {
            try
            {
                var allTimeEntriesForProjectFromBegining = await this.timeEntryService.GetAllTimeEntriesForProjectFromBegining(projectId);
                return Ok(allTimeEntriesForProjectFromBegining);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}