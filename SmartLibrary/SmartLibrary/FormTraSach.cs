using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLibrary
{
    public partial class FormTraSach : Form
    {
        public FormTraSach()
        {
            InitializeComponent();
        }
        TruyVan tv = new TruyVan();
        private void FormTraSach_Load(object sender, EventArgs e)
        {
            txtIDSach.Focus();
        }
        void doiTenCot()
        {
            dtgHienThi.Columns[0].HeaderText = "Họ và tên";
            dtgHienThi.Columns[1].HeaderText = "Phòng";
            dtgHienThi.Columns[2].HeaderText = "Tên sách";
            dtgHienThi.Columns[3].HeaderText = "Ngày mượn";
            dtgHienThi.Columns[4].HeaderText = "Ngày đến hạn";
        }
        private void btnIDSach_Click(object sender, EventArgs e)
        {
            //trả sách thành công, hiện thị tên người trả, tên sách. Hiện thị thông báo "Trả sách thành công" hoặc "Trả sách quá hạn"
            DataTable table = tv.LayTenNguoiMuonSach(txtIDSach.Text).Tables[0];
            int spt = table.Rows.Count;
            if (spt ==1)
            {
                lblTenSinhVien.Text = table.Rows[0][0].ToString();
                table = tv.LayTenSach(txtIDSach.Text).Tables[0];
                lblTenSach.Text = table.Rows[0][0].ToString();
                table = tv.LayNgayDenHan(txtIDSach.Text).Tables[0];
                lblNgayDenHan.Text = table.Rows[0][0].ToString();
                DateTime date = Convert.ToDateTime(lblNgayDenHan.Text);
                DateTime now = DateTime.Today;
                if (date >= now)
                    lblThongBao.Text = "TRẢ SÁCH THÀNH CÔNG!";
                else
                    lblThongBao.Text = "QUÁ HẠN!";
                
                //hiện thị các sách còn mượn
                table = tv.LayIDThe(txtIDSach.Text).Tables[0];
                string IDThe = table.Rows[0][0].ToString();
                // update
                tv.TraSach(txtIDSach.Text);
                dtgHienThi.DataSource = tv.HienThi("where A.IDThe = '" + IDThe + "'").Tables[0];
                doiTenCot();
                txtIDSach.Clear();
                txtIDSach.Focus();
            }
            else
            {
                MessageBox.Show("Sách chưa được mượn!", "THÔNG BÁO!");
            }
            
        }

        private void fr_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void trangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTrangChu fr = new FormTrangChu();
            fr.FormClosed += new FormClosedEventHandler(fr_FormClosed);
            fr.Show();
            this.Hide();
        }

        private void muonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMuonSach fr = new FormMuonSach();
            fr.FormClosed += new FormClosedEventHandler(fr_FormClosed);
            fr.Show();
            this.Hide();
        }

        private void noiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNoiQuy fr = new FormNoiQuy();
            fr.Show();
        }
    }
}
