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
namespace Hi
{
    public partial class EmployeeManagement : Form
    {
        private string userRole;  

       
        public EmployeeManagement(string role)
        {
            InitializeComponent();
            userRole = role;  
            SetPermissions();  
            Loaddata();
        }

       
        private void SetPermissions()
        {
            if (userRole == "Admin")
            {
                btadd.Visible = true;   
                btedit.Visible = true;   
                btdel.Visible = true;   
            }
            else if (userRole == "Employee")
            {
                btadd.Visible = false;   
                btedit.Visible = false;  
                btdel.Visible = false;   
            }
        }

        string str = @"Data Source=NhinDauBuoi;Initial Catalog=asmlongvu;Integrated Security=True;TrustServerCertificate=True";
        SqlCommand cmd;
        SqlConnection sql;
        SqlDataAdapter adt;
        DataTable dttb;
        public EmployeeManagement()
        {
            InitializeComponent();
            Loaddata();
        }
        private void Loaddata()
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Employee", sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dtgremployee.DataSource = dttb;
            sql.Close();
            dttb = new DataTable();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtcheck_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btadd_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string add = ("Insert into Employee(Employee_ID, Employee_Name, Position, Authority, Phone) values(@Employee_ID, @Employee_Name, @Position, @Authority, @phone)");
            cmd = new SqlCommand(add, sql);
            cmd.Parameters.AddWithValue("@Employee_ID", txtcode.Text);
            cmd.Parameters.AddWithValue("@Employee_name", txtname.Text);
            cmd.Parameters.AddWithValue("@Position", cbposi.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Authority", txtau.Text);
            cmd.Parameters.AddWithValue("@phone", txtphone.Text);
            cmd.ExecuteNonQuery();
            adt = new SqlDataAdapter(cmd);
            Loaddata();
            sql.Close();
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            using (sql = new SqlConnection(str))
            {
                sql.Open();

                string edit = ("UPDATE Employee SET Employee_Name = @Employee_Name, Position = @Position, Authority = @Authority, Phone = @Phone WHERE Employee_ID = @Employee_ID");
                cmd = new SqlCommand(edit, sql);
                cmd.Parameters.AddWithValue("@Employee_ID", txtcode.Text);
                cmd.Parameters.AddWithValue("@Employee_Name", txtname.Text);
                cmd.Parameters.AddWithValue("@Position", cbposi.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Authority", txtau.Text);
                cmd.Parameters.AddWithValue("@Phone", txtphone.Text);

                cmd.ExecuteNonQuery();
            }
            Loaddata();



        }

        private void btdel_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string delete = ("delete from Employee where Employee_ID = @Employee_ID");
            cmd = new SqlCommand(delete, sql);
            cmd.Parameters.AddWithValue("@Employee_ID", txtcode.Text);
            //cmd = new SqlCommand("Select * from Product_mamnagement");
            cmd.ExecuteNonQuery();
            //cmd.ExecuteNonQuery();
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dtgremployee.DataSource = dttb;
            Loaddata();
            sql.Close();
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            using (sql = new SqlConnection(str))
            {
                sql.Open();
                string searchQuery = "SELECT * FROM Employee WHERE Employee_ID = @Employee_ID";
                using (cmd = new SqlCommand(searchQuery, sql))
                {
                    cmd.Parameters.AddWithValue("@Employee_ID", txtsearch.Text);
                    using (adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dttb = new DataTable();
                        adt.Fill(dttb);

                        if (dttb.Rows.Count > 0)
                        {
                            // Cập nhật các trường thông tin
                            txtcode.Text = dttb.Rows[0]["Employee_ID"].ToString();
                            txtname.Text = dttb.Rows[0]["Employee_Name"].ToString();
                            cbposi.SelectedItem = dttb.Rows[0]["Position"].ToString();
                            txtau.Text = dttb.Rows[0]["Authority"].ToString();
                            txtphone.Text = dttb.Rows[0]["Phone"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Employee does not exist!");

                        }
                    }
                }
            }
        }

        private void cbposi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

