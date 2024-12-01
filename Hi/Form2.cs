using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Hi
{
    public partial class Form2 : Form
    {
        private string userRole;
        public Form2(string role)
        {
            InitializeComponent();
            userRole = role;  
            SetPermissions(); 
        }
        private void SetPermissions()
        {
            if (userRole == "Director")
            {
                btcheck.Visible = true; 
                txtcheck.Visible = true;
              
            }
            else if (userRole == "Employee")
            {
                btcheck.Visible = false;
                txtcheck.Visible = false;
              
            }
            else if (userRole == "Customer" )
            {
                btcheck.Visible = false;
                txtcheck.Visible = false;
                btem.Visible = false;
                btcus.Visible = false;
                btpro.Visible = false;
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Clear_panel()
        {
            panel5.Controls.Clear();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {


        }
        private void LoadFormIntoPanel(UserControl userControl)
        {

        }


        private void addUserControl(UserControl userControl)
        {
            ;
        }
        private void bt3_Click(object sender, EventArgs e)
        {


        }

        private void bt2_Click(object sender, EventArgs e)
        {


        }

        private void bt4_Click(object sender, EventArgs e)
        {


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Clear_panel();
            product form = new product(userRole) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel5.Controls.Add(form);
            form.Show();
            label1.Text = btpro.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear_panel();
            CustomerManagement form = new CustomerManagement(userRole) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel5.Controls.Add(form);
            form.Show();
            label1.Text = btcus.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear_panel();
            EmployeeManagement form = new EmployeeManagement(userRole) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel5.Controls.Add(form);
            form.Show();
            label1.Text = btem.Text;

        }
       private void btsta_Click(object sender, EventArgs e)
        {
            Clear_panel();
            Statistics form = new Statistics() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel5.Controls.Add(form);
            form.Show();
            label1.Text = btsta.Text;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Clear_panel();
            Sale form = new Sale() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel5.Controls.Add(form);
            form.Show();
            label1.Text = button2.Text;
        }
        private void btlog_Click(object sender, EventArgs e)
        {
            Clear_panel();
            admin form = new admin() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel5.Controls.Add(form);
            form.Show();
            label1.Text = btad.Text;
        }
  private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btexit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {


                dangnhap dangnhap = new dangnhap();
                dangnhap.Show();
                this.Hide();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtcheck.Text == "123")
            {


                btad.Visible = true;
                btsta.Visible = true;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng mã admin");
            }

        }

        private void txtcheck_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
