namespace Hi
{
    partial class Sale
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
            btdel = new Button();
            label1 = new Label();
            dtsale = new DataGridView();
            btadd = new Button();
            date = new DateTimePicker();
            label4 = new Label();
            txtqua = new TextBox();
            label5 = new Label();
            datasale1 = new DataGridView();
            label6 = new Label();
            cmbProduct = new ComboBox();
            label7 = new Label();
            textid = new TextBox();
            lblCustomerID = new Label();
            ((System.ComponentModel.ISupportInitialize)dtsale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datasale1).BeginInit();
            SuspendLayout();
            // 
            // btdel
            // 
            btdel.Location = new Point(834, 182);
            btdel.Name = "btdel";
            btdel.Size = new Size(94, 29);
            btdel.TabIndex = 28;
            btdel.Text = "Delete";
            btdel.UseVisualStyleBackColor = true;
            btdel.Click += btdel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, -46);
            label1.Name = "label1";
            label1.Size = new Size(301, 30);
            label1.TabIndex = 26;
            label1.Text = "Product Management";
            // 
            // dtsale
            // 
            dtsale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtsale.Location = new Point(706, 249);
            dtsale.Name = "dtsale";
            dtsale.RowHeadersWidth = 51;
            dtsale.Size = new Size(466, 263);
            dtsale.TabIndex = 25;
            dtsale.CellContentClick += dtsale_CellContentClick;
            // 
            // btadd
            // 
            btadd.Location = new Point(283, 182);
            btadd.Name = "btadd";
            btadd.Size = new Size(94, 29);
            btadd.TabIndex = 23;
            btadd.Text = "SELL";
            btadd.UseVisualStyleBackColor = true;
            btadd.Click += btadd_Click;
            // 
            // date
            // 
            date.Location = new Point(784, 112);
            date.Name = "date";
            date.Size = new Size(250, 27);
            date.TabIndex = 36;
            date.ValueChanged += date_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(300, 127);
            label4.Name = "label4";
            label4.Size = new Size(77, 23);
            label4.TabIndex = 37;
            label4.Text = "Quantity";
            // 
            // txtqua
            // 
            txtqua.Location = new Point(387, 126);
            txtqua.Name = "txtqua";
            txtqua.Size = new Size(182, 27);
            txtqua.TabIndex = 38;
            txtqua.TextChanged += txtqua_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(693, 126);
            label5.Name = "label5";
            label5.Size = new Size(46, 23);
            label5.TabIndex = 39;
            label5.Text = "Date";
            // 
            // datasale1
            // 
            datasale1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datasale1.Location = new Point(36, 249);
            datasale1.Name = "datasale1";
            datasale1.RowHeadersWidth = 51;
            datasale1.Size = new Size(588, 263);
            datasale1.TabIndex = 40;
            datasale1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(1099, 223);
            label6.Name = "label6";
            label6.Size = new Size(73, 23);
            label6.TabIndex = 41;
            label6.Text = "Price list";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(103, 127);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(151, 28);
            cmbProduct.TabIndex = 42;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label7.Location = new Point(56, 132);
            label7.Name = "label7";
            label7.Size = new Size(25, 23);
            label7.TabIndex = 43;
            label7.Text = "Id";
            // 
            // textid
            // 
            textid.Location = new Point(753, 183);
            textid.Name = "textid";
            textid.Size = new Size(75, 27);
            textid.TabIndex = 44;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(36, 182);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(104, 20);
            lblCustomerID.TabIndex = 46;
            lblCustomerID.Text = "lblCustomerID";
            // 
            // Sale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 645);
            Controls.Add(lblCustomerID);
            Controls.Add(textid);
            Controls.Add(label7);
            Controls.Add(cmbProduct);
            Controls.Add(label6);
            Controls.Add(datasale1);
            Controls.Add(label5);
            Controls.Add(txtqua);
            Controls.Add(label4);
            Controls.Add(date);
            Controls.Add(btdel);
            Controls.Add(label1);
            Controls.Add(dtsale);
            Controls.Add(btadd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sale";
            Text = "Sale";
            Load += Sale_Load;
            ((System.ComponentModel.ISupportInitialize)dtsale).EndInit();
            ((System.ComponentModel.ISupportInitialize)datasale1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btdel;
        private Label label1;
        private DataGridView dtsale;
        private Button btadd;
        private TextBox txtid;
        private DateTimePicker date;
        private Label label4;
        private TextBox txtqua;
        private Label label5;
        private DataGridView datasale1;
        private Label label6;
        private ComboBox cmbProduct;
        private Label label7;
        private TextBox textid;
        private Label lblCustomerID;
    }
}