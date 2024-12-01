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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
namespace Hi
{
    public partial class CustomerManagement : Form
    {
        private string userRole;


        public CustomerManagement(string role)
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
        private void Loaddata()
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("SELECT * FROM Customer", sql);
            adt = new SqlDataAdapter(cmd);
            dttb = new DataTable();
            adt.Fill(dttb);
            dtgrcustomer.DataSource = dttb;
        }
        public CustomerManagement()
        {
            InitializeComponent();
            Loaddata();
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {

        }

        private void dtgrcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btedit_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string update = ("update Customer set Customer_ID = @Customer_ID, Customer_Name = @Customer_Name, Phone_Number = @Phone_Number, Address = @Address where Customer_ID = @Customer_ID");
            cmd = new SqlCommand(update, sql);
            cmd.Parameters.AddWithValue("@Customer_ID", txtcode.Text);
            cmd.Parameters.AddWithValue("@Customer_Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Phone_Number", txtphone.Text);
            cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
            cmd.ExecuteNonQuery();
            Loaddata();
            sql.Close();

        }

        private void btadd_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string add = ("Insert into Customer(Customer_ID, Customer_Name, Phone_Number, Address) values(@Customer_ID, @Customer_Name, @Phone_Number, @Address)");
            cmd = new SqlCommand(add, sql);
            cmd.Parameters.AddWithValue("@Customer_ID", txtcode.Text);
            cmd.Parameters.AddWithValue("@Customer_Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Phone_Number", txtphone.Text);
            cmd.Parameters.AddWithValue("@Address", txtaddress.Text);

            //adt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            DataTable dttb = new DataTable();
            //adt.Fill(dttb);
            //dtgrv.DataSource = dttb;
            Loaddata();
        }

        private void btdel_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string dele = ("delete from Customer where Customer_ID = @Customer_ID");
            cmd = new SqlCommand(dele, sql);
            cmd.Parameters.AddWithValue("@Customer_ID", txtcode.Text);
            cmd.ExecuteNonQuery();
            Loaddata();
            sql.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (sql = new SqlConnection(str))
            {
                sql.Open();
                string search = "SELECT * FROM Customer WHERE Customer_ID = @Customer_ID";
                using (cmd = new SqlCommand(search, sql))
                {
                    cmd.Parameters.AddWithValue("@Customer_ID", txtsearch.Text);
                    using (adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dttb = new DataTable();
                        adt.Fill(dttb);

                        // Kiểm tra xem có kết quả nào không
                        if (dttb.Rows.Count > 0)
                        {
                            txtcode.Text = dttb.Rows[0]["Customer_ID"].ToString();
                            txtname.Text = dttb.Rows[0]["Customer_Name"].ToString(); // Cập nhật tên
                            txtphone.Text = dttb.Rows[0]["Phone_Number"].ToString(); // Cập nhật số điện thoại
                            txtaddress.Text = dttb.Rows[0]["Address"].ToString(); // Cập nhật địa chỉ
                        }
                        else
                        {
                            MessageBox.Show("Mã Khách Hàng Này Không Tồn Tại");
                            txtname.Clear(); // Xóa thông tin nếu không tìm thấy
                            txtphone.Clear();
                            txtaddress.Clear();
                        }
                    }
                }
            }
        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
