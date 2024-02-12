using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.SocialMediaDto
{
    public class CreateSocialMediaDto
    {
        public string Title { get; set; }
        public string URL { get; set; }
        public string Icon { get; set; }
    }
}