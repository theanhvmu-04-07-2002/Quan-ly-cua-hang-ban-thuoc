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
using Nhom01.DTO;
using Nhom01.DAL;
using Microsoft.VisualBasic;

namespace QuanLyThuoc
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            ConnectSql();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T123VEQ\SQLEXPRESS;Initial Catalog=QLNT;Integrated Security=True");
        private void ConnectSql()
        {
            conn.Open();
            string sql = "select FULLNAME as [Họ và tên],USERNAME as [Tài khoản],SEX as [Giới tính],PERMISION as [Quyền hạn] from User_Use";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dtgvShowUser.DataSource = dt;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void dtgvShowUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dtgvShowUser.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtFullName.Text = row.Cells[0].Value.ToString();
                txtNewUserName.Text = row.Cells[1].Value.ToString();
                
            }
        }

        private void dtgvShowUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvShowUser_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dtgvShowUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (dtgvShowUser.CurrentRow.Cells[2].FormattedValue.Equals("Nam"))
                rdbMale.Checked = true;
            else
                rdbMale.Checked = false;
            if (dtgvShowUser.CurrentRow.Cells[2].FormattedValue.Equals("Nữ"))
                rdbFemale.Checked = true;
            else
                rdbFemale.Checked = false;
            if (dtgvShowUser.CurrentRow.Cells[3].FormattedValue.Equals("1"))
            {
                cbPosition.Text = "Admin";
            }
            else cbPosition.Text = "Nhân viên";
        }
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^^&*";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
           
            string NewUserName = txtNewUserName.Text;
            int length = NewUserName.Length;
            if (length < 5)
            {
                MessageBox.Show("Tên tài khoản phải từ 5 kí tự trở lên!");
                txtNewUserName.Text = "";
            }
            else
            {
                NewUserName = txtNewUserName.Text;
                string name = txtFullName.Text;
                int Position = cbPosition.Text == "Admin" ? 1 : 0;
                string defaultvalue = RandomString(8);
                string sex = "";
                bool ischecked = rdbMale.Checked;
                if (ischecked)
                    sex = rdbMale.Text;
                else
                    sex = rdbFemale.Text;
                if (GUESTDAL.Instance.InserGuest(name, NewUserName, defaultvalue, sex, Position))
                {
                    MessageBox.Show($"Tạo tài khoản mới thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"Mật khẩu của tài khoản: {NewUserName} là: {defaultvalue}");
                } 
                else
                    MessageBox.Show($"Tạo tài khoản mới thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
            }
            
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            string NewUserName = txtNewUserName.Text;
            int length = NewUserName.Length;
            if (length < 5)
            {
                MessageBox.Show("Tên tài khoản phải từ 5 kí tự trở lên!");
                txtNewUserName.Text = "";
            }
            else
            {
                NewUserName = txtNewUserName.Text;
                string name = txtFullName.Text;
                int Position = cbPosition.Text == "Admin" ? 1 : 0;
                string sex = "";
                bool ischecked = rdbMale.Checked;
                if (ischecked)
                    sex = rdbMale.Text;
                else
                    sex = rdbFemale.Text;
                if (GUESTDAL.Instance.UpdateGuest(name, NewUserName, sex, Position))
                {
                    MessageBox.Show($"Sửa thông tin tài khoản ${NewUserName} thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show($"Sửa thông tin tài khoản ${NewUserName} thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();


            }
        }
        void LoadData()
        {
            conn.Open();
            string sql = "select FULLNAME as [Họ và tên],USERNAME as [Tài khoản],SEX as [Giới tính],PERMISION as [Quyền hạn] from User_Use";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dtgvShowUser.DataSource = dt;
        }
        private void btnDelUser_Click(object sender, EventArgs e)
        {
            string name = txtNewUserName.Text;
            if (GUESTDAL.Instance.DelGuest(name))
            {
                MessageBox.Show($"Xóa tài khoản ${name} thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show($"Xóa tài khoản ${name} thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = txtNewUserName.Text;
            if (username == "")
            {
                MessageBox.Show("Vui lòng chọn người dùng cần đổi mật khẩu!");
            }
            else
            {
                GUEST gUEST = GUESTDAL.Instance.getpass(username);
                string passold = gUEST.Password.ToString();
                string defaultvalue = "12345678";
                object repass = "";
                object repass_x2 = "";
                object pass = Interaction.InputBox("Mật khẩu cũ", "Đổi mật khẩu", "");
                if ((string)pass != passold) MessageBox.Show("Mật khẩu không khớp!");
                else if ((string)pass == passold)
                {
                    repass = Interaction.InputBox("Mật khẩu mới", "Đổi mật khẩu", defaultvalue);
                    repass_x2 = Interaction.InputBox("Nhập lại mật khẩu mới", "Đổi mật khẩu", defaultvalue);

                    if ((string)repass_x2 != (string)repass) MessageBox.Show("Mật khẩu không khớp!");
                    else if ((string)repass_x2 == (string)repass)
                    {
                        AccountDAL.Instance.Changepass(txtNewUserName.Text, (string)repass);
                        MessageBox.Show($"Đổi mật khẩu thành công! Mật khẩu mới của bạn là:{repass}");
                    }
                }
               
                if ((string)pass == "" || (string)repass == "" || (string)repass_x2 == "")
                {
                    Interaction.MsgBox($"Mật khẩu của bạn sẽ giữ nguyên!");
                }
               
               
            }
            
               
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            object username = Interaction.InputBox("Nhập vào tên tài khoản", "Lấy mật khẩu", "");
            GUEST gUEST = GUESTDAL.Instance.getpass((string)username);
            if (gUEST != null)
            {
                MessageBox.Show($"Mật khẩu của nhân viên: {(string)username} là: {gUEST.Password}");

            }
            else
                MessageBox.Show("vui lòng điền đúng tên user");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn thoát không ", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                this.Close() ;
            }
        }
    }
}
