using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRWebUI.Dtos.BookingDto
{
    public class UpdateBookingDto
    {
        public int BookingID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public int PersonCount { get; set; }
        public DateTime Date { get; set; }
    }
}