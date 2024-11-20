namespace QuanLyThuoc
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.txtMedicine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.DateOfManufature = new System.Windows.Forms.DateTimePicker();
            this.btnEditMedicine = new System.Windows.Forms.Button();
            this.btnDelMedicine = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsesMedicine = new System.Windows.Forms.TextBox();
            this.cbTypeMedicine = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DateExpirationDay = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.numQuanityMedicine = new System.Windows.Forms.NumericUpDown();
            this.NumPriceMedicine = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtgvMedicine = new System.Windows.Forms.DataGridView();
            this.btnThoat3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuanityMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPriceMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMedicine
            // 
            this.txtMedicine.BackColor = System.Drawing.Color.White;
            this.txtMedicine.Location = new System.Drawing.Point(140, 112);
            this.txtMedicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.Size = new System.Drawing.Size(219, 22);
            this.txtMedicine.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(46, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên thuốc";
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddMedicine.BackgroundImage")));
            this.btnAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddMedicine.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMedicine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMedicine.Image")));
            this.btnAddMedicine.Location = new System.Drawing.Point(833, 112);
            this.btnAddMedicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(82, 26);
            this.btnAddMedicine.TabIndex = 2;
            this.btnAddMedicine.Text = "Thêm";
            this.btnAddMedicine.UseVisualStyleBackColor = true;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // DateOfManufature
            // 
            this.DateOfManufature.CalendarForeColor = System.Drawing.Color.PapayaWhip;
            this.DateOfManufature.CalendarMonthBackground = System.Drawing.Color.PapayaWhip;
            this.DateOfManufature.CalendarTitleBackColor = System.Drawing.Color.PapayaWhip;
            this.DateOfManufature.CalendarTitleForeColor = System.Drawing.Color.PapayaWhip;
            this.DateOfManufature.CalendarTrailingForeColor = System.Drawing.Color.PapayaWhip;
            this.DateOfManufature.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfManufature.Location = new System.Drawing.Point(140, 252);
            this.DateOfManufature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateOfManufature.Name = "DateOfManufature";
            this.DateOfManufature.Size = new System.Drawing.Size(219, 22);
            this.DateOfManufature.TabIndex = 3;
            // 
            // btnEditMedicine
            // 
            this.btnEditMedicine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditMedicine.BackgroundImage")));
            this.btnEditMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditMedicine.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditMedicine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnEditMedicine.Image")));
            this.btnEditMedicine.Location = new System.Drawing.Point(833, 159);
            this.btnEditMedicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditMedicine.Name = "btnEditMedicine";
            this.btnEditMedicine.Size = new System.Drawing.Size(82, 30);
            this.btnEditMedicine.TabIndex = 5;
            this.btnEditMedicine.Text = "Sửa";
            this.btnEditMedicine.UseVisualStyleBackColor = true;
            this.btnEditMedicine.Click += new System.EventHandler(this.btnEditMedicine_Click);
            // 
            // btnDelMedicine
            // 
            this.btnDelMedicine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelMedicine.BackgroundImage")));
            this.btnDelMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelMedicine.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelMedicine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnDelMedicine.Image")));
            this.btnDelMedicine.Location = new System.Drawing.Point(834, 211);
            this.btnDelMedicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelMedicine.Name = "btnDelMedicine";
            this.btnDelMedicine.Size = new System.Drawing.Size(82, 27);
            this.btnDelMedicine.TabIndex = 6;
            this.btnDelMedicine.Text = "Xóa";
            this.btnDelMedicine.UseVisualStyleBackColor = true;
            this.btnDelMedicine.Click += new System.EventHandler(this.btnDelMedicine_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(46, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Phân Loại";
            // 
            // txtUsesMedicine
            // 
            this.txtUsesMedicine.BackColor = System.Drawing.Color.White;
            this.txtUsesMedicine.Location = new System.Drawing.Point(577, 211);
            this.txtUsesMedicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsesMedicine.Multiline = true;
            this.txtUsesMedicine.Name = "txtUsesMedicine";
            this.txtUsesMedicine.Size = new System.Drawing.Size(219, 59);
            this.txtUsesMedicine.TabIndex = 7;
            // 
            // cbTypeMedicine
            // 
            this.cbTypeMedicine.BackColor = System.Drawing.Color.White;
            this.cbTypeMedicine.FormattingEnabled = true;
            this.cbTypeMedicine.Location = new System.Drawing.Point(140, 160);
            this.cbTypeMedicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTypeMedicine.Name = "cbTypeMedicine";
            this.cbTypeMedicine.Size = new System.Drawing.Size(133, 21);
            this.cbTypeMedicine.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(46, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(46, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày sản xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(469, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ngày hết hạn";
            // 
            // DateExpirationDay
            // 
            this.DateExpirationDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateExpirationDay.Location = new System.Drawing.Point(577, 112);
            this.DateExpirationDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateExpirationDay.Name = "DateExpirationDay";
            this.DateExpirationDay.Size = new System.Drawing.Size(219, 22);
            this.DateExpirationDay.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(469, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Giá tiền";
            // 
            // numQuanityMedicine
            // 
            this.numQuanityMedicine.Location = new System.Drawing.Point(140, 211);
            this.numQuanityMedicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numQuanityMedicine.Name = "numQuanityMedicine";
            this.numQuanityMedicine.Size = new System.Drawing.Size(52, 22);
            this.numQuanityMedicine.TabIndex = 17;
            // 
            // NumPriceMedicine
            // 
            this.NumPriceMedicine.BackColor = System.Drawing.Color.White;
            this.NumPriceMedicine.Location = new System.Drawing.Point(577, 166);
            this.NumPriceMedicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumPriceMedicine.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.NumPriceMedicine.Name = "NumPriceMedicine";
            this.NumPriceMedicine.Size = new System.Drawing.Size(137, 22);
            this.NumPriceMedicine.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(469, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Công dụng\r\n";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(10, 352);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(9, 7);
            this.txtID.TabIndex = 20;
            // 
            // dtgvMedicine
            // 
            this.dtgvMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMedicine.BackgroundColor = System.Drawing.Color.MintCream;
            this.dtgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMedicine.Location = new System.Drawing.Point(25, 313);
            this.dtgvMedicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvMedicine.Name = "dtgvMedicine";
            this.dtgvMedicine.RowHeadersWidth = 51;
            this.dtgvMedicine.RowTemplate.Height = 29;
            this.dtgvMedicine.Size = new System.Drawing.Size(912, 288);
            this.dtgvMedicine.TabIndex = 21;
            this.dtgvMedicine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMedicine_CellClick_1);
            // 
            // btnThoat3
            // 
            this.btnThoat3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat3.BackgroundImage")));
            this.btnThoat3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat3.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat3.Location = new System.Drawing.Point(833, 255);
            this.btnThoat3.Name = "btnThoat3";
            this.btnThoat3.Size = new System.Drawing.Size(83, 33);
            this.btnThoat3.TabIndex = 22;
            this.btnThoat3.Text = "Thoát";
            this.btnThoat3.UseVisualStyleBackColor = true;
            this.btnThoat3.Click += new System.EventHandler(this.btnThoat3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(512, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "HOÀNG HÀ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(233, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(286, 24);
            this.label9.TabIndex = 26;
            this.label9.Text = "CỬA HÀNG THUỐC UỐNG ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(297, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(296, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "HỆ THỐNG QUẢN LÝ BÁN HÀNG THUỐC";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(961, 634);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnThoat3);
            this.Controls.Add(this.dtgvMedicine);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumPriceMedicine);
            this.Controls.Add(this.numQuanityMedicine);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DateExpirationDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTypeMedicine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsesMedicine);
            this.Controls.Add(this.btnDelMedicine);
            this.Controls.Add(this.btnEditMedicine);
            this.Controls.Add(this.DateOfManufature);
            this.Controls.Add(this.btnAddMedicine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMedicine);
            this.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục thuốc";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuanityMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPriceMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMedicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.DateTimePicker DateOfManufature;
        private System.Windows.Forms.Button btnEditMedicine;
        private System.Windows.Forms.Button btnDelMedicine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsesMedicine;
        private System.Windows.Forms.ComboBox cbTypeMedicine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateExpirationDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numQuanityMedicine;
        private System.Windows.Forms.NumericUpDown NumPriceMedicine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dtgvMedicine;
        private System.Windows.Forms.Button btnThoat3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}