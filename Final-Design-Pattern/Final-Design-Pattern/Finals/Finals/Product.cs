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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            LoadGood();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                string goodId = goodid.Text;
                string gname = name.Text;
                string gunit = unit.Text;
                int gprice = Int32.Parse(price.Text);
                string gdescribe = describe.Text;
                string gimage = image.Text;
                int gamount = 0;
                string gsuppiler = supplier.Text;
                GoodDAO.Instance.InsertGood(goodId, gname, gunit, gprice, gdescribe, gimage, gamount, gsuppiler);
                LoadGood();
            }
            catch
            {
                MessageBox.Show("Can't add this product");
            }
        }
        void LoadGood()
        {
            dataGridView1.DataSource = GoodDAO.Instance.GetGoodDTO();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                goodid.Text = row.Cells[0].Value.ToString();
                name.Text = row.Cells[1].Value.ToString();
                unit.Text = row.Cells[2].Value.ToString();
                price.Text = row.Cells[3].Value.ToString();
                describe.Text = row.Cells[4].Value.ToString();
                image.Text = row.Cells[5].Value.ToString();
                amount.Text = row.Cells[6].Value.ToString();
                supplier.Text = row.Cells[7].Value.ToString();
            }
        }

        private void receipt_Click(object sender, EventArgs e)
        {
            Receipt re = new Receipt();
            re.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string gid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                GoodDAO.Instance.DeleteGood(gid);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGood();
            }
            catch
            {
                MessageBox.Show("Không thể xóa sản phẩm này");
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            string goodId = goodid.Text;
            string gname = name.Text;
            string gunit = unit.Text;
            double gprice = double.Parse(price.Text);
            string gdescribe = describe.Text;
            string gimage = image.Text;
            int gamount = Int32.Parse(amount.Text);
            string gsuppiler = supplier.Text;

            //if (txt_DiaChi.Text.Length == 0 || txt_Hoten.Text.Length == 0)
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GoodDAO.Instance.UpdateGood(goodId, gname, gunit, gprice, gdescribe, gimage, gamount, gsuppiler);
                LoadGood();
            //}
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadGood();
        }

        private void Product_Load(object sender, EventArgs e)
        {

        }

        private void cart_Click(object sender, EventArgs e)
        {
            Cart a = new Cart();
            a.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Report a = new Report();
            a.Show();
        }
    }
}
