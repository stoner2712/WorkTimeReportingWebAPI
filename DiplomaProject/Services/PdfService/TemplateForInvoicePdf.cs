using DiplomaProject.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.Services.PdfService
{
    public class TemplateForInvoicePdf
    {
        public string ClientName { get; set; }
        public string BuildingNumber { get; set; }
        public string StreetName { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ProjectName { get; set; }
        public int Month { get; set; }
        public decimal AmountOdHours { get; set; }
        public decimal PricePerHour { get; set; }
        public decimal TotalToPay { get; set; }
        public DateTime Date { get; set; }
        public List<TimeEntryDto> TimeEntries { get; set; }
    }
}