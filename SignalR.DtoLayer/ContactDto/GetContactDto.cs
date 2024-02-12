using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.ContactDto
{
    public class GetContactDto
    {
        public int ContactID { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
        public string FooterDescription { get; set; }
    }
}