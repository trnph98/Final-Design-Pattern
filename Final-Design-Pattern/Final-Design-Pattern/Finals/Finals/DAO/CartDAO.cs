using DevExpress.DataProcessing.InMemoryDataProcessor.Executors;
using Finals.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.DAO
{
    internal class CartDAO
    {
        private static CartDAO instance;

        public static CartDAO Instance
        {
            get { if (instance == null) instance = new CartDAO(); return CartDAO.instance; }
            private set { CartDAO.instance = value; }
        }
        public List<CartDTO> GetAllCart()
        {
            string sql = "SELECt * from tb_Cart";
            DataTable dt = DataProvider.Instance.ExcuteQuery(sql);
            List<CartDTO> listTable = new List<CartDTO>();
            foreach (DataRow item in dt.Rows)
            {
                CartDTO tableG = new CartDTO(item);
                listTable.Add(tableG);
            }
            return listTable;
        }
        public void insertCart(string Cart,string name, string agency, string status, string payment ,int totalprice)
        {
            string sql = "insert into tb_Cart values ('" + Cart + "','" + name + "','" + agency + "','" + status + "','" + payment + "','" + totalprice + "')";
            DataProvider.Instance.ExcuteQuery(sql);
        }
        public DataTable getCartbyId(string Cart)
        {
            string sql = "select tb_Goods.GoodId,tb_Goods.Name,tb_Goods.Unit,tb_Goods.Price,tb_Goods.Describe,tb_Goods.image,tb_CartDt.Amount from tb_Goods, tb_CartDt ,tb_Cart where tb_Goods.GoodId = tb_CartDt.GoodId and tb_Cart.CartId = tb_CartDt.CartId and tb_Cart.CartId = '" + Cart + "'";
            return DataProvider.Instance.ExcuteQuery(sql);
        }
        public int getSum(String Id)
        {
            int sum = 0;
            DataTable tb = new DataTable();
            string sql = "select SUM(tb_Goods.Price * tb_CartDt.Amount) from tb_Goods, tb_CartDt ,tb_Cart where tb_Goods.GoodId = tb_CartDt.GoodId and tb_Cart.CartId = tb_CartDt.CartId and tb_Cart.CartId = '" + Id + "'";
            tb = DataProvider.Instance.ExcuteQuery(sql);
            sum = Convert.ToInt32(tb.Rows[0][0].ToString());
            return sum;
        }
        public void addCartDt(string Rid, string Gid, int amount, string date)
        {
            string sql = "insert into tb_CartDt values ('" + Rid + "','" + Gid + "','" + amount + "','" + date + "')";
            DataProvider.Instance.ExcuteQuery(sql);
        }
        public void updateTp(int totalprice, string Id)
        {
            string sql = "update tb_Cart set TotalPrice = '" + totalprice + "' where CartId = '" + Id + "'";
            DataProvider.Instance.ExcuteQuery(sql);
        }
        public int getAmount(string RId, string GId)
        {
            int a = 0;
            DataTable tb = new DataTable();
            string sql = "select tb_CartDt.Amount from tb_CartDt where GoodId = '" + GId + "' and CartId ='" + RId + "'";
            tb = DataProvider.Instance.ExcuteQuery(sql);
            a = Convert.ToInt32(tb.Rows[0][0].ToString());
            return a;
        }
        public void deleteCartDt(string Rid, string Gid)
        {
            string sql = "delete from tb_CartDt where CartId = '" + Rid + "' and GoodId ='" + Gid + "' ";
            DataProvider.Instance.ExcuteQuery(sql);
        }
        public int getSum1(string Rid, string Gid)
        {
            int sum = 0;
            DataTable tb = new DataTable();
            string sql = "select SUM(tb_Goods.Price * tb_CartDt.Amount) from tb_Goods, tb_CartDt ,tb_Cart where tb_Goods.GoodId = tb_CartDt.GoodId and tb_Cart.CartId = tb_CartDt.CartId and tb_Cart.CartId = '" + Rid + "'and tb_Goods.GoodId='" + Gid + "'";
            tb = DataProvider.Instance.ExcuteQuery(sql);
            sum = Convert.ToInt32(tb.Rows[0][0].ToString());
            return sum;
        }
        public int getSum2(string Rid)
        {
            int sum = 0;
            DataTable tb = new DataTable();
            string sql = "select TotalPrice from tb_Cart where CartId = '" + Rid + "'";
            tb = DataProvider.Instance.ExcuteQuery(sql);
            sum = Convert.ToInt32(tb.Rows[0][0].ToString());
            return sum;
        }
        public void updateAm(int amount, string RId, string GId)
        {
            string sql = "update tb_CartDt set Amount = '" + amount + "' where CartId = '" + RId + "' and GoodId = '" + GId + "'";
            DataProvider.Instance.ExcuteQuery(sql);
        }
        public int proceeds(String GId)
        {
            int sum = 0;
            DataTable tb = new DataTable();
            string sql = "select SUM(tb_CartDt.Amount) from tb_CartDt where tb_CartDt.GoodId = '"+GId+"'";
            tb = DataProvider.Instance.ExcuteQuery(sql);
            sum = Convert.ToInt32(tb.Rows[0][0].ToString());
            return sum;
        }
    }
}
