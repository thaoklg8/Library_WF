
namespace SmartLibrary
{
    partial class FormTraSach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIDSach = new System.Windows.Forms.Button();
            this.txtIDSach = new System.Windows.Forms.TextBox();
            this.dtgHienThi = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNgayDenHan = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblTenSinhVien = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trangChuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muonSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noiQuyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHienThi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIDSach);
            this.groupBox1.Controls.Add(this.txtIDSach);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(147, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(401, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TRẢ SÁCH";
            // 
            // btnIDSach
            // 
            this.btnIDSach.Location = new System.Drawing.Point(325, 51);
            this.btnIDSach.Name = "btnIDSach";
            this.btnIDSach.Size = new System.Drawing.Size(69, 35);
            this.btnIDSach.TabIndex = 1;
            this.btnIDSach.Text = "TRẢ SÁCH";
            this.btnIDSach.UseVisualStyleBackColor = true;
            this.btnIDSach.Click += new System.EventHandler(this.btnIDSach_Click);
            // 
            // txtIDSach
            // 
            this.txtIDSach.Location = new System.Drawing.Point(18, 50);
            this.txtIDSach.Name = "txtIDSach";
            this.txtIDSach.Size = new System.Drawing.Size(301, 34);
            this.txtIDSach.TabIndex = 0;
            this.txtIDSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDSach_KeyPress);
            // 
            // dtgHienThi
            // 
            this.dtgHienThi.AllowUserToAddRows = false;
            this.dtgHienThi.AllowUserToDeleteRows = false;
            this.dtgHienThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgHienThi.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHienThi.Location = new System.Drawing.Point(12, 337);
            this.dtgHienThi.Name = "dtgHienThi";
            this.dtgHienThi.ReadOnly = true;
            this.dtgHienThi.RowHeadersWidth = 51;
            this.dtgHienThi.RowTemplate.Height = 24;
            this.dtgHienThi.Size = new System.Drawing.Size(1158, 404);
            this.dtgHienThi.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblNgayDenHan);
            this.groupBox2.Controls.Add(this.lblTenSach);
            this.groupBox2.Controls.Add(this.lblTenSinhVien);
            this.groupBox2.Controls.Add(this.lblThongBao);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.Location = new System.Drawing.Point(626, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 240);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN MƯỢN TRẢ SÁCH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày đến hạn:";
            // 
            // lblNgayDenHan
            // 
            this.lblNgayDenHan.AutoSize = true;
            this.lblNgayDenHan.Location = new System.Drawing.Point(149, 148);
            this.lblNgayDenHan.Name = "lblNgayDenHan";
            this.lblNgayDenHan.Size = new System.Drawing.Size(36, 28);
            this.lblNgayDenHan.TabIndex = 5;
            this.lblNgayDenHan.Text = "---";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Location = new System.Drawing.Point(148, 104);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(36, 28);
            this.lblTenSach.TabIndex = 4;
            this.lblTenSach.Text = "---";
            // 
            // lblTenSinhVien
            // 
            this.lblTenSinhVien.AutoSize = true;
            this.lblTenSinhVien.Location = new System.Drawing.Point(148, 53);
            this.lblTenSinhVien.Name = "lblTenSinhVien";
            this.lblTenSinhVien.Size = new System.Drawing.Size(36, 28);
            this.lblTenSinhVien.TabIndex = 3;
            this.lblTenSinhVien.Text = "---";
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblThongBao.ForeColor = System.Drawing.Color.Ivory;
            this.lblThongBao.Location = new System.Drawing.Point(165, 190);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(28, 28);
            this.lblThongBao.TabIndex = 2;
            this.lblThongBao.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sách: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sinh viên:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangToolStripMenuItem,
            this.muonToolStripMenuItem,
            this.noiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangToolStripMenuItem
            // 
            this.trangToolStripMenuItem.Name = "trangToolStripMenuItem";
            this.trangToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.trangToolStripMenuItem.Text = "Trang chủ";
            this.trangToolStripMenuItem.Click += new System.EventHandler(this.trangToolStripMenuItem_Click);
            // 
            // muonToolStripMenuItem
            // 
            this.muonToolStripMenuItem.Name = "muonToolStripMenuItem";
            this.muonToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.muonToolStripMenuItem.Text = "Mượn sách";
            this.muonToolStripMenuItem.Click += new System.EventHandler(this.muonToolStripMenuItem_Click);
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
            // noiQuyToolStripMenuItem
            // 
            this.noiQuyToolStripMenuItem.Name = "noiQuyToolStripMenuItem";
            this.noiQuyToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // FormTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtgHienThi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTraSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRẢ SÁCH";
            this.Load += new System.EventHandler(this.FormTraSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHienThi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIDSach;
        private System.Windows.Forms.TextBox txtIDSach;
        private System.Windows.Forms.DataGridView dtgHienThi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblTenSinhVien;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNgayDenHan;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muonSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noiQuyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noiToolStripMenuItem;
    }
}