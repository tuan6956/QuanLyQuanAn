namespace QuanLyQuanAn
{
    partial class frmMain
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageQuanLy = new System.Windows.Forms.TabPage();
            this.grbThemChiTieu = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTypeFood = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimeClose = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimeOpen = new System.Windows.Forms.TextBox();
            this.btnAddorEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameRestaurant = new System.Windows.Forms.TextBox();
            this.grvQuanLy = new System.Windows.Forms.DataGridView();
            this.pageDataBase = new System.Windows.Forms.TabPage();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnTestConnect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSvName = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.pageQuanLy.SuspendLayout();
            this.grbThemChiTieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvQuanLy)).BeginInit();
            this.pageDataBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageQuanLy);
            this.tabControl.Controls.Add(this.pageDataBase);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(877, 480);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            // 
            // pageQuanLy
            // 
            this.pageQuanLy.Controls.Add(this.grbThemChiTieu);
            this.pageQuanLy.Controls.Add(this.grvQuanLy);
            this.pageQuanLy.Location = new System.Drawing.Point(4, 25);
            this.pageQuanLy.Name = "pageQuanLy";
            this.pageQuanLy.Padding = new System.Windows.Forms.Padding(3);
            this.pageQuanLy.Size = new System.Drawing.Size(869, 451);
            this.pageQuanLy.TabIndex = 0;
            this.pageQuanLy.Text = "Quản lý";
            this.pageQuanLy.UseVisualStyleBackColor = true;
            // 
            // grbThemChiTieu
            // 
            this.grbThemChiTieu.BackColor = System.Drawing.Color.Transparent;
            this.grbThemChiTieu.Controls.Add(this.txtID);
            this.grbThemChiTieu.Controls.Add(this.label10);
            this.grbThemChiTieu.Controls.Add(this.txtPhone);
            this.grbThemChiTieu.Controls.Add(this.label9);
            this.grbThemChiTieu.Controls.Add(this.txtAddress);
            this.grbThemChiTieu.Controls.Add(this.label8);
            this.grbThemChiTieu.Controls.Add(this.txtTypeFood);
            this.grbThemChiTieu.Controls.Add(this.label2);
            this.grbThemChiTieu.Controls.Add(this.txtTimeClose);
            this.grbThemChiTieu.Controls.Add(this.label7);
            this.grbThemChiTieu.Controls.Add(this.txtTimeOpen);
            this.grbThemChiTieu.Controls.Add(this.btnAddorEdit);
            this.grbThemChiTieu.Controls.Add(this.label1);
            this.grbThemChiTieu.Controls.Add(this.txtNameRestaurant);
            this.grbThemChiTieu.Location = new System.Drawing.Point(7, 14);
            this.grbThemChiTieu.Name = "grbThemChiTieu";
            this.grbThemChiTieu.Size = new System.Drawing.Size(856, 136);
            this.grbThemChiTieu.TabIndex = 1;
            this.grbThemChiTieu.TabStop = false;
            this.grbThemChiTieu.Text = "Chi tiêu";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(696, 30);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(127, 22);
            this.txtID.TabIndex = 15;
            this.txtID.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(35, 100);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(285, 22);
            this.txtPhone.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(354, 100);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(285, 22);
            this.txtAddress.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(509, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Loại đồ ăn";
            // 
            // txtTypeFood
            // 
            this.txtTypeFood.Location = new System.Drawing.Point(512, 50);
            this.txtTypeFood.Name = "txtTypeFood";
            this.txtTypeFood.Size = new System.Drawing.Size(127, 22);
            this.txtTypeFood.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thời gian đóng cửa";
            // 
            // txtTimeClose
            // 
            this.txtTimeClose.Location = new System.Drawing.Point(354, 50);
            this.txtTimeClose.Name = "txtTimeClose";
            this.txtTimeClose.Size = new System.Drawing.Size(127, 22);
            this.txtTimeClose.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thời gian mở cửa";
            // 
            // txtTimeOpen
            // 
            this.txtTimeOpen.Location = new System.Drawing.Point(206, 50);
            this.txtTimeOpen.Name = "txtTimeOpen";
            this.txtTimeOpen.Size = new System.Drawing.Size(114, 22);
            this.txtTimeOpen.TabIndex = 2;
            // 
            // btnAddorEdit
            // 
            this.btnAddorEdit.Location = new System.Drawing.Point(696, 68);
            this.btnAddorEdit.Name = "btnAddorEdit";
            this.btnAddorEdit.Size = new System.Drawing.Size(116, 31);
            this.btnAddorEdit.TabIndex = 7;
            this.btnAddorEdit.Text = "Thêm";
            this.btnAddorEdit.UseVisualStyleBackColor = true;
            this.btnAddorEdit.Click += new System.EventHandler(this.btnAddorEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên quán ăn";
            // 
            // txtNameRestaurant
            // 
            this.txtNameRestaurant.Location = new System.Drawing.Point(33, 50);
            this.txtNameRestaurant.Name = "txtNameRestaurant";
            this.txtNameRestaurant.Size = new System.Drawing.Size(135, 22);
            this.txtNameRestaurant.TabIndex = 1;
            // 
            // grvQuanLy
            // 
            this.grvQuanLy.AllowUserToAddRows = false;
            this.grvQuanLy.AllowUserToDeleteRows = false;
            this.grvQuanLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvQuanLy.Cursor = System.Windows.Forms.Cursors.Default;
            this.grvQuanLy.Location = new System.Drawing.Point(7, 170);
            this.grvQuanLy.Name = "grvQuanLy";
            this.grvQuanLy.ReadOnly = true;
            this.grvQuanLy.RowTemplate.Height = 24;
            this.grvQuanLy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvQuanLy.Size = new System.Drawing.Size(856, 275);
            this.grvQuanLy.TabIndex = 0;
            this.grvQuanLy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grvQuanLy_MouseClick);
            // 
            // pageDataBase
            // 
            this.pageDataBase.Controls.Add(this.btnConnect);
            this.pageDataBase.Controls.Add(this.btnTestConnect);
            this.pageDataBase.Controls.Add(this.label6);
            this.pageDataBase.Controls.Add(this.txtPass);
            this.pageDataBase.Controls.Add(this.label5);
            this.pageDataBase.Controls.Add(this.txtUser);
            this.pageDataBase.Controls.Add(this.label4);
            this.pageDataBase.Controls.Add(this.txtDBName);
            this.pageDataBase.Controls.Add(this.label3);
            this.pageDataBase.Controls.Add(this.txtSvName);
            this.pageDataBase.Location = new System.Drawing.Point(4, 25);
            this.pageDataBase.Name = "pageDataBase";
            this.pageDataBase.Padding = new System.Windows.Forms.Padding(3);
            this.pageDataBase.Size = new System.Drawing.Size(869, 451);
            this.pageDataBase.TabIndex = 1;
            this.pageDataBase.Text = "Cơ sở dữ liệu";
            this.pageDataBase.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(419, 292);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(184, 40);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnTestConnect
            // 
            this.btnTestConnect.Location = new System.Drawing.Point(221, 292);
            this.btnTestConnect.Name = "btnTestConnect";
            this.btnTestConnect.Size = new System.Drawing.Size(167, 40);
            this.btnTestConnect.TabIndex = 8;
            this.btnTestConnect.Text = "Test Connect";
            this.btnTestConnect.UseVisualStyleBackColor = true;
            this.btnTestConnect.Click += new System.EventHandler(this.btnTestConnect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(171, 249);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(472, 22);
            this.txtPass.TabIndex = 6;
            this.txtPass.Text = "123456";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "UserName";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(171, 187);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(472, 22);
            this.txtUser.TabIndex = 4;
            this.txtUser.Text = "sa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Database Name";
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(171, 124);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(472, 22);
            this.txtDBName.TabIndex = 2;
            this.txtDBName.Text = "QuanLyQuanAn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server Name";
            // 
            // txtSvName
            // 
            this.txtSvName.Location = new System.Drawing.Point(171, 64);
            this.txtSvName.Name = "txtSvName";
            this.txtSvName.Size = new System.Drawing.Size(472, 22);
            this.txtSvName.TabIndex = 0;
            this.txtSvName.Text = "DESKTOP-I5VQ77C";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 505);
            this.Controls.Add(this.tabControl);
            this.Name = "frmMain";
            this.Text = "Quản Lý Chi Tiêu";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl.ResumeLayout(false);
            this.pageQuanLy.ResumeLayout(false);
            this.grbThemChiTieu.ResumeLayout(false);
            this.grbThemChiTieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvQuanLy)).EndInit();
            this.pageDataBase.ResumeLayout(false);
            this.pageDataBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageQuanLy;
        private System.Windows.Forms.DataGridView grvQuanLy;
        private System.Windows.Forms.TabPage pageDataBase;
        private System.Windows.Forms.GroupBox grbThemChiTieu;
        private System.Windows.Forms.Button btnAddorEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameRestaurant;
        private System.Windows.Forms.TextBox txtSvName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnTestConnect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimeOpen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTypeFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimeClose;
        private System.Windows.Forms.TextBox txtID;
    }
}

