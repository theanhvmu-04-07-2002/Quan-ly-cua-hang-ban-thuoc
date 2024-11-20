using Nhom01.DAL;
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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            ConnectSql();
            loadcbtype(cbTypeMedicine);
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
        void loadcbtype(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.LoadCategory();
            cb.DisplayMember = "TYPE_MEDICINE";
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {

        }

        private void dtgvMedicine_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dtgvMedicine.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtMedicine.Text = row.Cells[1].Value.ToString();
                cbTypeMedicine.Text = row.Cells[2].Value.ToString();
                numQuanityMedicine.Value = Convert.ToInt32(row.Cells[3].Value);
                DateOfManufature.Value = Convert.ToDateTime(row.Cells[4].Value);
                DateExpirationDay.Value = Convert.ToDateTime(row.Cells[5].Value);
                txtUsesMedicine.Text = row.Cells[6].Value.ToString();
                NumPriceMedicine.Value = Convert.ToDecimal(row.Cells[7].Value);

            }
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
        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            // string ID,string name,string type,int numMedicine,DateTime dateofmanufuture,DateTime dateexpirationDay, string more,int numprice
            string ID = txtID.Text;
            string name = txtMedicine.Text;
            string type = cbTypeMedicine.Text;
            int numMedicine = (int)numQuanityMedicine.Value;
            DateTime dateofmanufuture = DateOfManufature.Value;
            DateTime dateexpirationDay = DateExpirationDay.Value;
            string more = txtUsesMedicine.Text;
            int numprice = (int)NumPriceMedicine.Value;
            if (CategoryDAO.Instance.InserCategory(name, type, numMedicine, dateofmanufuture, dateexpirationDay, numprice, more))
            {

                MessageBox.Show($"Tạo sản phẩm mới thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();
                loadcbtype(cbTypeMedicine);
            }
            else
                MessageBox.Show($"Tạo tài khoản mới thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditMedicine_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtID.Text);
            string name = txtMedicine.Text;
            string type = cbTypeMedicine.Text;
            int numMedicine = (int)numQuanityMedicine.Value;
            DateTime dateofmanufuture = DateOfManufature.Value;
            DateTime dateexpirationDay = DateExpirationDay.Value;
            string more = txtUsesMedicine.Text;
            int numprice = (int)NumPriceMedicine.Value;
            if (CategoryDAO.Instance.UpdateCategory(ID, name, type, numMedicine, dateofmanufuture, dateexpirationDay, numprice, more))
            {

                MessageBox.Show($"Sửa sản phẩm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();
                loadcbtype(cbTypeMedicine);
            }
            else
                MessageBox.Show($"Sửa sản phẩm thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelMedicine_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtID.Text);
            if (CategoryDAO.Instance.DelCategory(ID))
            {
                MessageBox.Show($"Xóa sản phẩm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();
                loadcbtype(cbTypeMedicine);
            }
            else
                MessageBox.Show($"Xóa sản phẩm thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat3_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn thoát không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if( dt == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
