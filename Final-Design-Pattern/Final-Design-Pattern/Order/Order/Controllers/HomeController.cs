using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Order.Context;

namespace Order.Controllers
{
    public class HomeController : Controller
    {
        STOREEntities1 SE = new STOREEntities1();
        public ActionResult Index()
        {
            var lsProduct = SE.tb_Goods.ToList();
            return View(lsProduct);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}