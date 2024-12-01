namespace Hi
{
    partial class admin
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
            btedit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtpass = new TextBox();
            dtgradmin = new DataGridView();
            btlogin = new Button();
            btdel = new Button();
            txtuser = new TextBox();
            cbpos = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgradmin).BeginInit();
            SuspendLayout();
            // 
            // btedit
            // 
            btedit.Location = new Point(216, 165);
            btedit.Name = "btedit";
            btedit.Size = new Size(94, 29);
            btedit.TabIndex = 1;
            btedit.Text = "Edit";
            btedit.UseVisualStyleBackColor = true;
            btedit.Visible = false;
            btedit.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 20);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 2;
            label1.Text = "Admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 40);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 3;
            label2.Text = "User_name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 86);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txtpass
            // 
            txtpass.Location = new Point(272, 83);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(201, 27);
            txtpass.TabIndex = 6;
            // 
            // dtgradmin
            // 
            dtgradmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgradmin.Location = new Point(36, 221);
            dtgradmin.Name = "dtgradmin";
            dtgradmin.RowHeadersWidth = 51;
            dtgradmin.Size = new Size(695, 189);
            dtgradmin.TabIndex = 7;
            // 
            // btlogin
            // 
            btlogin.Location = new Point(513, 82);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(112, 29);
            btlogin.TabIndex = 8;
            btlogin.Text = "LoginAdmin";
            btlogin.UseVisualStyleBackColor = true;
            btlogin.Click += button1_Click;
            // 
            // btdel
            // 
            btdel.Location = new Point(367, 165);
            btdel.Name = "btdel";
            btdel.Size = new Size(94, 29);
            btdel.TabIndex = 9;
            btdel.Text = "Delete";
            btdel.UseVisualStyleBackColor = true;
            btdel.Visible = false;
            btdel.Click += btdel_Click;
            // 
            // txtuser
            // 
            txtuser.Location = new Point(272, 40);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(201, 27);
            txtuser.TabIndex = 10;
            // 
            // cbpos
            // 
            cbpos.FormattingEnabled = true;
            cbpos.Items.AddRange(new object[] { "Employee", "Director" });
            cbpos.Location = new Point(272, 124);
            cbpos.Name = "cbpos";
            cbpos.Size = new Size(201, 28);
            cbpos.TabIndex = 11;
            cbpos.SelectedIndexChanged += cbpos_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(193, 132);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 12;
            label4.Text = "Position";
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(cbpos);
            Controls.Add(txtuser);
            Controls.Add(btdel);
            Controls.Add(btlogin);
            Controls.Add(dtgradmin);
            Controls.Add(txtpass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btedit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin";
            Text = "a";
            ((System.ComponentModel.ISupportInitialize)dtgradmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btedit;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox txtpass;
        private DataGridView dtgradmin;
        private Button btlogin;
        private Button btdel;
        private TextBox txtuser;
        private ComboBox cbpos;
        private Label label4;
    }
}