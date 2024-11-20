namespace QuanLyThuoc
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnManageAdmin = new System.Windows.Forms.Button();
            this.btnSellMedicine = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangePass = new System.Windows.Forms.LinkLabel();
            this.btnThoat2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManageAdmin
            // 
            this.btnManageAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnManageAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnManageAdmin.Image")));
            this.btnManageAdmin.Location = new System.Drawing.Point(335, 180);
            this.btnManageAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageAdmin.Name = "btnManageAdmin";
            this.btnManageAdmin.Size = new System.Drawing.Size(128, 39);
            this.btnManageAdmin.TabIndex = 0;
            this.btnManageAdmin.Text = "Quản trị người dùng";
            this.btnManageAdmin.UseVisualStyleBackColor = true;
            this.btnManageAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSellMedicine
            // 
            this.btnSellMedicine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSellMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnSellMedicine.Image")));
            this.btnSellMedicine.Location = new System.Drawing.Point(496, 246);
            this.btnSellMedicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSellMedicine.Name = "btnSellMedicine";
            this.btnSellMedicine.Size = new System.Drawing.Size(128, 31);
            this.btnSellMedicine.TabIndex = 1;
            this.btnSellMedicine.Text = "Bán thuốc";
            this.btnSellMedicine.UseVisualStyleBackColor = true;
            this.btnSellMedicine.Click += new System.EventHandler(this.btnSellMedicine_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.Location = new System.Drawing.Point(496, 180);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(128, 39);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Text = "Danh mục";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.Location = new System.Drawing.Point(335, 246);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(126, 31);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(496, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // ChangePass
            // 
            this.ChangePass.AutoSize = true;
            this.ChangePass.BackColor = System.Drawing.Color.Transparent;
            this.ChangePass.Location = new System.Drawing.Point(12, 20);
            this.ChangePass.Name = "ChangePass";
            this.ChangePass.Size = new System.Drawing.Size(83, 15);
            this.ChangePass.TabIndex = 14;
            this.ChangePass.TabStop = true;
            this.ChangePass.Text = "Đổi mật khẩu?";
            this.ChangePass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangePass_LinkClicked);
            // 
            // btnThoat2
            // 
            this.btnThoat2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThoat2.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat2.Image")));
            this.btnThoat2.Location = new System.Drawing.Point(440, 338);
            this.btnThoat2.Name = "btnThoat2";
            this.btnThoat2.Size = new System.Drawing.Size(75, 23);
            this.btnThoat2.TabIndex = 15;
            this.btnThoat2.Text = "Thoát";
            this.btnThoat2.UseVisualStyleBackColor = true;
            this.btnThoat2.Click += new System.EventHandler(this.btnThoat2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Địa chỉ : Số 35 , Động Thăng Thiên , Hà Nội , Việt Nam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(13, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Hotline : 0857526184";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(13, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 30);
            this.label7.TabIndex = 21;
            this.label7.Text = "Giấy phép kinh doanh số : 13KDHT \r\n         do Bộ Y tế cấp ngày 18.02.2012\r\n";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(13, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Emai: hienhoa.thuocuong@gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(384, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "HOÀNG HÀ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(105, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "CỬA HÀNG THUỐC UỐNG ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(169, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "HỆ THỐNG QUẢN LÝ BÁN HÀNG THUỐC";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(700, 388);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThoat2);
            this.Controls.Add(this.ChangePass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnSellMedicine);
            this.Controls.Add(this.btnManageAdmin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageAdmin;
        private System.Windows.Forms.Button btnSellMedicine;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel ChangePass;
        private System.Windows.Forms.Button btnThoat2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}