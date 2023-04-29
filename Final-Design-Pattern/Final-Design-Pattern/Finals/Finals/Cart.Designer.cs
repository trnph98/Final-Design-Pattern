namespace Finals
{
    partial class Cart
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
            this.created = new DevExpress.XtraEditors.DateEdit();
            this.add2 = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.amount = new DevExpress.XtraEditors.TextEdit();
            this.goodid = new DevExpress.XtraEditors.TextEdit();
            this.cartid2 = new DevExpress.XtraEditors.TextEdit();
            this.total = new DevExpress.XtraEditors.TextEdit();
            this.cartid1 = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.agency = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.status = new DevExpress.XtraEditors.TextEdit();
            this.payment = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.name = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.created.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.created.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartid2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartid1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.name.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // created
            // 
            this.created.EditValue = new System.DateTime(2022, 12, 10, 0, 0, 0, 0);
            this.created.Location = new System.Drawing.Point(712, 133);
            this.created.Name = "created";
            this.created.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.created.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.created.Size = new System.Drawing.Size(156, 22);
            this.created.TabIndex = 37;
            // 
            // add2
            // 
            this.add2.Location = new System.Drawing.Point(922, 13);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(75, 23);
            this.add2.TabIndex = 36;
            this.add2.Text = "Add";
            this.add2.UseVisualStyleBackColor = true;
            this.add2.Click += new System.EventHandler(this.add2_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(291, 136);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 35;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(100, 136);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 34;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(922, 63);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 33;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(712, 94);
            this.amount.Margin = new System.Windows.Forms.Padding(5);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(156, 22);
            this.amount.TabIndex = 32;
            // 
            // goodid
            // 
            this.goodid.Location = new System.Drawing.Point(712, 57);
            this.goodid.Margin = new System.Windows.Forms.Padding(5);
            this.goodid.Name = "goodid";
            this.goodid.Size = new System.Drawing.Size(156, 22);
            this.goodid.TabIndex = 31;
            // 
            // cartid2
            // 
            this.cartid2.Location = new System.Drawing.Point(712, 14);
            this.cartid2.Margin = new System.Windows.Forms.Padding(5);
            this.cartid2.Name = "cartid2";
            this.cartid2.Properties.ReadOnly = true;
            this.cartid2.Size = new System.Drawing.Size(156, 22);
            this.cartid2.TabIndex = 30;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(382, 97);
            this.total.Margin = new System.Windows.Forms.Padding(5);
            this.total.Name = "total";
            this.total.Properties.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(156, 22);
            this.total.TabIndex = 29;
            // 
            // cartid1
            // 
            this.cartid1.Location = new System.Drawing.Point(100, 17);
            this.cartid1.Margin = new System.Windows.Forms.Padding(5);
            this.cartid1.Name = "cartid1";
            this.cartid1.Size = new System.Drawing.Size(156, 22);
            this.cartid1.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Created Day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(620, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Goods Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cart Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Total Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cart Id";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(345, 194);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1199, 253);
            this.dataGridView2.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(335, 253);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Payment";
            // 
            // agency
            // 
            this.agency.Location = new System.Drawing.Point(100, 54);
            this.agency.Margin = new System.Windows.Forms.Padding(5);
            this.agency.Name = "agency";
            this.agency.Size = new System.Drawing.Size(156, 22);
            this.agency.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "Agency";
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(382, 57);
            this.status.Margin = new System.Windows.Forms.Padding(5);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(156, 22);
            this.status.TabIndex = 42;
            // 
            // payment
            // 
            this.payment.Location = new System.Drawing.Point(100, 94);
            this.payment.Margin = new System.Windows.Forms.Padding(5);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(156, 22);
            this.payment.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(300, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 45;
            this.label10.Text = "Name";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(382, 17);
            this.name.Margin = new System.Windows.Forms.Padding(5);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(156, 22);
            this.name.TabIndex = 44;
            this.name.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 447);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.agency);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.created);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.goodid);
            this.Controls.Add(this.cartid2);
            this.Controls.Add(this.total);
            this.Controls.Add(this.cartid1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Cart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.created.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.created.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartid2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartid1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit created;
        private System.Windows.Forms.Button add2;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private DevExpress.XtraEditors.TextEdit amount;
        private DevExpress.XtraEditors.TextEdit goodid;
        private DevExpress.XtraEditors.TextEdit cartid2;
        private DevExpress.XtraEditors.TextEdit total;
        private DevExpress.XtraEditors.TextEdit cartid1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit agency;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit status;
        private DevExpress.XtraEditors.TextEdit payment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit name;
    }
}