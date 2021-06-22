
namespace SmartLibrary
{
    partial class FormMuonSach
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
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.groupCMND = new System.Windows.Forms.GroupBox();
            this.btnCMND = new System.Windows.Forms.Button();
            this.btnMatThe = new System.Windows.Forms.Button();
            this.txtIDThe = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIDThe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuaThongTin = new System.Windows.Forms.Button();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.dtgHienThi = new System.Windows.Forms.DataGridView();
            this.txtIDSach = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMuonSach = new System.Windows.Forms.Button();
            this.groupBoxDangNhap = new System.Windows.Forms.GroupBox();
            this.btnEnterID = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trangChuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muonSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noiQuyMuonSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupCMND.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHienThi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBoxDangNhap.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(7, 37);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(268, 34);
            this.txtCMND.TabIndex = 0;
            // 
            // groupCMND
            // 
            this.groupCMND.Controls.Add(this.btnCMND);
            this.groupCMND.Controls.Add(this.txtCMND);
            this.groupCMND.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupCMND.Location = new System.Drawing.Point(25, 230);
            this.groupCMND.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupCMND.Name = "groupCMND";
            this.groupCMND.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupCMND.Size = new System.Drawing.Size(382, 93);
            this.groupCMND.TabIndex = 1;
            this.groupCMND.TabStop = false;
            this.groupCMND.Text = "Mượn bằng CMND";
            this.groupCMND.Visible = false;
            // 
            // btnCMND
            // 
            this.btnCMND.Location = new System.Drawing.Point(282, 29);
            this.btnCMND.Name = "btnCMND";
            this.btnCMND.Size = new System.Drawing.Size(100, 42);
            this.btnCMND.TabIndex = 1;
            this.btnCMND.Text = "CMND";
            this.btnCMND.UseVisualStyleBackColor = true;
            this.btnCMND.Click += new System.EventHandler(this.btnCMND_Click);
            // 
            // btnMatThe
            // 
            this.btnMatThe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMatThe.Location = new System.Drawing.Point(25, 175);
            this.btnMatThe.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMatThe.Name = "btnMatThe";
            this.btnMatThe.Size = new System.Drawing.Size(110, 43);
            this.btnMatThe.TabIndex = 2;
            this.btnMatThe.Text = "Mất thẻ";
            this.btnMatThe.UseVisualStyleBackColor = true;
            this.btnMatThe.Click += new System.EventHandler(this.btnMatThe_Click);
            // 
            // txtIDThe
            // 
            this.txtIDThe.Location = new System.Drawing.Point(6, 44);
            this.txtIDThe.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtIDThe.Name = "txtIDThe";
            this.txtIDThe.Size = new System.Drawing.Size(269, 34);
            this.txtIDThe.TabIndex = 0;
            this.txtIDThe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDThe_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblIDThe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSuaThongTin);
            this.groupBox1.Controls.Add(this.txtPhong);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.lblPhong);
            this.groupBox1.Controls.Add(this.lblTen);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(775, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 253);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // lblIDThe
            // 
            this.lblIDThe.AutoSize = true;
            this.lblIDThe.Location = new System.Drawing.Point(99, 40);
            this.lblIDThe.Name = "lblIDThe";
            this.lblIDThe.Size = new System.Drawing.Size(36, 28);
            this.lblIDThe.TabIndex = 8;
            this.lblIDThe.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // btnSuaThongTin
            // 
            this.btnSuaThongTin.Location = new System.Drawing.Point(66, 189);
            this.btnSuaThongTin.Name = "btnSuaThongTin";
            this.btnSuaThongTin.Size = new System.Drawing.Size(284, 50);
            this.btnSuaThongTin.TabIndex = 6;
            this.btnSuaThongTin.Text = "SỬA THÔNG TIN";
            this.btnSuaThongTin.UseVisualStyleBackColor = true;
            this.btnSuaThongTin.Click += new System.EventHandler(this.btnSuaThongTin_Click);
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(97, 141);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(253, 34);
            this.txtPhong.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(97, 86);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(253, 34);
            this.txtTen.TabIndex = 3;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(18, 141);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(69, 28);
            this.lblPhong.TabIndex = 1;
            this.lblPhong.Text = "Phòng";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(18, 92);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(41, 28);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên";
            // 
            // dtgHienThi
            // 
            this.dtgHienThi.AllowUserToAddRows = false;
            this.dtgHienThi.AllowUserToDeleteRows = false;
            this.dtgHienThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgHienThi.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgHienThi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHienThi.Location = new System.Drawing.Point(25, 355);
            this.dtgHienThi.Name = "dtgHienThi";
            this.dtgHienThi.ReadOnly = true;
            this.dtgHienThi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgHienThi.RowHeadersWidth = 51;
            this.dtgHienThi.RowTemplate.Height = 24;
            this.dtgHienThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHienThi.Size = new System.Drawing.Size(1133, 364);
            this.dtgHienThi.TabIndex = 3;
            // 
            // txtIDSach
            // 
            this.txtIDSach.Location = new System.Drawing.Point(17, 50);
            this.txtIDSach.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtIDSach.Name = "txtIDSach";
            this.txtIDSach.Size = new System.Drawing.Size(304, 34);
            this.txtIDSach.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMuonSach);
            this.groupBox2.Controls.Add(this.txtIDSach);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.Location = new System.Drawing.Point(424, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 253);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MƯỢN SÁCH";
            // 
            // btnMuonSach
            // 
            this.btnMuonSach.Location = new System.Drawing.Point(118, 103);
            this.btnMuonSach.Name = "btnMuonSach";
            this.btnMuonSach.Size = new System.Drawing.Size(123, 52);
            this.btnMuonSach.TabIndex = 5;
            this.btnMuonSach.Text = "Muon Sach";
            this.btnMuonSach.UseVisualStyleBackColor = true;
            this.btnMuonSach.Click += new System.EventHandler(this.btnMuonSach_Click);
            // 
            // groupBoxDangNhap
            // 
            this.groupBoxDangNhap.Controls.Add(this.btnEnterID);
            this.groupBoxDangNhap.Controls.Add(this.txtIDThe);
            this.groupBoxDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBoxDangNhap.Location = new System.Drawing.Point(25, 69);
            this.groupBoxDangNhap.Name = "groupBoxDangNhap";
            this.groupBoxDangNhap.Size = new System.Drawing.Size(382, 97);
            this.groupBoxDangNhap.TabIndex = 1;
            this.groupBoxDangNhap.TabStop = false;
            this.groupBoxDangNhap.Text = "ĐĂNG NHẬP";
            // 
            // btnEnterID
            // 
            this.btnEnterID.Location = new System.Drawing.Point(305, 44);
            this.btnEnterID.Name = "btnEnterID";
            this.btnEnterID.Size = new System.Drawing.Size(71, 40);
            this.btnEnterID.TabIndex = 1;
            this.btnEnterID.Text = "ID";
            this.btnEnterID.UseVisualStyleBackColor = true;
            this.btnEnterID.Click += new System.EventHandler(this.btnEnterID_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangToolStripMenuItem,
            this.traToolStripMenuItem,
            this.noiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangToolStripMenuItem
            // 
            this.trangToolStripMenuItem.Name = "trangToolStripMenuItem";
            this.trangToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.trangToolStripMenuItem.Text = "Trang chủ ";
            this.trangToolStripMenuItem.Click += new System.EventHandler(this.trangToolStripMenuItem_Click);
            // 
            // traToolStripMenuItem
            // 
            this.traToolStripMenuItem.Name = "traToolStripMenuItem";
            this.traToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.traToolStripMenuItem.Text = "Trả sách";
            this.traToolStripMenuItem.Click += new System.EventHandler(this.traToolStripMenuItem_Click);
            // 
            // noiToolStripMenuItem
            // 
            this.noiToolStripMenuItem.Name = "noiToolStripMenuItem";
            this.noiToolStripMenuItem.Size = new System.Drawing.Size(189, 29);
            this.noiToolStripMenuItem.Text = "Nội quy mượn sách";
            this.noiToolStripMenuItem.Click += new System.EventHandler(this.noiToolStripMenuItem_Click);
            // 
            // trangChuToolStripMenuItem
            // 
            this.trangChuToolStripMenuItem.Name = "trangChuToolStripMenuItem";
            this.trangChuToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // muonSachToolStripMenuItem
            // 
            this.muonSachToolStripMenuItem.Name = "muonSachToolStripMenuItem";
            this.muonSachToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // traSachToolStripMenuItem
            // 
            this.traSachToolStripMenuItem.Name = "traSachToolStripMenuItem";
            this.traSachToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // noiQuyMuonSachToolStripMenuItem
            // 
            this.noiQuyMuonSachToolStripMenuItem.Name = "noiQuyMuonSachToolStripMenuItem";
            this.noiQuyMuonSachToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // FormMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.groupBoxDangNhap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnMatThe);
            this.Controls.Add(this.dtgHienThi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupCMND);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormMuonSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MƯỢN SÁCH";
            this.Load += new System.EventHandler(this.FormMuonSach_Load);
            this.groupCMND.ResumeLayout(false);
            this.groupCMND.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHienThi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxDangNhap.ResumeLayout(false);
            this.groupBoxDangNhap.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.GroupBox groupCMND;
        private System.Windows.Forms.Button btnMatThe;
        private System.Windows.Forms.TextBox txtIDThe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSuaThongTin;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.DataGridView dtgHienThi;
        private System.Windows.Forms.TextBox txtIDSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxDangNhap;
        private System.Windows.Forms.Button btnEnterID;
        private System.Windows.Forms.Button btnMuonSach;
        private System.Windows.Forms.Label lblIDThe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muonSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noiQuyMuonSachToolStripMenuItem;
        private System.Windows.Forms.Button btnCMND;
        private System.Windows.Forms.ToolStripMenuItem trangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noiToolStripMenuItem;
    }
}