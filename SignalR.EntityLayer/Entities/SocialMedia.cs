using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.EntityLayer.Entities
{
    public class SocialMedia
    {
        public int SocialMediaID { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
        public string Icon { get; set; }
    }
}