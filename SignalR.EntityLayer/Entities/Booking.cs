using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.EntityLayer.Entities
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public int PersonCount { get; set; }
        public DateTime Date { get; set; }
    }
}