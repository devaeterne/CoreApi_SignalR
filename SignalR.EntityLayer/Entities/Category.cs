using System;
using System.ComponentModel.DataAnnotations;
namespace SignalR.EntityLayer.Entities
{
	public class Category
	{
		[Key]
		public int CatergoryID { get; set; }
		public string CatergoryName { get; set; }
		public bool CatergoryStatus { get; set; }

	}
}

