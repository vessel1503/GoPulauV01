using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GoPulauV01.Models.ViewModels
{
	[NotMapped]
	public class ExtendedMember	: Member
	{
		public virtual bool IsSubscribeLatestNewsValue
		{
			get { return IsSubscribeLatestNews != 0; }
			set
			{
				if (value)
					IsSubscribeLatestNews = 1;
				else
					IsSubscribeLatestNews = 0;
			}
		}
	}
}