using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GoPulauV01.Models
{
	public class ProductContext : DbContext
	{
		public ProductContext()
			: base("GoPulauDB")
		{
		}

		public DbSet<Product> Product { get; set; }
	}

	public class Product
	{
		[Key]
		[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
		public int ProductId { get; set; }

		[Required]
		[Display(Name = "Product Name")]
		public string ProductName { get; set; }

		[Required]
		[Display(Name = "Product Description")]
		public string ProductDescription { get; set; }

		[Display(Name = "Normal Price")]
		public double PriceNormal { get; set; }

		[Display(Name = "Price for Peak Season")]
		public double PricePeakSeason { get; set; }

		[Display(Name = "Commission Percentage")]
		public double CommissionPercentage { get; set; }

		[Display(Name = "Commission Fixed Rate")]
		public double CommissionFixedRate { get; set; }

		[Display(Name = "Product Available Date")]
		public DateTime ProductAvailableDateTime { get; set; }

		[Display(Name = "Day Availble")]
		public int AvailableDays { get; set; }

		[Display(Name = "Quantity Available")]
		public int AvailableQuantity { get; set; }

		[Required]
		public int IsActive { get; set; }

		[ForeignKey("Merchant")]
		public int MerchantId { get; set; }

		public virtual Merchant Merchant { get; set; }

	}
}