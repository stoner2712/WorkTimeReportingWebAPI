using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.Models
{
    [Table("EmployeeProject")]
    public class EmployeeProject
    {
        public long EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public long ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
