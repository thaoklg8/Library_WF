using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLibrary
{
    public partial class FormMuonSach : Form
    {
        public FormMuonSach()
        {
            InitializeComponent();
        }


        void doiTenCot()
        {
            dtgHienThi.Columns[0].HeaderText = "Họ và tên";
            dtgHienThi.Columns[1].HeaderText = "Phòng";
            dtgHienThi.Columns[2].HeaderText = "Tên sách";
            dtgHienThi.Columns[3].HeaderText = "Ngày mượn";
            dtgHienThi.Columns[4].HeaderText = "Ngày đến hạn";
        }
       
        private void btnMatThe_Click(object sender, EventArgs e)
        {
            groupCMND.Visible = true;
            txtCMND.Focus();
        }
        
        private void btnEnterID_Click(object sender, EventArgs e)
        {
            lblIDThe.Text = txtIDThe.Text.ToUpper();
            txtIDThe.Clear();
            txtIDSach.Focus();
            TruyVan tv = new TruyVan();
            DataTable table = tv.LayTen(lblIDThe.Text).Tables[0];
            if (table.Rows.Count > 0)
            {
                
                txtTen.Text = table.Rows[0][0].ToString();
                table = tv.LayPhong(lblIDThe.Text).Tables[0];
                txtPhong.Text = table.Rows[0][0].ToString();

                dtgHienThi.DataSource = tv.HienThi("where A.IDThe = '" + lblIDThe.Text + "'").Tables[0];
                doiTenCot();
            }
            else
            {
                MessageBox.Show("ID thẻ không đúng!", "THÔNG BÁO");
                lblIDThe.Text = "---";
                txtTen.Text = "";
                txtPhong.Text = "";
                txtIDThe.Focus();
            }
            
                
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            if (txtIDSach.Text.Length > 2)
            {
                TruyVan tv = new TruyVan();
                tv.CapNhatMuonSach(lblIDThe.Text, txtIDSach.Text.ToUpper());
                dtgHienThi.DataSource = tv.HienThi("where A.IDThe = '" + lblIDThe.Text + "'").Tables[0];
            }
            else
                MessageBox.Show("ID sách không đúng!", "THÔNG BÁO");
            txtIDSach.Clear();
            txtIDSach.Focus();
            doiTenCot();
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            TruyVan tv = new TruyVan();
            tv.SuaPhong(lblIDThe.Text, txtPhong.Text);
            dtgHienThi.DataSource = tv.HienThi("where A.IDThe = '" + lblIDThe.Text + "'").Tables[0];
        }
        private void fr_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
       
        private void FormMuonSach_Load(object sender, EventArgs e)
        {
            txtIDThe.Focus();
        }

        private void txtIDThe_KeyPress(object sender, KeyPressEventArgs e) //////// sự kiện KeyPress này sao em làm nó chẳng chạy, nên hiện em vẫn để button
        {
            if (e.KeyChar == (char)5)
            {
                lblIDThe.Text = txtIDThe.Text;
                txtIDThe.Clear();
                txtIDSach.Focus();
                TruyVan tv = new TruyVan();
                DataTable table = tv.LayTen(lblIDThe.Text).Tables[0];
                txtTen.Text = table.Rows[0][0].ToString();
                table = tv.LayPhong(lblIDThe.Text).Tables[0];
                txtPhong.Text = table.Rows[0][0].ToString();
                dtgHienThi.DataSource = tv.HienThi("where A.IDThe = '" + lblIDThe.Text + "'").Tables[0];
            }
        }
       
        private void btnCMND_Click(object sender, EventArgs e)
        {
            TruyVan tv = new TruyVan();
            DataTable table = tv.TimIDTheBangCMND(txtCMND.Text).Tables[0];
            if (table.Rows.Count > 0)
            {
                lblIDThe.Text = table.Rows[0][0].ToString().ToUpper();
                table = tv.LayTen(lblIDThe.Text).Tables[0];
                txtTen.Text = table.Rows[0][0].ToString();
                table = tv.LayPhong(lblIDThe.Text).Tables[0];
                txtPhong.Text = table.Rows[0][0].ToString();
                dtgHienThi.DataSource = tv.HienThi("where A.IDThe = '" + lblIDThe.Text + "'").Tables[0];
                doiTenCot();
            }
            else
            {
                MessageBox.Show("CMND không tìm thấy!", "THÔNG BÁO");
                lblIDThe.Text = "---";
                txtTen.Text = "";
                txtPhong.Text = "";
                txtCMND.Focus();
            }
        }

        private void trangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTrangChu fr = new FormTrangChu();
            fr.FormClosed += new FormClosedEventHandler(fr_FormClosed);
            fr.Show();
            this.Hide();
        }

        private void traToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTraSach fr = new FormTraSach();
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

