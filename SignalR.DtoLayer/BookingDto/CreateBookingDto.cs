using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.BookingDto
{
    public class CreateBookingDto
    {

        public string Name { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public int PersonCount { get; set; }
        public DateTime Date { get; set; }
    }
}