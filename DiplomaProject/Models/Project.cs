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

       //public long EmployeeId { get; set; } // FK
        public long ClientId { get; set; } // FK

        // First Part of expression define navigation property
        public Client Client { get; set; } // projekt może mieć powiazanie tylko z 1 klientem

        //public List<Employee> Employees { get; set; } // określa relację wiele Employee do danego Projectu
        public List<EmployeeProject> EmployeesProject { get; set; } 
        public List<TimeEntry> TimeEntries { get; set; } // określa relację wiele TimeEntry do danego Projectu
        public List<Invoice> Invoices { get; set; } // określa relację wiele faktur do danego Projectu
    }
}
