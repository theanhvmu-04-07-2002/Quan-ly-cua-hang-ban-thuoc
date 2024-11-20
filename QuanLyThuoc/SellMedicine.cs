using Microsoft.VisualBasic;
using Nhom01.DAL;
using Nhom01.DTO;
using QuanLyThuoc.DTO;
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
    public partial class SellMedicine : Form
    {
        public SellMedicine()
        {
            InitializeComponent();
            ConnectSql();
            LoadDataToCollection();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T123VEQ\SQLEXPRESS;Initial Catalog=QLNT;Integrated Security=True");
        private void ConnectSql()
        {
            conn.Open();
            string sql = "SELECT ID_MEDICINE as [ID],MEDICINE_NAME as [Tên thuốc],TYPE_MEDICINE as [Loại thuốc],NUMBER_MEDICINE as [Số lượng], DAY_OF_MANUFUTURE_MEDICINE as [Ngày sản xuất],EXPIRATION_DAY_MEDICINE as [Ngày hết hạn],MORE_MEDICINE AS [CÔNG DỤNG THUỐC],PRICE_MEDICINE as [Giá thuốc] from MEDICINE";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dtgvMedicine.DataSource = dt;
        }
        private void LoadDataToCollection()
        {
      AutoCompleteStringCollection auto2 = new AutoCompleteStringCollection();
           
      string strConnection = @"Data Source=DESKTOP-T123VEQ\SQLEXPRESS;Initial Catalog=QLNT;Integrated Security=True";
      SqlConnection conn = new SqlConnection();
      conn.ConnectionString = strConnection;
      SqlCommand cmd = new SqlCommand();
      cmd.Connection = conn;
      cmd.CommandType = CommandType.Text;
 
      string sql = "SELECT MEDICINE.MEDICINE_NAME FROM MEDICINE ";
      SqlCommand com = new SqlCommand();
 
      com.Connection = conn;
      com.CommandText = sql;
      com.CommandType = CommandType.Text;
      conn.Open();
      SqlDataReader reader ;
      reader = com.ExecuteReader();
      if(reader!=null)
      {
             while(reader.Read())
             {
                auto2.Add(reader["MEDICINE_NAME"].ToString());
             }
      }
 
            textBox1.AutoCompleteMode = AutoCompleteMode.Append;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteCustomSource = auto2;
 
 
}
        private void SellMedicine_Load(object sender, EventArgs e)
        {

        }

        private void dtgvMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvMedicine.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtMedicine.Text = row.Cells[1].Value.ToString();
                cbTypeMedicine.Text = row.Cells[2].Value.ToString();
                label9.Text = row.Cells[3].Value.ToString();
                DateOfManufature.Value = Convert.ToDateTime(row.Cells[4].Value);
                DateExpirationDay.Value = Convert.ToDateTime(row.Cells[5].Value);
                txtUsesMedicine.Text = row.Cells[6].Value.ToString();
                label10.Text = row.Cells[7].Value.ToString();

            }
            else
                MessageBox.Show("");
        }
        void loaddata()
        {
            conn.Open();
            string sql = "SELECT ID_MEDICINE as [ID],MEDICINE_NAME as [Tên thuốc],TYPE_MEDICINE as [Loại thuốc],NUMBER_MEDICINE as [Số lượng], DAY_OF_MANUFUTURE_MEDICINE as [Ngày sản xuất],EXPIRATION_DAY_MEDICINE as [Ngày hết hạn],MORE_MEDICINE AS [CÔNG DỤNG THUỐC],PRICE_MEDICINE as [Giá thuốc] from MEDICINE";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dtgvMedicine.DataSource = dt;
        }
        int i { get; set; }
        decimal price { get; set; }
        string bill { get; set; }
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đơn thuốc đã hoàn thành hay chưa?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                foreach (var item in listBox1.Items)
                {
                    bill += item + "\n";
                }
                MessageBox.Show($"Thanh toán thành công!\n Đơn thuốc: \n - {bill} \n giá đơn thuốc là: {price}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listBox1.Items.Clear();
                loaddata();
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "SELECT ID_MEDICINE as [ID],MEDICINE_NAME as [Tên thuốc],TYPE_MEDICINE as [Loại thuốc],NUMBER_MEDICINE as [Số lượng], DAY_OF_MANUFUTURE_MEDICINE as [Ngày sản xuất],EXPIRATION_DAY_MEDICINE as [Ngày hết hạn],MORE_MEDICINE AS [CÔNG DỤNG THUỐC],PRICE_MEDICINE as [Giá thuốc] from MEDICINE WHERE MEDICINE_NAME LIKE N'"+textBox1.Text+"'";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dtgvMedicine.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            int ID = Convert.ToInt32(txtID.Text);
            int numMedicine = Convert.ToInt32(label9.Text);
            if (numMedicine > 0)
            {
                object count = Interaction.InputBox("Số lượng thuốc", "Số lượng", "");
                int ss = Int32.Parse((string)count);
                if (ss < numMedicine)
                {
                    CategoryDAO.Instance.UpdateAfterBuy(ID, numMedicine, ss);
                    System.Object[] ItemObject = new System.Object[100];
                    System.Object[] ItemObjects = new System.Object[100];
                    price += Convert.ToDecimal(label10.Text);
                    ItemObject[i] = txtMedicine.Text;
                    ItemObjects[i] = (string)count;
                    listBox1.Items.AddRange(new object[] { ItemObject[i], ItemObjects[i] });
                    i++;
                }
                else
                {
                    MessageBox.Show("số lượng thuốc không đủ");
                }
                
            }
            else if(numMedicine == 0)
                CategoryDAO.Instance.UpdateAfterBuy(ID, numMedicine);
            loaddata();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn thoát không ", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
