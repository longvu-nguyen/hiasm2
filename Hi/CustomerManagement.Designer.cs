namespace Hi
{
    partial class CustomerManagement
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
            button4 = new Button();
            btdel = new Button();
            btedit = new Button();
            btadd = new Button();
            txtsearch = new TextBox();
            txtphone = new TextBox();
            txtname = new TextBox();
            txtcode = new TextBox();
            dtgrcustomer = new DataGridView();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtaddress = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgrcustomer).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(827, 113);
            button4.Name = "button4";
            button4.Size = new Size(68, 29);
            button4.TabIndex = 36;
            button4.Text = "Search ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btdel
            // 
            btdel.Location = new Point(562, 450);
            btdel.Name = "btdel";
            btdel.Size = new Size(94, 29);
            btdel.TabIndex = 35;
            btdel.Text = "Delete";
            btdel.UseVisualStyleBackColor = true;
            btdel.Click += btdel_Click;
            // 
            // btedit
            // 
            btedit.Location = new Point(371, 450);
            btedit.Name = "btedit";
            btedit.Size = new Size(94, 29);
            btedit.TabIndex = 34;
            btedit.Text = "Edit";
            btedit.UseVisualStyleBackColor = true;
            btedit.Click += btedit_Click;
            // 
            // btadd
            // 
            btadd.Location = new Point(176, 450);
            btadd.Name = "btadd";
            btadd.Size = new Size(94, 29);
            btadd.TabIndex = 33;
            btadd.Text = "Add";
            btadd.UseVisualStyleBackColor = true;
            btadd.Click += btadd_Click;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(639, 113);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(182, 27);
            txtsearch.TabIndex = 32;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(199, 223);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(151, 27);
            txtphone.TabIndex = 30;
            // 
            // txtname
            // 
            txtname.Location = new Point(199, 160);
            txtname.Name = "txtname";
            txtname.Size = new Size(151, 27);
            txtname.TabIndex = 28;
            // 
            // txtcode
            // 
            txtcode.Location = new Point(199, 93);
            txtcode.Name = "txtcode";
            txtcode.Size = new Size(151, 27);
            txtcode.TabIndex = 27;
            txtcode.TextChanged += txtcode_TextChanged;
            // 
            // dtgrcustomer
            // 
            dtgrcustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrcustomer.Location = new Point(387, 160);
            dtgrcustomer.Name = "dtgrcustomer";
            dtgrcustomer.RowHeadersWidth = 51;
            dtgrcustomer.Size = new Size(614, 235);
            dtgrcustomer.TabIndex = 26;
            dtgrcustomer.CellContentClick += dtgrcustomer_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(639, 90);
            label7.Name = "label7";
            label7.Size = new Size(124, 20);
            label7.TabIndex = 25;
            label7.Text = "Search customers";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            label6.Location = new Point(53, 207);
            label6.Name = "label6";
            label6.Size = new Size(68, 27);
            label6.TabIndex = 24;
            label6.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            label3.Location = new Point(55, 142);
            label3.Name = "label3";
            label3.Size = new Size(66, 27);
            label3.TabIndex = 21;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            label2.Location = new Point(26, 90);
            label2.Name = "label2";
            label2.Size = new Size(154, 27);
            label2.TabIndex = 20;
            label2.Text = "Customer code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(308, 18);
            label1.Name = "label1";
            label1.Size = new Size(351, 41);
            label1.TabIndex = 19;
            label1.Text = "Customer Management";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            label4.Location = new Point(35, 283);
            label4.Name = "label4";
            label4.Size = new Size(86, 27);
            label4.TabIndex = 37;
            label4.Text = "Address";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(199, 286);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(151, 27);
            txtaddress.TabIndex = 38;
            // 
            // CustomerManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 550);
            Controls.Add(txtaddress);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(btdel);
            Controls.Add(btedit);
            Controls.Add(btadd);
            Controls.Add(txtsearch);
            Controls.Add(txtphone);
            Controls.Add(txtname);
            Controls.Add(txtcode);
            Controls.Add(dtgrcustomer);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerManagement";
            Text = "CustomerManagement";
            Load += CustomerManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dtgrcustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button btdel;
        private Button btedit;
        private Button btadd;
        private TextBox txtsearch;
        private TextBox txtphone;
        private TextBox txtname;
        private TextBox txtcode;
        private DataGridView dtgrcustomer;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtaddress;
    }
}