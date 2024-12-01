namespace Hi
{
    partial class Statistics
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
            menuStrip1 = new MenuStrip();
            datasta = new DataGridView();
            dateend = new DateTimePicker();
            btnCalculate = new Button();
            datestart = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)datasta).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(429, 16);
            label1.Name = "label1";
            label1.Size = new Size(143, 40);
            label1.TabIndex = 0;
            label1.Text = "Statistics";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1159, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // datasta
            // 
            datasta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datasta.Location = new Point(185, 148);
            datasta.Name = "datasta";
            datasta.RowHeadersWidth = 51;
            datasta.Size = new Size(716, 237);
            datasta.TabIndex = 9;
            datasta.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // dateend
            // 
            dateend.Location = new Point(545, 99);
            dateend.Name = "dateend";
            dateend.Size = new Size(250, 27);
            dateend.TabIndex = 10;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(807, 99);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // datestart
            // 
            datestart.Location = new Point(545, 66);
            datestart.Name = "datestart";
            datestart.Size = new Size(250, 27);
            datestart.TabIndex = 12;
            // 
            // Statistics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 521);
            Controls.Add(datestart);
            Controls.Add(btnCalculate);
            Controls.Add(dateend);
            Controls.Add(datasta);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Statistics";
            Text = "Statistics";
            Load += Statistics_Load;
            ((System.ComponentModel.ISupportInitialize)datasta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private DataGridView datasta;
        private DateTimePicker dateend;
        private Button btnCalculate;
        private DateTimePicker datestart;
    }
}