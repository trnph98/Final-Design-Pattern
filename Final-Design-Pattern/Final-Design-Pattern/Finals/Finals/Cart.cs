using Finals.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
            dataGridView1.DataSource = CartDAO.Instance.GetAllCart();
        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            dataGridView2.DataSource = CartDAO.Instance.getCartbyId(row.Cells[0].Value.ToString());
            cartid2.Text = row.Cells[0].Value.ToString();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string rid = cartid1.Text;
            string aname = name.Text;
            string aAgency = agency.Text;
            string  astatus= status.Text;
            string apayment = payment.Text;
            int totalprice = 0;
            CartDAO.Instance.insertCart(rid,aname, aAgency, astatus, apayment, totalprice);
            dataGridView1.DataSource = CartDAO.Instance.GetAllCart();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void add2_Click(object sender, EventArgs e)
        {
            try
            {
                int totalpr;
                int gamount;
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                int a = Int32.Parse(amount.Text);
                int b = GoodDAO.Instance.getAmount(goodid.Text);
                if (b - a >= 0)
                {
                    CartDAO.Instance.addCartDt(id, goodid.Text, Int32.Parse(amount.Text), created.Text);
                    gamount = CartDAO.Instance.getAmount(id, goodid.Text);
                    dataGridView2.DataSource = CartDAO.Instance.getCartbyId(id);
                    totalpr = CartDAO.Instance.getSum(id);
                    CartDAO.Instance.updateTp(totalpr, id);
                    GoodDAO.Instance.updateAmountDown(goodid.Text, gamount);
                    dataGridView1.DataSource = CartDAO.Instance.GetAllCart();
                }
                else
                {
                    MessageBox.Show("Don't have enough product");
                }
            }
            catch
            {
                MessageBox.Show("Product already have in this Cart");
            }
            
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string id1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string id2 = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                int totalpr1 = CartDAO.Instance.getSum2(id1);
                int a = totalpr1 - CartDAO.Instance.getSum1(id1, id2);
                CartDAO.Instance.updateTp(a, cartid2.Text);
                GoodDAO.Instance.updateAmountUp(id2, CartDAO.Instance.getAmount(id1, id2));
                CartDAO.Instance.deleteCartDt(id1, id2);
                dataGridView1.DataSource = CartDAO.Instance.GetAllCart();
                dataGridView2.DataSource = CartDAO.Instance.getCartbyId(id1);
            }
            catch
            {
                MessageBox.Show("Can't delete good from this Cart");
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CartDAO.Instance.GetAllCart();
        }
    }
}
