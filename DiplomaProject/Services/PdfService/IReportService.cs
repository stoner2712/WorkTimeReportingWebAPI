using DinkToPdf;
using DiplomaProject.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.Services.PdfService
{
    public interface IReportService
    {
        public byte[] GeneratePdfReportExample(int invoiceId);
        public byte[] GenerateInvoicePdf(TemplateForInvoicePdf invoioceData, int invoiceId);
    }
}
