using AutoMapper;
using DiplomaProject.DataTransferObjects;
using DiplomaProject.Models;
using DiplomaProject.Services.EmployeeServiceNS;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService employeeService;
        private IMapper _mapper;
        private readonly DiplomaProjectDbContext diplomaProjectDbContext;

        public EmployeeController(IEmployeeService employeeService, IMapper mapper, DiplomaProjectDbContext diplomaProjectDbContext)
        {
            this.employeeService = employeeService;
            this.diplomaProjectDbContext = diplomaProjectDbContext;
            _mapper = mapper;
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
                var employee = await this.employeeService.Get(id); // jezeli tu nie podam id, to zwróci wszystkich employee
                // 2 breakpointy na: linia wyżej oraz return
                return Ok(employee);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Create an employee
        /// </summary>
        /// <param name="employeeDto"></param>
        /// <returns></returns>
        // POST api/<EmployeeController>
        [HttpPost]
        // metoda POST zwracająca typ EmployeeDto
        public async Task<ActionResult> Post([FromBody] EmployeeCreateDto employeeDto)
        {
            try
            {
               var employee = await this.employeeService.Create(employeeDto);
            // teraz zwracamy w przeglądarce stworzony obiekt employee:
            // deklarujemy typ zwracany: EmployeeDto
            // mapujemy employee na DataTransferObject, czyli -> EmployeeDto
                return Ok(employee); //zwracamy nowego employee na EmployeeDto (to co widzi Klient)
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
                return Ok(employee); //wyświetlamy tego pracownika po zmianach zmapowane na EmployeeDto
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
                //await this.employeeService.Delete(id);
                var employee = await this.employeeService.Delete(id);   //nie działa 
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

            //var employee = diplomaProjectDbContext.Employees.FirstOrDefault(e => e.EmployeeId == id);
            //diplomaProjectDbContext.Remove(employee);
            //diplomaProjectDbContext.SaveChanges();
            //return Ok();
        }
    }
}