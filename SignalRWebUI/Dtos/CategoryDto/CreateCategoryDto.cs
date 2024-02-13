using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRWebUI.Dtos.CategoryDto
{
    public class CreateCategoryDto
    {
        public string? CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
    }
}