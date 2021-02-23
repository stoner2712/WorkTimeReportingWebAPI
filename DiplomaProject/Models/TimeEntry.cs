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

        public string Comment { get; set; } //czy mogę tak zrobić? // ozn że moze byc nullable

        public long EmployeeId { get; set; } //FK
        public long ProjectId { get; set; } //FK

        public Employee Employee { get; set; } // Navigation Property to one Employee
        public Project Project { get; set; } // Navigation Property to one Project
    }
}
