namespace Hi
{
    partial class EmployeeManagement
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtgremployee = new DataGridView();
            txtcode = new TextBox();
            txtname = new TextBox();
            txtau = new TextBox();
            txtphone = new TextBox();
            cbposi = new ComboBox();
            txtsearch = new TextBox();
            btadd = new Button();
            btedit = new Button();
            btdel = new Button();
            btsearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgremployee).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(303, 39);
            label1.Name = "label1";
            label1.Size = new Size(362, 41);
            label1.TabIndex = 0;
            label1.Text = " Employee Management";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            label2.Location = new Point(50, 157);
            label2.Name = "label2";
            label2.Size = new Size(105, 27);
            label2.TabIndex = 1;
            label2.Text = "User code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            label3.Location = new Point(50, 217);
            label3.Name = "label3";
            label3.Size = new Size(66, 27);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            label4.Location = new Point(50, 279);
            label4.Name = "label4";
            label4.Size = new Size(84, 27);
            label4.TabIndex = 3;
            label4.Text = "Position";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            label5.Location = new Point(50, 334);
            label5.Name = "label5";
            label5.Size = new Size(99, 27);
            label5.TabIndex = 4;
            label5.Text = "Authority";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            label6.Location = new Point(50, 396);
            label6.Name = "label6";
            label6.Size = new Size(68, 27);
            label6.TabIndex = 5;
            label6.Text = "Phone";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(634, 111);
            label7.Name = "label7";
            label7.Size = new Size(129, 20);
            label7.TabIndex = 6;
            label7.Text = "Search employees";
            // 
            // dtgremployee
            // 
            dtgremployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgremployee.Location = new Point(382, 188);
            dtgremployee.Name = "dtgremployee";
            dtgremployee.RowHeadersWidth = 51;
            dtgremployee.Size = new Size(706, 235);
            dtgremployee.TabIndex = 7;
            dtgremployee.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtcode
            // 
            txtcode.Location = new Point(166, 160);
            txtcode.Name = "txtcode";
            txtcode.Size = new Size(181, 27);
            txtcode.TabIndex = 8;
            txtcode.TextChanged += textBox1_TextChanged;
            // 
            // txtname
            // 
            txtname.Location = new Point(166, 217);
            txtname.Name = "txtname";
            txtname.Size = new Size(181, 27);
            txtname.TabIndex = 9;
            // 
            // txtau
            // 
            txtau.Location = new Point(166, 334);
            txtau.Name = "txtau";
            txtau.Size = new Size(181, 27);
            txtau.TabIndex = 11;
            txtau.TextChanged += textBox4_TextChanged;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(166, 396);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(181, 27);
            txtphone.TabIndex = 12;
            // 
            // cbposi
            // 
            cbposi.FormattingEnabled = true;
            cbposi.Items.AddRange(new object[] { "Sales agent", "Cashier", "Manager" });
            cbposi.Location = new Point(166, 282);
            cbposi.Name = "cbposi";
            cbposi.Size = new Size(181, 28);
            cbposi.TabIndex = 13;
            cbposi.SelectedIndexChanged += cbposi_SelectedIndexChanged;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(634, 134);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(182, 27);
            txtsearch.TabIndex = 14;
            // 
            // btadd
            // 
            btadd.Location = new Point(171, 471);
            btadd.Name = "btadd";
            btadd.Size = new Size(94, 29);
            btadd.TabIndex = 15;
            btadd.Text = "Add";
            btadd.UseVisualStyleBackColor = true;
            btadd.Click += btadd_Click;
            // 
            // btedit
            // 
            btedit.Location = new Point(366, 471);
            btedit.Name = "btedit";
            btedit.Size = new Size(94, 29);
            btedit.TabIndex = 16;
            btedit.Text = "Edit";
            btedit.UseVisualStyleBackColor = true;
            btedit.Click += btedit_Click;
            // 
            // btdel
            // 
            btdel.Location = new Point(557, 471);
            btdel.Name = "btdel";
            btdel.Size = new Size(94, 29);
            btdel.TabIndex = 17;
            btdel.Text = "Delete";
            btdel.UseVisualStyleBackColor = true;
            btdel.Click += btdel_Click;
            // 
            // btsearch
            // 
            btsearch.Location = new Point(822, 134);
            btsearch.Name = "btsearch";
            btsearch.Size = new Size(68, 29);
            btsearch.TabIndex = 18;
            btsearch.Text = "Search ";
            btsearch.UseVisualStyleBackColor = true;
            btsearch.Click += btsearch_Click;
            // 
            // EmployeeManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 596);
            Controls.Add(btsearch);
            Controls.Add(btdel);
            Controls.Add(btedit);
            Controls.Add(btadd);
            Controls.Add(txtsearch);
            Controls.Add(cbposi);
            Controls.Add(txtphone);
            Controls.Add(txtau);
            Controls.Add(txtname);
            Controls.Add(txtcode);
            Controls.Add(dtgremployee);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeManagement";
            Text = "EmployeeManagement";
            Load += EmployeeManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dtgremployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dtgremployee;
        private TextBox txtcode;
        private TextBox txtname;
        private TextBox txtau;
        private TextBox txtphone;
        private ComboBox cbposi;
        private TextBox txtsearch;
        private Button btadd;
        private Button btedit;
        private Button btdel;
        private Button btsearch;
    }
}