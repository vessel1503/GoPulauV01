using GoPulauV01.Models;
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

		public ActionResult ProcessOrder(int id)
		{
			if (User.Identity.IsAuthenticated){
				var objProduct = new Product();
				objProduct.ProductId = id;
				return View(objProduct);
			}
			else
			{
				return RedirectToAction("Login", "Account", new { returnUrl = Url.Action("ProcessOrder") });
			}
		}
	}
}
