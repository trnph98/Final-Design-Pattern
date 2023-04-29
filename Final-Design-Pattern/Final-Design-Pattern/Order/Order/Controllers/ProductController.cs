using Order.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Order.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        STOREEntities1 SE = new STOREEntities1();
        public ActionResult Detail(String GoodId)
        {
            var objProduct = SE.tb_Goods.Where(n => n.GoodId == GoodId).FirstOrDefault();
            return View(objProduct);
        }
    }
}