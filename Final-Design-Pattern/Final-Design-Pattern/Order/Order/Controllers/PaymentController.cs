using Order.Context;
using Order.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Order.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        STOREEntities1 SE = new STOREEntities1();
        public ActionResult Index()
        {
            Random random = new Random(); 
            int b = random.Next(0, 100);
            var lstCart = (List< CartModel >)Session["Cart"];
            tb_Cart obj = new tb_Cart();
            obj.CartId = "H" +b.ToString();
            obj.Name = b.ToString() + "th "+ "Cart";
            obj.Agency = "";
            obj.Status = "";
            obj.Payment_Method = "";
            int sum = 1;
            foreach (var item in lstCart)
            {
                sum = (int)(+ item.Product.Price * item.Quantity);
            }
            obj.TotalPrice = sum;
            SE.tb_Cart.Add(obj);
            SE.SaveChanges();

            string sobj = obj.CartId.ToString();
            List<tb_CartDt> listCartDt = new List<tb_CartDt>();
            foreach (var item in lstCart)
            {
                tb_CartDt dt = new tb_CartDt();
                dt.Amount = item.Quantity;
                dt.CartId = sobj;
                dt.GoodId = item.Product.GoodId;
                dt.Created_Date = DateTime.Now;
                listCartDt.Add(dt);
            }
            
            SE.tb_CartDt.AddRange(listCartDt);
            SE.SaveChanges();
            return View();
        }
    }
}