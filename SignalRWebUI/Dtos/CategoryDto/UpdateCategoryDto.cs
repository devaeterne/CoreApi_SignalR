using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRWebUI.Dtos.CategoryDto
{
    public class UpdateCategoryDto
    {
        public int CatergoryID { get; set; }
        public string CatergoryName { get; set; }
        public bool CatergoryStatus { get; set; }
    }
}