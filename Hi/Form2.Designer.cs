namespace Hi
{
    partial class Form2
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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            btcheck = new Button();
            txtcheck = new TextBox();
            btexit = new Button();
            btad = new Button();
            btem = new Button();
            btsta = new Button();
            btcus = new Button();
            btpro = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(228, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1236, 95);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(5, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(796, 296);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(459, 9);
            label1.Name = "label1";
            label1.Size = new Size(189, 60);
            label1.TabIndex = 0;
            label1.Text = "Manage";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.ImeMode = ImeMode.NoControl;
            panel4.Location = new Point(0, 92);
            panel4.Name = "panel4";
            panel4.Size = new Size(1236, 596);
            panel4.TabIndex = 8;
            panel4.Paint += panel4_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(btcheck);
            panel3.Controls.Add(txtcheck);
            panel3.Controls.Add(btexit);
            panel3.Controls.Add(btad);
            panel3.Controls.Add(btem);
            panel3.Controls.Add(btsta);
            panel3.Controls.Add(btcus);
            panel3.Controls.Add(btpro);
            panel3.ImeMode = ImeMode.NoControl;
            panel3.Location = new Point(0, 165);
            panel3.Name = "panel3";
            panel3.Size = new Size(228, 523);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(228, 69);
            button2.TabIndex = 4;
            button2.Text = "Sell";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // btcheck
            // 
            btcheck.BackColor = SystemColors.ActiveBorder;
            btcheck.Location = new Point(120, 283);
            btcheck.Name = "btcheck";
            btcheck.Size = new Size(67, 30);
            btcheck.TabIndex = 18;
            btcheck.Text = "Check";
            btcheck.UseVisualStyleBackColor = false;
            btcheck.Click += button1_Click_1;
            // 
            // txtcheck
            // 
            txtcheck.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtcheck.Location = new Point(12, 283);
            txtcheck.Name = "txtcheck";
            txtcheck.PasswordChar = '*';
            txtcheck.Size = new Size(102, 30);
            txtcheck.TabIndex = 17;
            txtcheck.TextChanged += txtcheck_TextChanged;
            // 
            // btexit
            // 
            btexit.Location = new Point(76, 478);
            btexit.Name = "btexit";
            btexit.Size = new Size(69, 37);
            btexit.TabIndex = 8;
            btexit.Text = "exit";
            btexit.UseVisualStyleBackColor = true;
            btexit.Click += btexit_Click;
            // 
            // btad
            // 
            btad.Location = new Point(0, 386);
            btad.Name = "btad";
            btad.Size = new Size(228, 76);
            btad.TabIndex = 7;
            btad.Text = "admin";
            btad.UseVisualStyleBackColor = true;
            btad.Visible = false;
            btad.Click += btlog_Click;
            // 
            // btem
            // 
            btem.Location = new Point(0, 198);
            btem.Name = "btem";
            btem.Size = new Size(228, 70);
            btem.TabIndex = 4;
            btem.Text = "Employee ";
            btem.UseVisualStyleBackColor = true;
            btem.Click += button2_Click;
            // 
            // btsta
            // 
            btsta.Location = new Point(0, 319);
            btsta.Name = "btsta";
            btsta.Size = new Size(228, 70);
            btsta.TabIndex = 6;
            btsta.Text = "Statistics";
            btsta.UseVisualStyleBackColor = true;
            btsta.Visible = false;
            btsta.Click += btsta_Click;
            // 
            // btcus
            // 
            btcus.Location = new Point(0, 133);
            btcus.Name = "btcus";
            btcus.Size = new Size(228, 70);
            btcus.TabIndex = 5;
            btcus.Text = "Customer";
            btcus.UseVisualStyleBackColor = true;
            btcus.Click += button3_Click;
            // 
            // btpro
            // 
            btpro.Location = new Point(0, 66);
            btpro.Name = "btpro";
            btpro.Size = new Size(228, 78);
            btpro.TabIndex = 3;
            btpro.Text = "Product";
            btpro.UseVisualStyleBackColor = true;
            btpro.Click += button4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.White_and_Blue_Minimalist_Clothing_Store_Logo;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(228, 178);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel5
            // 
            panel5.Location = new Point(228, 95);
            panel5.Name = "panel5";
            panel5.Size = new Size(1236, 602);
            panel5.TabIndex = 3;
            panel5.Paint += panel5_Paint;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1465, 692);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button bt4;
        private Button btexit;
        private Panel panel4;
        private Button btem;
        private Button btad;
        private Button btsta;
        private Button btcus;
        private Button btpro;
        private PictureBox pictureBox2;
        private Panel panel5;
        private Button btcheck;
        private TextBox txtcheck;
        private Button button2;
    }
}