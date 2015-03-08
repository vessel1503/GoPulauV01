using GoPulauV01.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GoPulauV01.Models
{
	public class OrderDetailContext : DbContext
	{
		public OrderDetailContext()
			: base("GoPulauDB")
		{
		}

		public DbSet<OrderDetail> OrderDetail { get; set; }
	}
	public class OrderDetail : IUpdateCreate 
	{
		[Key]
		[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
		public int OrderDetailNo { get; set; }

		[Required]
		[Display(Name = "Price")]
		public double PriceOnThatDay { get; set; }

		[Required]
		[Display(Name = "Quantity")]
		public int Quantity { get; set; }

		[Display(Name = "From Date")]
		public DateTime FromDateTime { get; set; }

		[Display(Name = "To Date")]
		public DateTime ToDateTime { get; set; }

		[Display(Name = "Number of Day")]
		public int NumberOfDayStay { get; set; }

		public double Amount { get; set; }

		[Required]
		[Display(Name = "Status")]
		public string Status { get; set; }

		public int CreatedUserId { get; set; }

		public DateTime CreatedDateTime { get; set; }

		public int ModifiedUserId { get; set; }

		public DateTime ModifiedDateTime { get; set; }

		[ForeignKey("Order")]
		public int OrderNo { get; set; }	
		public virtual Order order { get; set; }

		//TODO - Move out
		[ForeignKey("Product")]
		public int ProductId { get; set; }
		public virtual Product Product { get; set; }
	}
}