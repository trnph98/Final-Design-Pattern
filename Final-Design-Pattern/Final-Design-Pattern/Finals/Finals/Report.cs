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
using Finals.DTO;
using Finals.Pattern;

namespace Finals
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'STOREDataSet.tb_Goods' table. You can move, or remove it, as needed.
            this.tb_GoodsTableAdapter.Fill(this.STOREDataSet.tb_Goods);
            // TODO: This line of code loads data into the 'STOREDataSet.tb_Cart' table. You can move, or remove it, as needed.
            this.tb_CartTableAdapter.Fill(this.STOREDataSet.tb_Cart);
            // TODO: This line of code loads data into the 'STOREDataSet.tb_CartDt' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'STOREDataSet.tb_Receipt' table. You can move, or remove it, as needed.
            this.tb_ReceiptTableAdapter.Fill(this.STOREDataSet.tb_Receipt);
            // TODO: This line of code loads data into the 'STOREDataSet.tb_ReceiptDt' table. You can move, or remove it, as needed.
            

            this.reportViewer1.RefreshReport();
        }

        private void find_Click(object sender, EventArgs e)
        {
            this.tb_ReceiptDtTableAdapter.Fill(this.STOREDataSet.tb_ReceiptDt,Decimal.Parse(month.Text));
            this.tb_CartDtTableAdapter.Fill(this.STOREDataSet.tb_CartDt, Decimal.Parse(month.Text));
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {
           
        }

        private void tb_CartBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buttons buttons = new Buttons();
            ICommand turnOnCommand = new TOCommand(buttons);
            MenuOptions rm = new MenuOptions(turnOnCommand);
            rm.TurnOnButtonClick();
        }

        private void month_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
