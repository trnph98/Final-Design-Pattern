using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.DAO;

namespace Finals
{
    public partial class Receipt : Form
    {
        
        public Receipt()
        {
            InitializeComponent();
            dataGridView1.DataSource = ReceiptDAO.Instance.GetAllReceipt();

        }
        
        private void add_Click(object sender, EventArgs e)
        {
            string rid = receiptid1.Text;
            int totalprice = 0;
            ReceiptDAO.Instance.insertReceipt(rid, totalprice);
            dataGridView1.DataSource = ReceiptDAO.Instance.GetAllReceipt();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            dataGridView2.DataSource = ReceiptDAO.Instance.getReceiptbyId(row.Cells[0].Value.ToString());
            receiptid2.Text = row.Cells[0].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                
                string id1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string id2 = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                int totalpr1 = ReceiptDAO.Instance.getSum2(id1);
                int a = totalpr1 - ReceiptDAO.Instance.getSum1(id1, id2);
                ReceiptDAO.Instance.updateTp(a, receiptid2.Text);
                GoodDAO.Instance.updateAmountDown(id2, ReceiptDAO.Instance.getAmount(id1, id2));
                if (GoodDAO.Instance.getAmount(id2) < 0)
                {
                    GoodDAO.Instance.updateAmount(id2, 0);
                }
                ReceiptDAO.Instance.deleteReceiptDt(id1, id2);
                dataGridView1.DataSource = ReceiptDAO.Instance.GetAllReceipt();
                dataGridView2.DataSource = ReceiptDAO.Instance.getReceiptbyId(id1);
            }
            catch
            {
                MessageBox.Show("Can't delete good from this Receipt");
            }

        }

        private void add2_Click(object sender, EventArgs e)
        {
            try
            {
                int totalpr;
                int gamount;
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                ReceiptDAO.Instance.addReceiptDt(id, goodid.Text, Int32.Parse(amount.Text), created.Text);
                dataGridView2.DataSource = ReceiptDAO.Instance.getReceiptbyId(id);
                gamount = ReceiptDAO.Instance.getAmount(id, goodid.Text);
                totalpr = ReceiptDAO.Instance.getSum(id);
                ReceiptDAO.Instance.updateTp(totalpr, id);
                GoodDAO.Instance.updateAmountUp(goodid.Text, gamount);
                dataGridView1.DataSource = ReceiptDAO.Instance.GetAllReceipt();
            }
            catch
            {
                int totalpr;
                int gamount;
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                gamount = ReceiptDAO.Instance.getAmount(id, goodid.Text);
                int a = gamount + Int32.Parse(amount.Text);
                ReceiptDAO.Instance.updateAm(a,id,goodid.Text);
                int b = ReceiptDAO.Instance.getAmount(id, goodid.Text);
                GoodDAO.Instance.updateAmountUp(goodid.Text, Int32.Parse(amount.Text));
                totalpr = ReceiptDAO.Instance.getSum(id);
                ReceiptDAO.Instance.updateTp(totalpr, id);
                dataGridView1.DataSource = ReceiptDAO.Instance.GetAllReceipt();
                dataGridView2.DataSource = ReceiptDAO.Instance.getReceiptbyId(id);
            }
        }

        private void receiptid2_EditValueChanged(object sender, EventArgs e)
        {
           

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            receiptid1.Text = "";
            total.Text = "";
            receiptid2.Text = "";
            goodid.Text = "";
            amount.Text = "";
            created.Text = "";

        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }
    }
}
