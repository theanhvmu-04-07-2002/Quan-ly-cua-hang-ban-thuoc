using Nhom01.DAL;
using Nhom01.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        bool login(string user, string pass)
        {
            return AccountDAL.Instance.login(user, pass);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string username = txtUser.Text;
            if (txtPass.Text.Length >= 8)
            {
                string password = txtPass.Text;
                if (login(username, password))
                {
                    ACCOUNTDTO acc = AccountDAL.Instance.getusername(username);
                    FormMain lun = new FormMain(acc);
                    this.Hide();
                    lun.ShowDialog();
                }
                else MessageBox.Show("sai tài khoản hoặc mật khẩu");
            }
            else
            {
                MessageBox.Show("sai tài khoản hoặc mật khẩu");
            }
          
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           DialogResult dt= MessageBox.Show("Bạn có muốn thoát không ", " Thông báo ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
               
               this.Close();
            }
        }
    }
}
