using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.AboutDto
{
    public class CreateAboutDto
    {

        public string ImageURL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}