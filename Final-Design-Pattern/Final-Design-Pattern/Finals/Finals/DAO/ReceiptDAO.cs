using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.DTO;
using System.Windows.Forms;

namespace Finals.DAO
{

    
    internal class ReceiptDAO
    {
        private static ReceiptDAO instance;

        public static ReceiptDAO Instance
        {
            get { if (instance == null) instance = new ReceiptDAO(); return ReceiptDAO.instance; }
            private set { ReceiptDAO.instance = value; }
        }
        public ReceiptDAO()
        {

        }
        public List<ReceiptDTO> GetAllReceipt()
        {
            string sql = "SELECt * from tb_Receipt";
            DataTable dt = DataProvider.Instance.ExcuteQuery(sql);
            List<ReceiptDTO> listTable = new List<ReceiptDTO>();
            foreach (DataRow item in dt.Rows)
            {
                ReceiptDTO tableG = new ReceiptDTO(item);
                listTable.Add(tableG);
            }
            return listTable;
        }

        public void insertReceipt(string receipt, int totalprice)
        {
            string sql = "insert into tb_Receipt values ('"+receipt+"','"+totalprice+"')";
            DataProvider.Instance.ExcuteQuery(sql);
        }
        public DataTable getReceiptbyId(string receipt)
        {
            string sql = "select tb_Goods.GoodId,tb_Goods.Name,tb_Goods.Unit,tb_Goods.Price,tb_Goods.Describe,tb_Goods.image,tb_ReceiptDt.Amount from tb_Goods, tb_ReceiptDt ,tb_Receipt where tb_Goods.GoodId = tb_ReceiptDt.GoodId and tb_Receipt.ReceiptId = tb_ReceiptDt.ReceiptId and tb_Receipt.ReceiptId = '" + receipt + "'";
             return DataProvider.Instance.ExcuteQuery(sql);
        }
        public int getSum(String Id)
        {
            int sum = 0;
            DataTable tb = new DataTable();
            string sql = "select SUM(tb_Goods.Price * tb_ReceiptDt.Amount) from tb_Goods, tb_ReceiptDt ,tb_Receipt where tb_Goods.GoodId = tb_ReceiptDt.GoodId and tb_Receipt.ReceiptId = tb_ReceiptDt.ReceiptId and tb_Receipt.ReceiptId = '" + Id + "'";
            tb = DataProvider.Instance.ExcuteQuery(sql);
            sum = Convert.ToInt32(tb.Rows[0][0].ToString());
            return sum;
        }
        public void addReceiptDt(string Rid, string Gid, int amount, string date)
        {
            string sql = "insert into tb_ReceiptDt values ('" + Rid + "','" + Gid + "','" + amount + "','" + date + "')";
            DataProvider.Instance.ExcuteQuery(sql);
        }
        public void updateTp(int totalprice, string Id)
        {
            string sql = "update tb_Receipt set TotalPrice = '"+totalprice+"' where ReceiptId = '"+Id+"'";
            DataProvider.Instance.ExcuteQuery(sql);
        }
        public int getAmount(string RId, string GId)
        {
            int a = 0;
            DataTable tb = new DataTable();
            string sql = "select tb_ReceiptDt.Amount from tb_ReceiptDt where GoodId = '"+GId+"' and ReceiptId ='"+RId+"'";
            tb = DataProvider.Instance.ExcuteQuery(sql);
            a = Convert.ToInt32(tb.Rows[0][0].ToString());
            return a;
        }
        public void deleteReceiptDt(string Rid, string Gid)
        {
            string sql = "delete from tb_ReceiptDt where ReceiptId = '"+Rid+"' and GoodId ='"+Gid+"' ";
            DataProvider.Instance.ExcuteQuery(sql);
        }
        public int getSum1(string Rid, string Gid)
        {
            int sum = 0;
            DataTable tb = new DataTable();
            string sql = "select SUM(tb_Goods.Price * tb_ReceiptDt.Amount) from tb_Goods, tb_ReceiptDt ,tb_Receipt where tb_Goods.GoodId = tb_ReceiptDt.GoodId and tb_Receipt.ReceiptId = tb_ReceiptDt.ReceiptId and tb_Receipt.ReceiptId = '" + Rid + "'and tb_Goods.GoodId='"+Gid+"'";
            tb = DataProvider.Instance.ExcuteQuery(sql);
            sum = Convert.ToInt32(tb.Rows[0][0].ToString());
            return sum;
        }
        public int getSum2(string Rid)
        {
            int sum = 0;
            DataTable tb = new DataTable();
            string sql = "select TotalPrice from tb_Receipt where ReceiptId = '" + Rid + "'";
            tb = DataProvider.Instance.ExcuteQuery(sql);
            sum = Convert.ToInt32(tb.Rows[0][0].ToString());
            return sum;
        }
        public void updateAm(int amount, string RId, string GId)
        {
            string sql = "update tb_ReceiptDt set Amount = '" + amount + "' where ReceiptId = '" + RId + "' and GoodId = '"+GId+"'";
            DataProvider.Instance.ExcuteQuery(sql);
        }
    }
}
