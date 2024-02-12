using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.CategoryDto
{
    public class GetCategoryDto
    {
        public int CatergoryID { get; set; }
        public string CatergoryName { get; set; }
        public bool CatergoryStatus { get; set; }
    }
}