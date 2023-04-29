using System;
using Finals.Pattern;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.DTO;

namespace Finals.DAO
{
    internal class GoodDAO
    {
        private static GoodDAO instance;

        public static GoodDAO Instance
        {
            get { if (instance == null) instance = new GoodDAO(); return GoodDAO.instance; }
            private set { GoodDAO.instance = value; }
        }
        public GoodDAO()
        {

        }
        public List<GoodDTO> GetGoodDTO()
        {
            string sql = "SELECt * from tb_Goods";
            DataTable dt = DataProvider.Instance.ExcuteQuery(sql);
            var listTable = new WordsCollection();
            foreach (DataRow item in dt.Rows)
            {
                GoodDTO tableG = new GoodDTO(item);
                listTable.AddItem(tableG);
            }

            return listTable.getItems();
        }
        public void InsertGood(string goodid, string name, string unit, double price, string describe, string image, int amount, string supplier)
        {
            string sql = "INSERT INTO tb_Goods VALUES(N'" + goodid + "', N'" + name + "',  '" + unit + "',  N'" + price + "',  '" + describe + "',  '" + image + "',  '" + amount + "',  '" + supplier + "')";
            DataProvider.Instance.ExcuteQuery(sql);
        }
        
        public void UpdateGood(string goodid, string name, string unit, double price, string describe, string image, int amount, string supplier)
        {
            string sql = "Update tb_Goods SET Name = N'" + name + "', Unit = '" + unit + "',  Price = N'" + price + "', Describe = '" + describe + "', Image = '"+image+"', Amount = '"+amount+"', Supplier ='"+supplier+"' where Goodid = '" + goodid + "'";
            DataProvider.Instance.ExcuteNONQuery(sql);
        }
        public void DeleteGood(string Id)
        {
            string sql = "Delete tb_Goods where GoodId = '"+ Id+"'";
            DataProvider.Instance.ExcuteNONQuery(sql);
        }
        public void updateAmountUp(string id, int amount)
        {
            string sql = "update tb_Goods set Amount = Amount + '" + amount + "' where GoodId = '" + id + "'";
            DataProvider.Instance.ExcuteQuery(sql);
        }
        public void updateAmountDown(string id, int amount)
        {
            string sql = "update tb_Goods set Amount = Amount - '" + amount + "' where GoodId = '" + id + "'";
            DataProvider.Instance.ExcuteQuery(sql);
        }
        public int getAmount(string GId)
        {
            int a = 0;
            DataTable tb = new DataTable();
            string sql = "select tb_Goods.Amount from tb_Goods where GoodId = '" + GId + "' ";
            tb = DataProvider.Instance.ExcuteQuery(sql);
            a = Convert.ToInt32(tb.Rows[0][0].ToString());
            return a;
        }
        public void updateAmount(string id, int amount)
        {
            string sql = "update tb_Goods set Amount = '" + amount + "' where GoodId = '" + id + "'";
            DataProvider.Instance.ExcuteQuery(sql);
        }
    }
}
