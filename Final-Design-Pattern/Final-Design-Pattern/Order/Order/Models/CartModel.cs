using Order.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Order.Models
{
    public class CartModel
    {
        public tb_Goods Product { get; set; }
        public int Quantity { get; set; }
    }
}