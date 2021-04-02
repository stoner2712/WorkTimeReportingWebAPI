using DiplomaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.DataTransferObjects
{
    public class InvoiceDto : InvoiceUpdateDto
    {
        public long InvoiceId { get; set; }
        public decimal Amount { get; set; }
    }
    public class InvoiceCreateDto : InvoiceUpdateDto
    {
        public long ProjectId { get; set; }
    }
    public class InvoiceUpdateDto
    {
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public int Month { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal TotalToPay { get; set; }
        public bool Status { get; set; }
    }
    public class InvoiceForClientDto : InvoiceForProjectDto
    {
        public long ClientId { get; set; }
        public string ClientName { get; set; }
    }
    public class InvoiceForProjectDto
    {
        public long ProjectId { get; set; }
        public string ProjectName { get; set; }
        public long InvoiceId { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public int Month { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal TotalToPay { get; set; }
        public bool Status { get; set; }

    }

    public class InvoiceForTimeEntryDto : InvoiceForProjectDto
    {

        //public long TimeEntryId { get; set; } // tego nie powinno być bo TimeEntries tutaj to kolekcja (List<TE>), a nie pojedyńczy TimeEntry
        //public DateTime Date { get; set; }  // tu by musiałoby być DateOfEntry, bo koflikt z Date z InvoiceForProjectDto, ale de facto Date jest w kolekcji, także bedzie
        //public decimal AmountOfHours { get; set; } // tego nie musi być, bo to jest w TimeEntry z kolekcji, podobnie Comment
        //public string Comment { get; set; }
        public List<TimeEntryDto> TimeEntries { get; set; } // pobiera liste Time Entries dla danej invoice, //bez tego wyswietla sie w Swagger UI
    }
}
