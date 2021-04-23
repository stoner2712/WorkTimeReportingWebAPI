using DinkToPdf;
using DinkToPdf.Contracts;
using DiplomaProject.DataTransferObjects;
using DiplomaProject.Models;
using DiplomaProject.Services.InvoiceServiceNS;
using DiplomaProject.Services.PdfService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DiplomaProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {

        private IInvoiceService invoiceService;

        private readonly IReportService _reportService;

        public InvoiceController(IInvoiceService invoiceService, IReportService reportService)
        {
            this.invoiceService = invoiceService;
            _reportService = reportService;

        }

        /// <summary>
        /// Find all the invoices
        /// </summary>
        /// <returns></returns>
        // GET: api/<InvoicesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable>> Get()
        {
            try
            {
                var allInvoices = await this.invoiceService.Get();
                return Ok(allInvoices);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        /// <summary>
        /// Find an invoice - search by {id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<InvoiceController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                var invoice = await this.invoiceService.Get(id);
                return Ok(invoice);
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
        /// Create a new invoice
        /// </summary>
        /// <param name="invoiceCreateDto"></param>
        /// <returns></returns>
        // POST api/<InvoiceController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] InvoiceCreateDto invoiceCreateDto)
        {
            try
            {
                var invoice = await this.invoiceService.Create(invoiceCreateDto);
                return Ok(invoice);
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
        /// Update an invoice - search by {id}
        /// </summary>
        /// <param name="id"></param>
        /// <param name="invoiceUpdateDto"></param>
        /// <returns></returns>
        // PUT api/<InvoiceController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] InvoiceUpdateDto invoiceUpdateDto)
        {
            try
            {
                var invoice = await this.invoiceService.Update(id, invoiceUpdateDto);
                return Ok(invoice);
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
        /// Delete an invoice - search by {id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // DELETE api/<InvoiceController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var invoice = await this.invoiceService.Delete(id);
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
        /// Find all the invoices for a project - search by project {id}
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        [HttpGet("Project/{projectId}")]
        public async Task<ActionResult> GetAllInvoicesForProject(int projectId)
        {
            try
            {
                var allIvoicesForProject = await this.invoiceService.GetAllInvoicesForGivenProject(projectId);
                return Ok(allIvoicesForProject);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Find all invoices and all projects for a client - search by client {id}
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        [HttpGet("WithProjectsPerClient/{clientId}")]
        public async Task<ActionResult> GetAllInvoicesForProjectsForGivenClient(int clientId)
        {
            try
            {
                var allIvoicesAndAllProjectsForGivenClient = await this.invoiceService.GetInvoicesForProjectsPerClient(clientId);
                return Ok(allIvoicesAndAllProjectsForGivenClient);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Find all time entries for an invoice for a given project - search by project {id}
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        [HttpGet("WithTimeEntriesPerProject/{projectId}")]
        public async Task<ActionResult> GetInvoiceWithAllTimeEntriesForGivenProject(int projectId)
        {
            try
            {
                var invoiceWithAllTimeEntriesForGivenProject = await this.invoiceService.GetInvoiceWithTimeEntriesPerProject(projectId);
                return Ok(invoiceWithAllTimeEntriesForGivenProject);
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
        /// Generate pdf for a given invoice - search by invoice {id}
        /// </summary>
        // /// <param name="id"></param>
        // /// <returns></returns>
        [HttpGet("GeneratePdfDEMO/{id}")]

        public IActionResult GetInvoiceToPdfDEMO(int invoiceId)
        {
            try
            {
                var pdfFile = _reportService.GeneratePdfReportExample(invoiceId);
                return File(pdfFile,
                "application/octet-stream", "Invoice_Id_" + invoiceId + ".pdf");
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
        /// Generate pdf for a given invoice - search by invoice {id}
        /// </summary>
        // /// <param name="id"></param>
        // /// <returns></returns>
        [HttpGet("GeneratePdf/{invoiceId}")]

        public IActionResult GetInvoiceToPdf(int invoiceId)
        {
            try
            {
                var pdfFile = invoiceService.GenerateInvoicePdf(invoiceId);
                return File(pdfFile,
                "application/octet-stream", "Invoice_Id_" + invoiceId + ".pdf");
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
        /// Close invoice period - seatch by invoice {id}
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <returns></returns>
        [HttpGet("ClosePeriod/{invoiceId}")]

        public async Task<ActionResult> ClosePeriod(int invoiceId)
        {
            try
            {
                var invoicePeriod = await this.invoiceService.CloseInvoicePeriod(invoiceId);
                return Ok(invoicePeriod);
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

