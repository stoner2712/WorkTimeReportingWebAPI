using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.Models
{
    [Table("TimeEntry")]
    public class TimeEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long TimeEntryId { get; set; }
        public DateTime Date { get; set; }
        public decimal AmountOfHours { get; set; }
        public string Comment { get; set; }
        public long EmployeeId { get; set; }
        public long ProjectId { get; set; }
        public long? InvoiceId { get; set; }

        public Employee Employee { get; set; }
        public Project Project { get; set; }
        public Invoice Invoice { get; set; }
    }
}
