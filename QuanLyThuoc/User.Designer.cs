namespace QuanLyThuoc
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.dtgvShowUser = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChangePass = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvShowUser
            // 
            this.dtgvShowUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvShowUser.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dtgvShowUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dtgvShowUser, "dtgvShowUser");
            this.dtgvShowUser.Name = "dtgvShowUser";
            this.dtgvShowUser.RowTemplate.Height = 29;
            this.dtgvShowUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvShowUser_CellClick);
            this.dtgvShowUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvShowUser_CellContentClick);
            this.dtgvShowUser.DoubleClick += new System.EventHandler(this.dtgvShowUser_DoubleClick);
            this.dtgvShowUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvShowUser_MouseClick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFullName
            // 
            resources.ApplyResources(this.txtFullName, "txtFullName");
            this.txtFullName.Name = "txtFullName";
            // 
            // btnAddNewUser
            // 
            resources.ApplyResources(this.btnAddNewUser, "btnAddNewUser");
            this.btnAddNewUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // rdbMale
            // 
            resources.ApplyResources(this.rdbMale, "rdbMale");
            this.rdbMale.BackColor = System.Drawing.Color.Transparent;
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.TabStop = true;
            this.rdbMale.UseVisualStyleBackColor = false;
            // 
            // btnEditUser
            // 
            resources.ApplyResources(this.btnEditUser, "btnEditUser");
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnDelUser
            // 
            resources.ApplyResources(this.btnDelUser, "btnDelUser");
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.UseVisualStyleBackColor = true;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            resources.GetString("cbPosition.Items"),
            resources.GetString("cbPosition.Items1")});
            resources.ApplyResources(this.cbPosition, "cbPosition");
            this.cbPosition.Name = "cbPosition";
            // 
            // rdbFemale
            // 
            resources.ApplyResources(this.rdbFemale, "rdbFemale");
            this.rdbFemale.BackColor = System.Drawing.Color.Transparent;
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.TabStop = true;
            this.rdbFemale.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // txtNewUserName
            // 
            resources.ApplyResources(this.txtNewUserName, "txtNewUserName");
            this.txtNewUserName.Name = "txtNewUserName";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // ChangePass
            // 
            resources.ApplyResources(this.ChangePass, "ChangePass");
            this.ChangePass.BackColor = System.Drawing.Color.Transparent;
            this.ChangePass.LinkColor = System.Drawing.Color.Green;
            this.ChangePass.Name = "ChangePass";
            this.ChangePass.TabStop = true;
            this.ChangePass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangePass_LinkClicked);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.Green;
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Name = "label7";
            // 
            // User
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ChangePass);
            this.Controls.Add(this.txtNewUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbFemale);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.rdbMale);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvShowUser);
            this.Name = "User";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvShowUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel ChangePass;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}