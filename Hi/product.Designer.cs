namespace Hi
{
    partial class product
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
            txtname = new TextBox();
            txtPrice = new TextBox();
            txtavai = new TextBox();
            txtid = new TextBox();
            btadd = new Button();
            btedit = new Button();
            dtproduct = new DataGridView();
            label1 = new Label();
            txtsearch = new TextBox();
            btdel = new Button();
            btsearch = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtentry = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtproduct).BeginInit();
            SuspendLayout();
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtname.Location = new Point(202, 137);
            txtname.Name = "txtname";
            txtname.Size = new Size(182, 30);
            txtname.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(538, 143);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(182, 27);
            txtPrice.TabIndex = 1;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // txtavai
            // 
            txtavai.Location = new Point(381, 186);
            txtavai.Name = "txtavai";
            txtavai.Size = new Size(182, 27);
            txtavai.TabIndex = 2;
            // 
            // txtid
            // 
            txtid.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtid.Location = new Point(202, 90);
            txtid.Name = "txtid";
            txtid.Size = new Size(182, 30);
            txtid.TabIndex = 3;
            txtid.TextChanged += txtid_TextChanged;
            // 
            // btadd
            // 
            btadd.Location = new Point(150, 238);
            btadd.Name = "btadd";
            btadd.Size = new Size(94, 29);
            btadd.TabIndex = 4;
            btadd.Text = "Add";
            btadd.UseVisualStyleBackColor = true;
            btadd.Click += button1_Click;
            // 
            // btedit
            // 
            btedit.Location = new Point(284, 238);
            btedit.Name = "btedit";
            btedit.Size = new Size(94, 29);
            btedit.TabIndex = 5;
            btedit.Text = "Edit";
            btedit.UseVisualStyleBackColor = true;
            btedit.Click += btedit_Click;
            // 
            // dtproduct
            // 
            dtproduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtproduct.Location = new Point(67, 289);
            dtproduct.Name = "dtproduct";
            dtproduct.RowHeadersWidth = 51;
            dtproduct.Size = new Size(766, 263);
            dtproduct.TabIndex = 6;
            dtproduct.CellContentClick += dtproduct_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(294, 9);
            label1.Name = "label1";
            label1.Size = new Size(301, 30);
            label1.TabIndex = 7;
            label1.Text = "Product Management";
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(578, 238);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(182, 27);
            txtsearch.TabIndex = 8;
            // 
            // btdel
            // 
            btdel.Location = new Point(424, 238);
            btdel.Name = "btdel";
            btdel.Size = new Size(94, 29);
            btdel.TabIndex = 9;
            btdel.Text = "Delete";
            btdel.UseVisualStyleBackColor = true;
            btdel.Click += btdel_Click;
            // 
            // btsearch
            // 
            btsearch.Location = new Point(766, 238);
            btsearch.Name = "btsearch";
            btsearch.Size = new Size(94, 29);
            btsearch.TabIndex = 10;
            btsearch.Text = "search";
            btsearch.UseVisualStyleBackColor = true;
            btsearch.Click += btsearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(90, 94);
            label2.Name = "label2";
            label2.Size = new Size(27, 23);
            label2.TabIndex = 11;
            label2.Text = "ID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(90, 144);
            label3.Name = "label3";
            label3.Size = new Size(56, 23);
            label3.TabIndex = 12;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(417, 145);
            label4.Name = "label4";
            label4.Size = new Size(47, 23);
            label4.TabIndex = 13;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(284, 186);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 14;
            label5.Text = "Available";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(417, 90);
            label6.Name = "label6";
            label6.Size = new Size(93, 23);
            label6.TabIndex = 17;
            label6.Text = "Entry price";
            // 
            // txtentry
            // 
            txtentry.Location = new Point(538, 90);
            txtentry.Name = "txtentry";
            txtentry.Size = new Size(182, 27);
            txtentry.TabIndex = 18;
            // 
            // product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 585);
            Controls.Add(txtentry);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btsearch);
            Controls.Add(btdel);
            Controls.Add(txtsearch);
            Controls.Add(label1);
            Controls.Add(dtproduct);
            Controls.Add(btedit);
            Controls.Add(btadd);
            Controls.Add(txtid);
            Controls.Add(txtavai);
            Controls.Add(txtPrice);
            Controls.Add(txtname);
            FormBorderStyle = FormBorderStyle.None;
            Name = "product";
            Text = "product";
            Load += product_Load;
            ((System.ComponentModel.ISupportInitialize)dtproduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtname;
        private TextBox txtPrice;
        private TextBox txtavai;
        private TextBox txtid;
        private Button btadd;
        private Button btedit;
        private DataGridView dtproduct;
        private Label label1;
        private TextBox txtsearch;
        private Button btdel;
        private Button btsearch;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtentry;
    }
}