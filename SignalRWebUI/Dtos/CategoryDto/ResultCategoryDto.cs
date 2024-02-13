using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRWebUI.Dtos.CategoryDto
{
    public class ResultCategoryDto
    {
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
    }
}