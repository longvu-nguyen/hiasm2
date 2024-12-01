namespace Hi
{
    partial class dangnhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            btlogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            btExit = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 230);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 1;
            label2.Text = "Pass";
            label2.Click += label2_Click;
            // 
            // btlogin
            // 
            btlogin.Location = new Point(83, 358);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(132, 51);
            btlogin.TabIndex = 3;
            btlogin.Text = "Login";
            btlogin.UseVisualStyleBackColor = true;
            btlogin.Click += btlogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(90, 156);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 5;
            txtUsername.TextChanged += textname_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(90, 227);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 6;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 156);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 8;
            label1.Text = "Name";
            label1.Click += label1_Click_1;
            // 
            // btExit
            // 
            btExit.Location = new Point(221, 389);
            btExit.Name = "btExit";
            btExit.Size = new Size(73, 29);
            btExit.TabIndex = 9;
            btExit.Text = "exit";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += button3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(119, 301);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 10;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(119, 324);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(59, 20);
            linkLabel2.TabIndex = 11;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "register";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.ActiveBorder;
            checkBox1.BackgroundImage = Properties.Resources.Ảnh_chụp_màn_hình_2024_11_11_073422;
            checkBox1.BackgroundImageLayout = ImageLayout.Stretch;
            checkBox1.Location = new Point(231, 237);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 13;
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.White_and_Blue_Minimalist_Clothing_Store_Logo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(306, 430);
            Controls.Add(checkBox1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(btExit);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btlogin);
            Controls.Add(label2);
            Name = "dangnhap";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btlogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Button btExit;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private CheckBox checkBox1;
    }
}
