using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.Models
{
    [Table("Project")]
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ProjectId { get; set; }
        public string ProjectName { get; set; }
        public decimal PricePerHour { get; set; }

        public long ClientId { get; set; } // FK
        public Client Client { get; set; }

        public List<EmployeeProject> EmployeesProject { get; set; } 
        public List<TimeEntry> TimeEntries { get; set; }
        public List<Invoice> Invoices { get; set; }
    }
}
