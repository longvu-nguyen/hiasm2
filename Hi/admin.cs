using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

namespace Hi
{
    public partial class admin : Form
    {
        string str = @"Data Source=NhinDauBuoi;Initial Catalog=asmlongvu;Integrated Security=True;TrustServerCertificate=True";
        SqlCommand cmd;
        SqlConnection sql;
        SqlDataAdapter adt;
        DataTable dttb;
        private void Loaddata()
        {

            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Login", sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            //dtgradmin.DataSource = dttb;
            sql.Close();
            dttb = new DataTable();
        }

        public admin()

        {
            InitializeComponent();
            Loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string User_Name = txtuser.Text.Trim();
            string Password = txtpass.Text.Trim();
            string Position = cbpos.SelectedItem?.ToString();  
            if (string.IsNullOrEmpty(User_Name) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Position))
            {
                MessageBox.Show("Please enter username and password and role.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                string sql = "SELECT * From Login WHERE User_Name = @User_Name AND Password = @Password AND Role = @Role";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@User_Name", User_Name);
                    cmd.Parameters.AddWithValue("@Password", Password); 
                    cmd.Parameters.AddWithValue("@Role", Position);
                    using (SqlDataReader dta = cmd.ExecuteReader())
                    {
                        if (dta.Read())
                        {
                            MessageBox.Show("Login Successfully");
                            Loadadmindata();
                            btedit.Visible = true;
                            btdel.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Login Failed");
                      
                            btedit.Visible = false;
                            btdel.Visible = false;
                        }
                    }
                }
            }
        }
        private void Loadadmindata()
        {


            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Login", sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dtgradmin.DataSource = dttb;
            sql.Close();
            dttb = new DataTable();

        }






        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra đầu vào
            if (string.IsNullOrEmpty(txtuser.Text) || string.IsNullOrEmpty(txtpass.Text))
            {
                MessageBox.Show("Please enter username and password and role.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedRole = cbpos.SelectedItem?.ToString();
            using (SqlConnection sql = new SqlConnection(str))
            {
                sql.Open();
                // Câu lệnh SQL để cập nhật thông tin người dùng
                string edit = "UPDATE Login SET Password = @Password, Role = @Role WHERE User_Name = @User_Name";
                using (SqlCommand cmd = new SqlCommand(edit, sql))
                {
                    cmd.Parameters.AddWithValue("@User_Name", txtuser.Text);
                    cmd.Parameters.AddWithValue("@Password", txtpass.Text); // Nên băm mật khẩu trước
                    cmd.Parameters.AddWithValue("@Role", selectedRole);
                    // Thực hiện câu lệnh
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Kiểm tra xem có bản ghi nào được cập nhật không
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Update successful!");

                    }
                    else
                    {
                        MessageBox.Show("No user found with the given login name.");
                    }
                }
            }

            Loadadmindata(); 
        }


        private void btsave_Click(object sender, EventArgs e)
        {


        }

        private void btdel_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txtuser.Text))
                {
                    MessageBox.Show("Please enter username to delete.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection sql = new SqlConnection(str))
                {
                    sql.Open();
                    string deleteSql = "DELETE FROM Login WHERE User_Name = @User_Name";
                    using (SqlCommand cmd = new SqlCommand(deleteSql, sql))
                    {
                        cmd.Parameters.AddWithValue("@User_Name", txtuser.Text);

                        // Thực hiện câu lệnh
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Kiểm tra xem có bản ghi nào bị xóa không
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Delete successful!");
                        }
                        else
                        {
                            MessageBox.Show("No user found with the given login name.");
                        }
                    }
                }

                Loadadmindata();  
            }
        }

        private void cbpos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


