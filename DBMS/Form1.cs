using System.Data.SqlClient; // Thư viện cũ quá để làm việc 
using Microsoft.Data.SqlClient; // Thư viện mới để làm việc với SQL Server
// Khai báo thư viện để kết nối với cơ sở dữ liệu SQL Server

using System.Data; // Thư viện để làm việc với dữ liệu và các đối tượng liên quan đến cơ sở dữ liệu

namespace DBMS
{
    public partial class Form1 : Form
    {
        String strCon = @"Data Source=DESKTOP-LPF0IL9;Initial Catalog=Test;Integrated Security=True;Trust Server Certificate=True";
        // Chuỗi kết nối đến cơ sở dữ liệu SQL Server - như địa chỉ máy chủ, tên cơ sở dữ liệu, thông tin xác thực, v.v.
        SqlConnection sqlCon = null;
        // Đối tượng SqlConnection để quản lý kết nối đến cơ sở dữ liệu

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpeConnect_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon = new SqlConnection(strCon);
                // Tạo đối tượng SqlConnection để kết nối đế Cở Sở Dữ Liệu SQL Server

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    MessageBox.Show("Kết nối thành công");
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có ngoại lệ xảy ra
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCloseConnect_Click(object sender, EventArgs e)
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
                MessageBox.Show("Đã đóng kết nối ");
            } else
            {
                MessageBox.Show("Chưa kết nối hoặc kết nối đã đóng");
            }
        }
    }
}
