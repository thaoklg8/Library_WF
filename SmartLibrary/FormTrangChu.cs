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
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }
        
        
        /* câu truy vấn sql để 
         * hiện ds mượn sách:
         * select A.IDThe, A.HoVaTen, A.Phong, A.CMND, B.IDSach, B.TenSach, b.NgayMuon, B.NgayDenHan
            from THONGTINSINHVIEN AS A JOIN THONGTINSACH AS B ON A.IDThe = B.IDThe
        
        cập nhật trả sách:
        update ThongTinSach set IDThe = null, NgayMuon = null, NgayDenHan = null where IDSach = 'S001'
        */
        void doiTenCot()
        {
            dataGridView1.Columns[0].HeaderText = "Họ và tên";
            dataGridView1.Columns[1].HeaderText = "Phòng";
            dataGridView1.Columns[2].HeaderText = "Tên sách";
            dataGridView1.Columns[3].HeaderText = "Ngày mượn";
            dataGridView1.Columns[4].HeaderText = "Ngày đến hạn";
        }
        
        private void fr_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void danhSáchSáchĐãMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TruyVan tv = new TruyVan();
            dataGridView1.DataSource = tv.HienThi("").Tables[0];
            doiTenCot();
            dataGridView1.Visible = true;
        }

        private void trToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTrangChu fr = new FormTrangChu();
            fr.FormClosed += new FormClosedEventHandler(fr_FormClosed);
            fr.Show();
            this.Hide();
        }

        private void noiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNoiQuy fr = new FormNoiQuy();
            fr.Show();
        }

        private void traToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTraSach fr = new FormTraSach();
            fr.FormClosed += new FormClosedEventHandler(fr_FormClosed);
            fr.Show();
            this.Hide();
        }
        private void muonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormMuonSach fr = new FormMuonSach();
            fr.FormClosed += new FormClosedEventHandler(fr_FormClosed);
            fr.Show();
            this.Hide();
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            TruyVan tv = new TruyVan();
            dataGridView1.DataSource = tv.HienThi("").Tables[0];
            doiTenCot();
        }
    }
}
