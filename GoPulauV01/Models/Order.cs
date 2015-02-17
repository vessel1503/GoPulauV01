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
	public class OrderContext : DbContext
	{
		public OrderContext()
			: base("GoPulauDB")
		{
		}

		public DbSet<Order> Order { get; set; }
	}
	public class Order: IUpdateCreate
	{
		[Key]
		[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
		public int OrderNo { get; set; }

		//TODO - Move out
		[Required]
		public int ProductId { get; set; }

		[Required]
		[Display(Name="Order Date")]
		public DateTime OrderDateTime { get; set; }

		[Required]
		[Display(Name = "Price")]
		public double PriceOnThatDay { get; set; }

		[Required]
		[Display(Name = "Quantity")]
		public int Quantity { get; set; }

		[Required]
		[Display(Name = "Total Amount")]
		public double TotalAmount { get; set; }

		[Required]
		[Display(Name = "Order Status")]
		//Status: New, Confirm, Confirmed with Availability, Pending For Payment, Paid, Completed or Expired.
		public string Status { get; set; }

		public int CreatedUserId { get; set; }

		public DateTime CreatedDateTime { get; set; }

		public int ModifiedUserId { get; set; }

		public DateTime ModifiedDateTime { get; set; }


		[ForeignKey("Member")]
		public int MemberId { get; set; }
		public virtual Member Member { get; set; }
	}
}