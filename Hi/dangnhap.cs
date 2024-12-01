using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hi
{
    public partial class dangnhap : Form

    {
        string str = @"Data Source=NhinDauBuoi;Initial Catalog=asmlongvu;Integrated Security=True;TrustServerCertificate=True";
        public static class UserSession
        {
            public static int CurrentCustomerID { get; set; }
        }

        // Khi người dùng đăng nhập thành công
        public dangnhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            string User_Name = txtUsername.Text.Trim();
            string Password = txtPassword.Text.Trim();

            // Kiểm tra đầu vào
            if (string.IsNullOrEmpty(User_Name) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please enter your username and password.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
               
            // Sử dụng SqlConnection và SqlCommand trong khối using
            using (SqlConnection con = new SqlConnection(str))
            {


                con.Open();
                string sql = "SELECT Role, Customer_ID From Login WHERE User_Name = @User_Name AND Password = @Password";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    
                    cmd.Parameters.AddWithValue("@User_Name", User_Name);
                    cmd.Parameters.AddWithValue("@Password", Password); 

                    using (SqlDataReader dta = cmd.ExecuteReader())
                    {
                        if (dta.Read())  
                        {
                            object role = dta["Role"]; 
                            object customerID = dta["Customer_ID"]; 

                            if (role != null)
                            {
                                string userRole = role.ToString();
                                UserSession.CurrentCustomerID = customerID != DBNull.Value ? Convert.ToInt32(customerID) : 0;
                                MessageBox.Show("Login Successfully");
                           
                                Form2 form2 = new Form2(userRole);
                                form2.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Login Failed");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Login Failed");
                        }
                    }
                }



            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dangki dangki = new dangki();
            dangki.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
                

            }
            else
            {
                txtPassword.PasswordChar = '*';
            }

        }
    }
}
