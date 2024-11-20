namespace QuanLyThuoc
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.dtgvStatistical = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStatistical)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvStatistical
            // 
            this.dtgvStatistical.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvStatistical.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dtgvStatistical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStatistical.Location = new System.Drawing.Point(6, 130);
            this.dtgvStatistical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvStatistical.Name = "dtgvStatistical";
            this.dtgvStatistical.RowHeadersWidth = 51;
            this.dtgvStatistical.RowTemplate.Height = 29;
            this.dtgvStatistical.Size = new System.Drawing.Size(682, 253);
            this.dtgvStatistical.TabIndex = 2;
            this.dtgvStatistical.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvStatistical_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
            // 
            // btnThoat1
            // 
            this.btnThoat1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat1.BackgroundImage")));
            this.btnThoat1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat1.ForeColor = System.Drawing.Color.White;
            this.btnThoat1.Location = new System.Drawing.Point(581, 401);
            this.btnThoat1.Name = "btnThoat1";
            this.btnThoat1.Size = new System.Drawing.Size(85, 33);
            this.btnThoat1.TabIndex = 4;
            this.btnThoat1.Text = "Thoát";
            this.btnThoat1.UseVisualStyleBackColor = true;
            this.btnThoat1.Click += new System.EventHandler(this.btnThoat1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(412, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "HOÀNG HÀ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(133, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "CỬA HÀNG THUỐC UỐNG ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(197, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "HỆ THỐNG QUẢN LÝ BÁN HÀNG THUỐC";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(700, 473);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoat1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvStatistical);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStatistical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvStatistical;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}