using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long EmployeeId { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(60, ErrorMessage = "First name can't be longer than 60 characters")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BuildingNumber { get; set; }
        public string StreetName { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string JobTitle { get; set; }

        //public long ProjectId { get; set; } // FK nie może go tu być, bo jest określony w EployeeProject

        //public List<Project> Projects { get; set; } // określa relację wiele Projects do danego Employee
        public List<EmployeeProject> EmployeeProjects { get; set; } 
        public List<TimeEntry> TimeEntries { get; set; } // określa relację wiele TimeEntry do danego Employee
    }
}