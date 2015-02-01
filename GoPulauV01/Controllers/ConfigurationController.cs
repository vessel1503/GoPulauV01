using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoPulauV01.Controllers
{
    public class ConfigurationController : Controller
    {
        //
        // GET: /Configuration/

        public ActionResult Index()
        {
            return View();
        }

        //public void StateConfiguration()
        //{
        //    List<SelectListItem> items = new List<SelectListItem>();
        //    items.Add(new SelectListItem
        //    {
        //        Text = "Wilayah Kuala Lumpur",
        //        Value = "KUL"
        //    });
        //    items.Add(new SelectListItem
        //    {
        //        Text = "Selangor",
        //        Value = "SEL"
        //    });
        //    items.Add(new SelectListItem
        //    {
        //        Text = "Pahang",
        //        Value = "PHG"
        //    });

        //    ViewData["States"] = items;
        //}
    }
}
