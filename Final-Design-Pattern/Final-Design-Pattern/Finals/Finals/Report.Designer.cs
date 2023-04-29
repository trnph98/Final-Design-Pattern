namespace Finals
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tb_GoodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.STOREDataSet = new Finals.STOREDataSet();
            this.tb_CartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_CartDtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ReceiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ReceiptDtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.month = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.find = new System.Windows.Forms.Button();
            this.tb_GoodsTableAdapter = new Finals.STOREDataSetTableAdapters.tb_GoodsTableAdapter();
            this.tb_CartTableAdapter = new Finals.STOREDataSetTableAdapters.tb_CartTableAdapter();
            this.tb_CartDtTableAdapter = new Finals.STOREDataSetTableAdapters.tb_CartDtTableAdapter();
            this.tb_ReceiptTableAdapter = new Finals.STOREDataSetTableAdapters.tb_ReceiptTableAdapter();
            this.tb_ReceiptDtTableAdapter = new Finals.STOREDataSetTableAdapters.tb_ReceiptDtTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_GoodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STOREDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CartDtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ReceiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ReceiptDtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.month.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_GoodsBindingSource
            // 
            this.tb_GoodsBindingSource.DataMember = "tb_Goods";
            this.tb_GoodsBindingSource.DataSource = this.STOREDataSet;
            // 
            // STOREDataSet
            // 
            this.STOREDataSet.DataSetName = "STOREDataSet";
            this.STOREDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_CartBindingSource
            // 
            this.tb_CartBindingSource.DataMember = "tb_Cart";
            this.tb_CartBindingSource.DataSource = this.STOREDataSet;
            this.tb_CartBindingSource.CurrentChanged += new System.EventHandler(this.tb_CartBindingSource_CurrentChanged);
            // 
            // tb_CartDtBindingSource
            // 
            this.tb_CartDtBindingSource.DataMember = "tb_CartDt";
            this.tb_CartDtBindingSource.DataSource = this.STOREDataSet;
            // 
            // tb_ReceiptBindingSource
            // 
            this.tb_ReceiptBindingSource.DataMember = "tb_Receipt";
            this.tb_ReceiptBindingSource.DataSource = this.STOREDataSet;
            // 
            // tb_ReceiptDtBindingSource
            // 
            this.tb_ReceiptDtBindingSource.DataMember = "tb_ReceiptDt";
            this.tb_ReceiptDtBindingSource.DataSource = this.STOREDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_GoodsBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.tb_CartBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.tb_CartDtBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.tb_ReceiptBindingSource;
            reportDataSource5.Name = "DataSet5";
            reportDataSource5.Value = this.tb_ReceiptDtBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Finals.Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 128);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1251, 582);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(137, 27);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(125, 22);
            this.month.TabIndex = 3;
            this.month.EditValueChanged += new System.EventHandler(this.month_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Month";
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(89, 80);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(75, 23);
            this.find.TabIndex = 7;
            this.find.Text = "Find";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // tb_GoodsTableAdapter
            // 
            this.tb_GoodsTableAdapter.ClearBeforeFill = true;
            // 
            // tb_CartTableAdapter
            // 
            this.tb_CartTableAdapter.ClearBeforeFill = true;
            // 
            // tb_CartDtTableAdapter
            // 
            this.tb_CartDtTableAdapter.ClearBeforeFill = true;
            // 
            // tb_ReceiptTableAdapter
            // 
            this.tb_ReceiptTableAdapter.ClearBeforeFill = true;
            // 
            // tb_ReceiptDtTableAdapter
            // 
            this.tb_ReceiptDtTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Xuất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "xuất sản phẩm đã bán";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 701);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.find);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.month);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_GoodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STOREDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CartDtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ReceiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ReceiptDtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.month.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_GoodsBindingSource;
        private STOREDataSet STOREDataSet;
        private System.Windows.Forms.BindingSource tb_CartBindingSource;
        private System.Windows.Forms.BindingSource tb_CartDtBindingSource;
        private System.Windows.Forms.BindingSource tb_ReceiptBindingSource;
        private System.Windows.Forms.BindingSource tb_ReceiptDtBindingSource;
        private STOREDataSetTableAdapters.tb_GoodsTableAdapter tb_GoodsTableAdapter;
        private STOREDataSetTableAdapters.tb_CartTableAdapter tb_CartTableAdapter;
        private STOREDataSetTableAdapters.tb_CartDtTableAdapter tb_CartDtTableAdapter;
        private STOREDataSetTableAdapters.tb_ReceiptTableAdapter tb_ReceiptTableAdapter;
        private STOREDataSetTableAdapters.tb_ReceiptDtTableAdapter tb_ReceiptDtTableAdapter;
        private DevExpress.XtraEditors.TextEdit month;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}