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
    public partial class product : Form

    {
        private string userRole;         
        public product(string role)
        {
            InitializeComponent();
            userRole = role; 
            SetPermissions(); 
            Loaddata();
        }    
        private void SetPermissions()
        {
            if (userRole == "Director")
            {
                btedit.Visible = true;  
                btdel.Visible = true; 
                btadd.Visible = true; 
            }
            else if (userRole == "Employee")
            {
                btedit.Visible = false; 
                btdel.Visible = false;  
                btadd.Visible = false; 
            }
        }

        string str = @"Data Source=NhinDauBuoi;Initial Catalog=asmlongvu;Integrated Security=True;TrustServerCertificate=True";
        SqlCommand cmd;
        SqlConnection sql;
        SqlDataAdapter adt;
        DataTable dttb;
        public product()
        {
            InitializeComponent();
            Loaddata();
        }


        private void Loaddata()
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Product", sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dtproduct.DataSource = dttb;
            sql.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void product_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sql = new SqlConnection(str))
            {
                if (string.IsNullOrWhiteSpace(txtname.Text) ||
                     string.IsNullOrWhiteSpace(txtPrice.Text) ||
                      string.IsNullOrWhiteSpace(txtavai.Text) ||
                     string.IsNullOrWhiteSpace(txtentry.Text))
                {
                    MessageBox.Show("Cannot be left blank.");
                    sql.Open();
                }
                    string add = "INSERT INTO Product (Product_Name, Price, Available, Entry_price) VALUES (@Product_Name, @Price, @Available, @Entry)";
                using (SqlCommand cmd = new SqlCommand(add, sql))
                {
                    cmd.Parameters.AddWithValue("@Product_Name", txtname.Text);
                    cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@Available", Convert.ToDecimal(txtavai.Text));
                    cmd.Parameters.AddWithValue("@Entry", Convert.ToDecimal(txtentry.Text));

                    cmd.ExecuteNonQuery();
                }

                // Tải lại dữ liệu vào DataTable
                dttb = new DataTable();
                dtproduct.DataSource = dttb;
                Loaddata();
            }

        }

        private void dtproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btedit_Click(object sender, EventArgs e)
        {
            using (sql = new SqlConnection(str))
            {
                sql.Open();
                string edit = "UPDATE Product SET Product_Name = @Product_Name, Price = @Price, Available = @Available, Entry_price = @Entry WHERE Product_ID = @Product_ID";
                cmd = new SqlCommand(edit, sql);
                cmd.Parameters.AddWithValue("@Product_ID", txtid.Text);
                cmd.Parameters.AddWithValue("@Product_Name", txtname.Text);
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@Available", txtavai.Text);
                cmd.Parameters.AddWithValue("@Entry", txtentry.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Product updated successfully.!");
            }
            Loaddata();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void btdel_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string delete = ("delete from Product where Product_ID = @Product_ID");
            cmd = new SqlCommand(delete, sql);
            cmd.Parameters.AddWithValue("@Product_ID", txtid.Text);
            //cmd = new SqlCommand("Select * from Product_mamnagement");
            cmd.ExecuteNonQuery();
            //cmd.ExecuteNonQuery();
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dtproduct.DataSource = dttb;
            Loaddata();
            sql.Close();
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            using (sql = new SqlConnection(str))
            {
                sql.Open();
                string searchQuery = "SELECT * FROM Product WHERE Product_ID = @Product_ID";
                using (cmd = new SqlCommand(searchQuery, sql))
                {
                    cmd.Parameters.AddWithValue("@Product_ID", txtsearch.Text);
                    using (adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dttb = new DataTable();
                        adt.Fill(dttb);

                        if (dttb.Rows.Count > 0)
                        {
                            // Cập nhật các trường thông tin
                            txtid.Text = dttb.Rows[0]["Product_ID"].ToString();
                            txtname.Text = dttb.Rows[0]["Product_Name"].ToString();
                            txtPrice.Text = dttb.Rows[0]["Price"].ToString();
                            txtavai.Text = dttb.Rows[0]["Available"].ToString();
                            txtentry.Text = dttb.Rows[0]["Entry_price"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Product does not exist!");
                        }
                    }
                }
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

