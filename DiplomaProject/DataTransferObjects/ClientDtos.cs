using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.DataTransferObjects
{
    public class ClientDto : ClientUpdateDto
    {
        public long ClientId { get; set; }
        public string ClientName { get; set; }
    }
    public class ClientCreateDto : ClientUpdateDto
    {
        public string ClientName { get; set; }
    }
    public class ClientUpdateDto
    {
        public string BuildingNumber { get; set; }
        public string StreetName { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
