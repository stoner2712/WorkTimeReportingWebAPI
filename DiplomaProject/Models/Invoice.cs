using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.Models
{
    [Table("Invoice")]
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long InvoiceId { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public  int Month { get; set; }
        public decimal AmountOfHours { get; set; } // before Amount
        //public decimal HourlyRate { get; set; } // to dodać - nie trzeba jest w Project.cs
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal TotalToPay { get; set; }
        public bool IsInvoicePaid { get; set; } // before Status

        public long ProjectId { get; set; } // FK
        public Project Project{ get; set; } // Navigation Property to one Project

        public List<TimeEntry> TimeEntries { get; set; } // określa relację wiele TimeEntry do danej Invoice
    }
}
