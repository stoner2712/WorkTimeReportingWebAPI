using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.DataTransferObjects
{
    public class ProjectDto : ProjectUpdateDto
    {
        public long ProjectId { get; set; }
        public string ProjectName { get; set; }
        
    }
    public class ProjectCreateDto : ProjectUpdateDto
    {
        public string ProjectName { get; set; }
        public long ClientId { get; set; }
    }
    public class ProjectUpdateDto
    {
        public decimal PricePerHour { get; set; }
    }
}
