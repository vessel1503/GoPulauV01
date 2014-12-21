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
            : base("GoPulauDBTesting")
        {
        }

        public DbSet<Member> Members { get; set; }
        //public DbSet<UserProfile> User { get; set; }
    }
    
    public class Member: IUpdateCreate
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int MemberId { get; set; }

        //public int UserId { get; set; }

        public string Name { get; set; }

        public string Ic_Passport { get; set; }

        public string Gender { get; set; }

        public string Dob { get; set; }

        public string Race { get; set; }

        public string Religion { get; set; }

        public string Occupation { get; set; }

        public string Address { get; set; }

        public string PostalCode { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string PhoneNo { get; set; }

        public int IsActive { get; set; }

        public string CreatedUserName { get; set; }

        public string CreatedDateTime { get; set; }

        public string ModifiedUserName { get; set; }

        public string ModifiedDateTime { get; set; }

        public UserProfile user { get; set; }
    }
}