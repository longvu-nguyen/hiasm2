using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Transactions;

namespace Hi
{
    public partial class dangki : Form
    {
        string str = @"Data Source=NhinDauBuoi;Initial Catalog=asmlongvu;Integrated Security=True;TrustServerCertificate=True";
        public dangki()
        {
            InitializeComponent();
        }
        public bool checkAccount(string str)
        {
            return Regex.IsMatch(str, @"^[a-zA-Z0-9_.]{0,20}$");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string tk = txtname.Text;
            string mk = txtpass.Text;
            string rmk = txtrepass.Text;
            string customerName = txtcusname.Text; 
            string phoneNumber = txtphone.Text; 
            string address = txtaddress.Text; 


             
            if (!checkAccount(tk))
            {
                MessageBox.Show("Account names must be 2 to 20 characters long and contain only letters, numbers, underscores, or periods.");
                return;
            }

            if (!checkAccount(mk))
            {
                MessageBox.Show("Password must be 2 to 20 characters long and contain only letters, numbers, underscores, or periods.");
                return;
            }

            if (mk != rmk)
            {
                MessageBox.Show("Confirmation password does not match.");
                return;
            }
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                string checkSql = "SELECT COUNT(*) FROM Login WHERE User_Name = @User_Name";
                using (SqlCommand checkCmd = new SqlCommand(checkSql, con))
                {
                    checkCmd.Parameters.AddWithValue("@User_Name", tk);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Account name already exists. Please choose another name.");
                        return;
                    }
                }

                string insertCustomerSql = "INSERT INTO Customer (Customer_Name, Phone_Number, Address) VALUES (@Customer_Name, @Phone_Number, @Address); SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmdCustomer = new SqlCommand(insertCustomerSql, con))
                {
                    cmdCustomer.Parameters.AddWithValue("@Customer_Name", customerName);
                    cmdCustomer.Parameters.AddWithValue("@Phone_Number", phoneNumber);;
                    cmdCustomer.Parameters.AddWithValue("@Address", address);
                    int customerId = Convert.ToInt32(cmdCustomer.ExecuteScalar());

                    string sql = "INSERT INTO Login (User_Name, Password, Role, Customer_ID) VALUES (@User_Name, @Password, 'Customer', @Customer_ID)";             
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@User_Name", tk);
                        cmd.Parameters.AddWithValue("@Password", mk);
                        cmd.Parameters.AddWithValue("@Customer_ID", customerId); 

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registration successful!");
                    dangnhap dangnhap = new dangnhap();
                    dangnhap.Show();
                    this.Hide();
                }
            }
        }

            private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                dangnhap dangnhap = new dangnhap();
                dangnhap.Show();
                this.Hide();
            }

            private void label1_Click(object sender, EventArgs e)
            {
            }
        
    }
}

