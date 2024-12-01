namespace Hi
{
    partial class dangki
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtname = new TextBox();
            txtpass = new TextBox();
            label3 = new Label();
            txtrepass = new TextBox();
            linkLabel1 = new LinkLabel();
            txtaddress = new TextBox();
            label4 = new Label();
            txtphone = new TextBox();
            label6 = new Label();
            txtcusname = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.White_and_Blue_Minimalist_Clothing_Store_Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(98, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 155);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(162, 479);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.Location = new Point(66, 185);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 2;
            label1.Text = "User";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.Location = new Point(57, 235);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtname
            // 
            txtname.Location = new Point(181, 185);
            txtname.Name = "txtname";
            txtname.Size = new Size(151, 27);
            txtname.TabIndex = 4;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(181, 235);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(151, 27);
            txtpass.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label3.Location = new Point(45, 287);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 6;
            label3.Text = "Re-password";
            // 
            // txtrepass
            // 
            txtrepass.Location = new Point(181, 285);
            txtrepass.Name = "txtrepass";
            txtrepass.Size = new Size(151, 27);
            txtrepass.TabIndex = 7;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(147, 520);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(124, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "I have an account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(181, 433);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(151, 27);
            txtaddress.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            label4.Location = new Point(66, 430);
            label4.Name = "label4";
            label4.Size = new Size(86, 27);
            label4.TabIndex = 41;
            label4.Text = "Address";
            // 
            // txtphone
            // 
            txtphone.Location = new Point(181, 386);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(151, 27);
            txtphone.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            label6.Location = new Point(79, 386);
            label6.Name = "label6";
            label6.Size = new Size(68, 27);
            label6.TabIndex = 39;
            label6.Text = "Phone";
            // 
            // txtcusname
            // 
            txtcusname.Location = new Point(181, 334);
            txtcusname.Name = "txtcusname";
            txtcusname.Size = new Size(151, 27);
            txtcusname.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label5.Location = new Point(64, 336);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 43;
            label5.Text = "Name";
            // 
            // dangki
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(442, 549);
            Controls.Add(txtcusname);
            Controls.Add(label5);
            Controls.Add(txtaddress);
            Controls.Add(label4);
            Controls.Add(txtphone);
            Controls.Add(label6);
            Controls.Add(linkLabel1);
            Controls.Add(txtrepass);
            Controls.Add(label3);
            Controls.Add(txtpass);
            Controls.Add(txtname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "dangki";
            Text = "dangki";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txtname;
        private TextBox txtpass;
        private Label label3;
        private TextBox txtrepass;
        private LinkLabel linkLabel1;
        private TextBox txtaddress;
        private Label label4;
        private TextBox txtphone;
        private Label label6;
        private TextBox txtcusname;
        private Label label5;
    }
}