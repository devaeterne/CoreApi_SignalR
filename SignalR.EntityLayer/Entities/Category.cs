using System;
using System.ComponentModel.DataAnnotations;
namespace SignalR.EntityLayer.Entities
{
	public class Category
	{
		[Key]
		public int CategoryID { get; set; }
		public string CategoryName { get; set; }
		public bool CategoryStatus { get; set; }
		public List<Product> Products { get; set; }

	}
}

