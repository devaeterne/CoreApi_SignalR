using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRWebUI.Dtos.SocialMediaDto
{
    public class UpdateSocialMediaDto
    {
        public int SocialMediaID { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
        public string Icon { get; set; }
    }
}