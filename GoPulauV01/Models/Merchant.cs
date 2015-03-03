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
	public class MerchantContext : DbContext
	{	
		public MerchantContext()
			: base("GoPulauDB")
		{
		}

		public DbSet<Merchant> Merchant { get; set; }
	}
	public class Merchant : IUpdateCreate
	{
		[Key]
		[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
		public int MerchantID { get; set; }

		[Required]
		[Display(Name = "Merchant Name")]
		public string MerchantName { get; set; }

		[Display(Name = "Address")]
		public string Address { get; set; }

		[Display(Name = "Postal Code")]
		public int PostalCode { get; set; }

		[Display(Name = "State")]
		public string State { get; set; }

		[Display(Name = "Country")]
		public string Country { get; set; }

		[Required]
		[Display(Name = "Phone Number")]
		public string PhoneNo { get; set; }

		[Display(Name = "Merchant Email")]
		public string MerchantEmail { get; set; }

		[Display(Name = "Merchant Contact Number 1")]
		public string MerchantContactNo1 { get; set; }

		[Display(Name = "Merchant Contact Number 2")]
		public string MerchantContactNo2 { get; set; }

		[Display(Name = "Merchant License Number")]
		public string MerchantLicenseNo { get; set; }

		[Required]
		[Display(Name = "Registered Date")]
		public DateTime RegisteredDate { get; set; }

		[Required]
		public int IsActive { get; set; }

		public int CreatedUserId { get; set; }

		public DateTime CreatedDateTime { get; set; }

		public int ModifiedUserId { get; set; }

		public DateTime ModifiedDateTime { get; set; }
	}
}