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
    using static Hi.dangnhap;

    namespace Hi
    {

        public partial class Sale : Form
        {
            string str = @"Data Source=NhinDauBuoi;Initial Catalog=asmlongvu;Integrated Security=True;TrustServerCertificate=True";
            SqlCommand cmd;
            SqlConnection sql;
            SqlDataAdapter adt;
            DataTable dttb;
            public static int currentCustomerID= 0;  // Biến toàn cục lưu Customer_ID của người dùng đăng nhập

            public Sale()
            {
                InitializeComponent();
                Loaddata();
                LoadProductsToComboBox();
            }
            private void Loaddata()
            {

               
                
                using (sql = new SqlConnection(str))
                {
                    sql.Open();
                    cmd = new SqlCommand("SELECT Sale_ID, Product_ID, Customer_ID, Sale_Date, Quantity_Sold FROM Sale WHERE Customer_ID = @Customer_ID", sql);
                    cmd.Parameters.AddWithValue("@Customer_ID", UserSession.CurrentCustomerID);
                    adt = new SqlDataAdapter(cmd);
                    dttb = new DataTable();
                    adt.Fill(dttb);
                    datasale1.DataSource = dttb;

                    if (UserSession.CurrentCustomerID != 0)
                    {
                        lblCustomerID.Text = UserSession.CurrentCustomerID.ToString(); // Giả sử có một Label để hiển thị
                    }
                }
            }

            private void btadd_Click(object sender, EventArgs e)
            {
            if (UserSession.CurrentCustomerID == 0)
            {
                MessageBox.Show("Unable to write data. Invalid Customer_ID.");
                return;
            }

            if (cmbProduct.SelectedValue == null || string.IsNullOrWhiteSpace(txtqua.Text))
            {
                MessageBox.Show("Please select product and enter quantity.");
                return;
            }

            using (sql = new SqlConnection(str))
            {
                sql.Open();
                string insertQuery = "INSERT INTO Sale (Product_ID, Customer_ID, Sale_Date, Quantity_Sold) VALUES (@Product_ID, @Customer_ID, @Sale_Date, @Quantity_Sold)";
                using (cmd = new SqlCommand(insertQuery, sql))
                {
                    cmd.Parameters.AddWithValue("@Product_ID", cmbProduct.SelectedValue);
                    cmd.Parameters.AddWithValue("@Sale_Date", date.Value);
                    cmd.Parameters.AddWithValue("@Quantity_Sold", int.Parse(txtqua.Text));
                    cmd.Parameters.AddWithValue("@Customer_ID", UserSession.CurrentCustomerID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sale recorded successfully.");
                    Loaddata(); // Tải lại dữ liệu
                }
            }
        
            }
            private void LoadProductsToComboBox()
            {
                using (SqlConnection sql = new SqlConnection(str))
                {
                    sql.Open();
                    string query = "SELECT Product_ID FROM [asmlongvu].[dbo].[Product]";

                    using (SqlCommand cmd = new SqlCommand(query, sql))
                    {
                        using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                        {
                            DataTable dtProducts = new DataTable();
                            adt.Fill(dtProducts);

                            if (dtProducts.Rows.Count > 0)
                            {
                                cmbProduct.ValueMember = "Product_ID"; 
                                cmbProduct.DataSource = dtProducts; 
                            }
                            else
                            {
                                MessageBox.Show("No products found to display.");
                            }
                        }
                    }
                }
            }
            private void btedit_Click(object sender, EventArgs e)
            {

            }

            private void btdel_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(textid.Text))
                {
                    MessageBox.Show("Please enter a Sale ID to delete.");
                    return;
                }

                using (sql = new SqlConnection(str))
                {
                    sql.Open();
                    string deleteQuery = "DELETE FROM Sale WHERE Sale_ID = @Sale_ID";
                    using (cmd = new SqlCommand(deleteQuery, sql))
                    {
                        cmd.Parameters.AddWithValue("@Sale_ID", int.Parse(textid.Text)); 
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sale deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No sale found with the provided Sale ID.");
                        }
                    }
                }

                Loaddata(); 
            }

            private void txtqua_TextChanged(object sender, EventArgs e)
            {

            }



            private void txtid_TextChanged(object sender, EventArgs e)
            {

            }

            private void HiLoaddata()
            {
                sql = new SqlConnection(str);
                sql.Open();
                cmd = new SqlCommand("Select Product_ID, Product_Name, Price from Product ", sql);
                adt = new SqlDataAdapter(cmd);
                DataTable dttb = new DataTable();
                adt.Fill(dttb);
                dtsale.DataSource = dttb;
                sql.Close();
            }
            private void dtsale_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                HiLoaddata();
            }

            private void Sale_Load(object sender, EventArgs e)
            {
                HiLoaddata();
                Loaddata();
            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void date_ValueChanged(object sender, EventArgs e)
            {

            }

            private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
        }
    }
