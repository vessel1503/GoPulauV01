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
	public class MemberContext : DbContext
	{
		public MemberContext()
			: base("GoPulauDB")
		{
		}

		public DbSet<Member> Member { get; set; }        
	}
    
	public class Member: IUpdateCreate
	{
		[Key]
		[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
		public int MemberId { get; set; }

		[Required]
		[Display(Name = "Name")]
		public string Name { get; set; }

		[Required]
		[Display(Name = "IC/Passport")]
		public string Ic_Passport { get; set; }

		[Required]
		[Display(Name = "Gender")]
		public string Gender { get; set; }

		[Required]
		[Display(Name = "Date of Birth")]
		public string Dob { get; set; }

		[Display(Name = "Race")]
		public string Race { get; set; }

		[Display(Name = "Religion")]
		public string Religion { get; set; }

		[Display(Name = "Occupation")]
		public string Occupation { get; set; }

		[Required]
		[Display(Name = "Address")]
		public string Address { get; set; }

		[Required]
		[Display(Name = "Postal Code")]
		public string PostalCode { get; set; }

		[Required]
		[Display(Name = "State")]
		public string State { get; set; }

		[Required]
		[Display(Name = "Country")]
		public string Country { get; set; }

		[Required]
		[Display(Name = "Contact Number")]
		public string PhoneNo { get; set; }

		//[Display(Name = "Email")]
		//public string Email { get; set; }

		public int IsActive { get; set; }

		public int CreatedUserId { get; set; }

		public DateTime CreatedDateTime { get; set; }

		public int ModifiedUserId { get; set; }

		public DateTime ModifiedDateTime { get; set; }

		[ForeignKey("User")]
		public int UserId { get; set; }

		//[Required]
		public virtual UserProfile User { get; set; }
	}
}