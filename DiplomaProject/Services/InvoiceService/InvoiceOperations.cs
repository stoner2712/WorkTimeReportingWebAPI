using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiplomaProject.Models;

namespace DiplomaProject.Services.InvoiceServiceNS
{
    public static class InvoiceOperations
    {
        public static void CloseInvoicePeriod(Invoice invoice)
        {
            if (invoice == null)
            {
                throw new ArgumentException("Id not existing");
            }
            if (invoice.IsInvoicePeriodClosed == true)
            {
                throw new ArgumentException("Invoice period already closed");
            }

            invoice.IsInvoicePeriodClosed = true;
        }

        public static decimal CalculateInvoiceCost(List<TimeEntry> timeEntries, Invoice invoice)
        {
            decimal totalAmountOfHours = 0;
            foreach (var timeEntry in timeEntries)
            {
                totalAmountOfHours = totalAmountOfHours + timeEntry.AmountOfHours;
            }

            var pricePerHour = invoice.Project.PricePerHour;
            var recalculateInvoice = totalAmountOfHours * pricePerHour;
            return recalculateInvoice;
        }
    }
}
