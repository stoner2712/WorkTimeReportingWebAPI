using DiplomaProject.DataTransferObjects;
using DiplomaProject.Models;
using DiplomaProject.Services.PdfService;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.Services.InvoiceServiceNS
{
    public interface IInvoiceService
    {
        Task<IEnumerable<InvoiceDto>> Get();
        Task<InvoiceDto> Get(int id);
        Task<InvoiceDto> Create(InvoiceCreateDto invoiceCreateDto);
        Task<InvoiceDto> Update(int id, InvoiceUpdateDto invoiceUpdateDto);
        Task<InvoiceDto> Delete(int id);
        Task<IEnumerable<InvoiceDto>> GetAllInvoicesForGivenProject(int projectId);
        Task<IEnumerable<InvoiceForClientDto>> GetInvoicesForProjectsPerClient(int clientId);
        Task<IEnumerable<InvoiceForTimeEntryDto>> GetInvoiceWithTimeEntriesPerProject(int projectId);
        byte[] GenerateInvoicePdf(int invoiceId);
        Task<InvoicePeriodClosureDto> CloseInvoicePeriod(int invoiceId);
        //bool CheckIfInvoicePeriodIsClosed(TimeEntry timeEntry);
        bool CheckIfInvoicePeriodIsClosed(int month, long projectId);
    }
}