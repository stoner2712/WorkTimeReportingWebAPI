using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.DataTransferObjects
{
    public class EmployeeDto
    {
        public long EmployeeId { get; set; }
        public string UserName { get; set; }

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
    }
    public class EmployeeCreateDto
    {
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
    }
    public class EmployeeUpdateDto
    {
        [Required(ErrorMessage = "First name is required")]
        [StringLength(60, ErrorMessage = "First name can't be longer than 60 characters")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string JobTitle { get; set; }
    }
}
