using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoPulauV01.Controllers
{
	public class OrderController : Controller
	{
		//
		// GET: /Order/

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult ProcessOrder(string id)
		{
			if (User.Identity.IsAuthenticated){

				return View();
			}
			else
			{
				return RedirectToAction("Login", "Account", new { returnUrl = Url.Action("ProcessOrder") });
			}
		}
	}
}
