using Bogus;
using DiplomaProject.Models;
using DiplomaProject.Services.ClientServiceNS;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiplomaProject.DataTransferObjects;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DiplomaProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IClientService clientService;
        public ClientController(IClientService clientService)
        {
            this.clientService = clientService;
        }

        /// <summary>
        /// Find all the clients
        /// </summary>
        /// <returns></returns>
        // GET: api/<ClientController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable>> Get()
        {
            try
            {
                var allClients = await this.clientService.Get();
                return Ok(allClients);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Find a client - search by {id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                var client = await this.clientService.Get(id);
                return Ok(client);
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
        /// Create a new client
        /// </summary>
        /// <param name="clientDto"></param>
        /// <returns></returns>
        // POST api/<ClientController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ClientCreateDto clientDto)
        {
            try
            {
                var client = await this.clientService.Create(clientDto);
                return Ok(client);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Update a client - search by {id}
        /// </summary>
        /// <param name="id"></param>
        /// <param name="clientUpdateDto"></param>
        /// <returns></returns>
        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ClientUpdateDto clientUpdateDto)
        {
            try
            {
                var client = await this.clientService.Update(id, clientUpdateDto);
                return Ok(client);
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
        /// Delete a client - search by {id}
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var client = await this.clientService.Delete(id);
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
    }
}
