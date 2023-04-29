namespace Finals
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.receipt = new System.Windows.Forms.ToolStripButton();
            this.cart = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.goodid = new DevExpress.XtraEditors.TextEdit();
            this.name = new DevExpress.XtraEditors.TextEdit();
            this.unit = new DevExpress.XtraEditors.TextEdit();
            this.price = new DevExpress.XtraEditors.TextEdit();
            this.describe = new DevExpress.XtraEditors.TextEdit();
            this.image = new DevExpress.XtraEditors.TextEdit();
            this.amount = new DevExpress.XtraEditors.TextEdit();
            this.supplier = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.describe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplier.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receipt,
            this.cart,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1222, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // receipt
            // 
            this.receipt.Image = ((System.Drawing.Image)(resources.GetObject("receipt.Image")));
            this.receipt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(83, 24);
            this.receipt.Text = "Receipt";
            this.receipt.Click += new System.EventHandler(this.receipt_Click);
            // 
            // cart
            // 
            this.cart.Image = ((System.Drawing.Image)(resources.GetObject("cart.Image")));
            this.cart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(60, 24);
            this.cart.Text = "Cart";
            this.cart.Click += new System.EventHandler(this.cart_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1222, 249);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Good Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Describe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(447, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Supplier";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(55, 236);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(91, 23);
            this.add.TabIndex = 10;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(205, 236);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(83, 23);
            this.update.TabIndex = 11;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(354, 237);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 12;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // goodid
            // 
            this.goodid.Location = new System.Drawing.Point(153, 62);
            this.goodid.Margin = new System.Windows.Forms.Padding(5);
            this.goodid.Name = "goodid";
            this.goodid.Size = new System.Drawing.Size(156, 22);
            this.goodid.TabIndex = 14;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(153, 100);
            this.name.Margin = new System.Windows.Forms.Padding(5);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(156, 22);
            this.name.TabIndex = 15;
            // 
            // unit
            // 
            this.unit.Location = new System.Drawing.Point(153, 137);
            this.unit.Margin = new System.Windows.Forms.Padding(5);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(156, 22);
            this.unit.TabIndex = 16;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(153, 175);
            this.price.Margin = new System.Windows.Forms.Padding(5);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(156, 22);
            this.price.TabIndex = 17;
            // 
            // describe
            // 
            this.describe.Location = new System.Drawing.Point(570, 62);
            this.describe.Margin = new System.Windows.Forms.Padding(5);
            this.describe.Name = "describe";
            this.describe.Size = new System.Drawing.Size(156, 22);
            this.describe.TabIndex = 18;
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(570, 100);
            this.image.Margin = new System.Windows.Forms.Padding(5);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(156, 22);
            this.image.TabIndex = 19;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(570, 137);
            this.amount.Margin = new System.Windows.Forms.Padding(5);
            this.amount.Name = "amount";
            this.amount.Properties.ReadOnly = true;
            this.amount.Size = new System.Drawing.Size(156, 22);
            this.amount.TabIndex = 20;
            // 
            // supplier
            // 
            this.supplier.Location = new System.Drawing.Point(570, 175);
            this.supplier.Margin = new System.Windows.Forms.Padding(5);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(156, 22);
            this.supplier.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(447, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Image";
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(486, 237);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 23;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(78, 24);
            this.toolStripButton1.Text = "Report";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 530);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.supplier);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.image);
            this.Controls.Add(this.describe);
            this.Controls.Add(this.price);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.name);
            this.Controls.Add(this.goodid);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.describe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplier.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton receipt;
        private System.Windows.Forms.ToolStripButton cart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private DevExpress.XtraEditors.TextEdit goodid;
        private DevExpress.XtraEditors.TextEdit name;
        private DevExpress.XtraEditors.TextEdit unit;
        private DevExpress.XtraEditors.TextEdit price;
        private DevExpress.XtraEditors.TextEdit describe;
        private DevExpress.XtraEditors.TextEdit image;
        private DevExpress.XtraEditors.TextEdit amount;
        private DevExpress.XtraEditors.TextEdit supplier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}