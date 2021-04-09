using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.DataTransferObjects
{
    public class TimeEntryDto
    {
        public long TimeEntryId { get; set; }
        public DateTime Date { get; set; }
        public decimal AmountOfHours { get; set; }
        public string Comment { get; set; }
       
    }
    public class TimeEntryCreateDto
    {
        public DateTime Date { get; set; }
        public decimal AmountOfHours { get; set; }
        public string Comment { get; set; }
        public long EmployeeId { get; set; }
        public long ProjectId { get; set; }
    }
    public class TimeEntryUpdateDto
    {
        public DateTime Date { get; set; }
        public decimal AmountOfHours { get; set; }
        public string Comment { get; set; }
    }
}