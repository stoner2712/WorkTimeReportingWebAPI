using AutoMapper;
using DiplomaProject.DataTransferObjects;
using DiplomaProject.Models;
using DiplomaProject.Services.EmployeeServiceNS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService employeeService;


        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        /// <summary>
        /// Find all the employees
        /// </summary>
        /// <returns></returns>
        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable>> Get()
        {
            try
            {
                var allEmployees = await this.employeeService.Get();
                return Ok(allEmployees);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Find an employee - search by {id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                var employee = await this.employeeService.Get(id);
                return Ok(employee);
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
        /// Create a new employee
        /// </summary>
        /// <param name="employeeDto"></param>
        /// <returns></returns>
        // POST api/<EmployeeController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EmployeeCreateDto employeeDto)
        {
            try
            {
                var employee = await this.employeeService.Create(employeeDto);
                return Ok(employee); 
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Update an employee - search by {id}
        /// </summary>
        /// <param name="id"></param>
        /// <param name="employeeUpdateDto"></param>
        /// <returns></returns>
        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] EmployeeUpdateDto employeeUpdateDto)
        {
            try
            {
                var employee = await this.employeeService.Update(id, employeeUpdateDto);
                return Ok(employee); 
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
        /// Delete an employee - search by {id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var employee = await this.employeeService.Delete(id); 
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
        /// Find all the employees working on a given project - search by project {id}
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        [HttpGet("Project/{projectId}")]
        public async Task<ActionResult> GetAllEmployeesWorkingOnProject(int projectId)
        {
            try
            {
                var allEmployeesWorkingOnProject = await this.employeeService.GetAllEmployeesWorkingOnProject(projectId);
                return Ok(allEmployeesWorkingOnProject);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}