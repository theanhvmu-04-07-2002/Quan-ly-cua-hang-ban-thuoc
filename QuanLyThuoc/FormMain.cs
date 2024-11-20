using Microsoft.VisualBasic;
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
    public partial class FormMain : Form
    {
        private ACCOUNTDTO user;

        public ACCOUNTDTO User
        {
            get => user;
            set
            { user = value; access(user.Access); }

        }
        public FormMain(ACCOUNTDTO acc)
        {
            InitializeComponent();
            this.User = acc;
            label1.Text = "Xin chào! " + acc.Username;
        }
        void access(int type)
        {
            btnManageAdmin.Enabled = type == 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            User us = new User();
            us.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.ShowDialog();
        }

        private void btnSellMedicine_Click(object sender, EventArgs e)
        {
            SellMedicine sell = new SellMedicine();
            sell.ShowDialog();
        }

        private void ChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = user.Username;
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
                        AccountDAL.Instance.Changepass(user.Username, (string)repass);
                        MessageBox.Show($"Đổi mật khẩu thành công! Mật khẩu mới của bạn là:{repass}");
                    }
                }

                if ((string)pass == "" || (string)repass == "" || (string)repass_x2 == "")
                {
                    Interaction.MsgBox($"Mật khẩu của bạn sẽ giữ nguyên!");
                }


            }
        }

        private void btnThoat2_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn thoát không ", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
