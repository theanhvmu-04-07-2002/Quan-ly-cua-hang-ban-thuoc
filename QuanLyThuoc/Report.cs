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

namespace QuanLyThuoc
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            ConnectSql();
            label1.Text = "Thống kê Số lượng thuốc đã nhập";
            
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T123VEQ\SQLEXPRESS;Initial Catalog=QLNT;Integrated Security=True");
        private void ConnectSql()
        {
            conn.Open();
            string sql = @"SELECT MEDICINE_NAME as [Tên thuốc],SUM(NUMBER_MEDICINE) AS [Tổng Số lượng]
            FROM MEDICINE
            GROUP BY MEDICINE_NAME
            ORDER BY SUM(NUMBER_MEDICINE);";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dtgvStatistical.DataSource = dt;
        }
        private void btnStatistical_Click(object sender, EventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat1_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn thoát không ", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                this.Close();
            }  
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtgvStatistical_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
