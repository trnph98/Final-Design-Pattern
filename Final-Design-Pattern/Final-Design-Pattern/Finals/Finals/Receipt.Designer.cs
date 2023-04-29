namespace Finals
{
    partial class Receipt
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.receiptid1 = new DevExpress.XtraEditors.TextEdit();
            this.total = new DevExpress.XtraEditors.TextEdit();
            this.receiptid2 = new DevExpress.XtraEditors.TextEdit();
            this.goodid = new DevExpress.XtraEditors.TextEdit();
            this.amount = new DevExpress.XtraEditors.TextEdit();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.add2 = new System.Windows.Forms.Button();
            this.created = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptid1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptid2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.created.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.created.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(345, 253);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(363, 185);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(961, 253);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Receipt Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Receipt Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Goods Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Created Day";
            // 
            // receiptid1
            // 
            this.receiptid1.Location = new System.Drawing.Point(108, 34);
            this.receiptid1.Margin = new System.Windows.Forms.Padding(5);
            this.receiptid1.Name = "receiptid1";
            this.receiptid1.Size = new System.Drawing.Size(156, 22);
            this.receiptid1.TabIndex = 8;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(108, 71);
            this.total.Margin = new System.Windows.Forms.Padding(5);
            this.total.Name = "total";
            this.total.Properties.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(156, 22);
            this.total.TabIndex = 9;
            // 
            // receiptid2
            // 
            this.receiptid2.Location = new System.Drawing.Point(497, 14);
            this.receiptid2.Margin = new System.Windows.Forms.Padding(5);
            this.receiptid2.Name = "receiptid2";
            this.receiptid2.Properties.ReadOnly = true;
            this.receiptid2.Size = new System.Drawing.Size(156, 22);
            this.receiptid2.TabIndex = 10;
            this.receiptid2.EditValueChanged += new System.EventHandler(this.receiptid2_EditValueChanged);
            // 
            // goodid
            // 
            this.goodid.Location = new System.Drawing.Point(497, 52);
            this.goodid.Margin = new System.Windows.Forms.Padding(5);
            this.goodid.Name = "goodid";
            this.goodid.Size = new System.Drawing.Size(156, 22);
            this.goodid.TabIndex = 11;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(497, 89);
            this.amount.Margin = new System.Windows.Forms.Padding(5);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(156, 22);
            this.amount.TabIndex = 12;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(707, 58);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 14;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(19, 131);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 15;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(162, 131);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 16;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // add2
            // 
            this.add2.Location = new System.Drawing.Point(707, 17);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(75, 23);
            this.add2.TabIndex = 18;
            this.add2.Text = "Add";
            this.add2.UseVisualStyleBackColor = true;
            this.add2.Click += new System.EventHandler(this.add2_Click);
            // 
            // created
            // 
            this.created.EditValue = new System.DateTime(2022, 12, 10, 0, 0, 0, 0);
            this.created.Location = new System.Drawing.Point(497, 128);
            this.created.Name = "created";
            this.created.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.created.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.created.Size = new System.Drawing.Size(156, 22);
            this.created.TabIndex = 19;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 450);
            this.Controls.Add(this.created);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.goodid);
            this.Controls.Add(this.receiptid2);
            this.Controls.Add(this.total);
            this.Controls.Add(this.receiptid1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptid1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptid2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.created.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.created.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit receiptid1;
        private DevExpress.XtraEditors.TextEdit total;
        private DevExpress.XtraEditors.TextEdit receiptid2;
        private DevExpress.XtraEditors.TextEdit goodid;
        private DevExpress.XtraEditors.TextEdit amount;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button add2;
        private DevExpress.XtraEditors.DateEdit created;
    }
}