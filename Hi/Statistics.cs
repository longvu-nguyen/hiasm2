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
        public partial class Statistics : Form
        {
             string str = @"Data Source=NhinDauBuoi;Initial Catalog=asmlongvu;Integrated Security=True;TrustServerCertificate=True";
            SqlCommand cmd;
            SqlConnection sql;
            SqlDataAdapter adt;
            DataTable dttb;
            public Statistics()
            {
           
                InitializeComponent();
            }

            private void LoadData(DateTime startDate, DateTime endDate)
            {
                // Kết nối SQL
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();

                    // Câu truy vấn SQL
                    string query = @"
                            SELECT 
                                p.Product_ID,
                                p.Product_Name,
                                SUM(s.Quantity_Sold) AS Total_Quantity_Sold,
                                SUM(s.Quantity_Sold * p.Price) AS Total_Revenue,
                                SUM(s.Quantity_Sold * p.Entry_price) AS Total_Cost,
                                SUM(s.Quantity_Sold * (p.Price - p.Entry_price)) AS Profit
                            FROM 
                                [dbo].[Sale] s
                            JOIN 
                                [dbo].[Product] p ON s.Product_ID = p.Product_ID
                            WHERE 
                                s.Sale_Date BETWEEN @StartDate AND @EndDate
                            GROUP BY 
                                p.Product_ID, p.Product_Name
                            ORDER BY 
                                Profit DESC";

                    // Thực hiện câu lệnh SQL với tham số
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StartDate", datestart.Value);
                        cmd.Parameters.AddWithValue("@EndDate", dateend.Value);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Hiển thị kết quả lên DataGridView
                        datasta.DataSource = dt;
                    }

                    conn.Close();
                }
            }
    
        



            private void Statistics_Load(object sender, EventArgs e)
            {
                // Thiết lập mặc định cho DateTimePicker (nếu cần)
                datestart.Value = DateTime.Now.AddDays(-7); // Mặc định chọn 7 ngày trước
                dateend.Value = DateTime.Now;              // Đến ngày hôm nay
            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {

            }

            private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void btnCalculate_Click(object sender, EventArgs e)
        
            {
                DateTime startDate = datestart.Value;
                DateTime endDate = dateend.Value;

                // Gọi hàm tải dữ liệu với tham số ngày bắt đầu và ngày kết thúc
                LoadData(startDate, endDate);

            }
        

        }
    }


