using DiplomaProject.DataTransferObjects;
using DiplomaProject.Models;
using DiplomaProject.Services.ProjectServiceNS;
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
        private IProjectService projectService;
        public ProjectController(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        /// <summary>
        /// Find all the projects
        /// </summary>
        /// <returns></returns>
        // GET: api/<InvoicesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable>> Get()
        {
            try
            {
                var allProjects = await this.projectService.Get();
                return Ok(allProjects);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Find a project - search by {id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<ProjectController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                var project = await this.projectService.Get(id);
                return Ok(project);
            }
            catch (ArgumentException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Create a new project
        /// </summary>
        /// <param name="projectDto"></param>
        // POST api/<ProjectController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ProjectCreateDto projectDto)
        {
            try
            {
                var project = await this.projectService.Create(projectDto);
                return Ok(project);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Update a project - search by {id}
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectUpdateDto"></param>
        /// <returns></returns>
        // PUT api/<ProjectController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ProjectUpdateDto projectUpdateDto)
        {
            try
            {
                var project = await this.projectService.Update(id, projectUpdateDto);
                return Ok(project);
            }
            catch (ArgumentException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Delete a project - search by {id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // DELETE api/<ProjectController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var client = await this.projectService.Delete(id);
                return Ok();
            }
            catch (ArgumentException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Find all the projects for an employee - search by employee {id}
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        [HttpGet("Employee/{employeeId}")]
        public async Task<ActionResult> GetAllProjectsForAnEmployee(int employeeId)
        {
            try
            {
                var getAllProjectsForAnEmployee = await this.projectService.GetAllProjectsForAnEmployee(employeeId);
                return Ok(getAllProjectsForAnEmployee);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Find all the projects from a client - search by client {id}
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        [HttpGet("Client/{clientId}")]
        public async Task<ActionResult> GetAllProjectsFromAClient(int clientId)
        {
            try
            {
                var getAllProjectsFromAClient = await this.projectService.GetAllProjectsFromAClient(clientId);
                return Ok(getAllProjectsFromAClient);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
