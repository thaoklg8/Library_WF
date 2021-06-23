using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLibrary
{
    class ConnectionString
    {
        public static string connectionString = @"Data Source=DESKTOP-LCMCB2E;Initial Catalog = LIBRARY; Integrated Security = True";/// thay đường dẫn SQL database
    }
    class TruyVan
    {
        public DataSet HienThi(string dieuKien)
        {
            DataSet data = new DataSet();
            string query = "select A.HoVaTen, A.Phong, B.TenSach, b.NgayMuon, B.NgayDenHan from THONGTINSINHVIEN AS A JOIN THONGTINSACH AS B ON A.IDThe = B.IDThe " + dieuKien;
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public void CapNhatMuonSach(string IDThe, string IDSach)
        {
            string ktraLoaiSach = IDSach.Substring(0, 2);
            string ngayTra = "";
            DateTime now = DateTime.Now;
            string stnow = now.ToString();
            string[] arr = stnow.Split(' ');
            string ngayMuon = arr[0];
            if (ktraLoaiSach =="ST")
            {
                DateTime han = now.AddDays(14);
                string[] arr1 = han.ToString().Split(' ');
                ngayTra = arr1[0];
            }
            else
            {
                DateTime han = now.AddMonths(1);
                string[] arr1 = han.ToString().Split(' ');
                ngayTra = arr1[0];
            }
            DataSet data = new DataSet();
            string query = "update ThongTinSach set IDThe = '"+ IDThe +"', NgayMuon = '"+ngayMuon+"', NgayDenHan = '"+ngayTra+"' where IDSach = '"+IDSach+"'";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
        }
        public DataSet LayTen(string IDThe)
        {
            DataSet data = new DataSet();
            string query = "select HoVaTen from THONGTINSINHVIEN where idThe = '" + IDThe +"'";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data, "THONGTINSINHVIEN");
                connection.Close();
            }
            return data;
        }
        public DataSet LayPhong(string IDThe)
        {
            DataSet data = new DataSet();
            string query = "select Phong from THONGTINSINHVIEN where idThe = '" + IDThe + "'";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data, "THONGTINSINHVIEN");
                connection.Close();
            }
            return data;
        }
        
        public void SuaPhong(string IDThe, string phongSua)
        {
            DataSet table = new DataSet();
            string query = "update THONGTINSINHVIEN set Phong ='" + phongSua + "' where idThe = '" + IDThe + "'";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(table);
                connection.Close();
            }
        }
        public DataSet LayTenNguoiMuonSach(string IDSach)
        {
            DataSet data = new DataSet();
            string query = "select A.HoVaTen from THONGTINSINHVIEN AS A JOIN THONGTINSACH AS B ON A.IDThe = B.IDThe where b.IDSach ='" + IDSach +"'";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public DataSet LayTenSach(string IDSach)
        {
            DataSet data = new DataSet();
            string query = "select B.TenSach from THONGTINSINHVIEN AS A JOIN THONGTINSACH AS B ON A.IDThe = B.IDThe where b.IDSach ='" + IDSach + "'";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public DataSet LayNgayDenHan(string IDSach)
        {
            DataSet data = new DataSet();
            string query = "select B.NgayDenHan from THONGTINSINHVIEN AS A JOIN THONGTINSACH AS B ON A.IDThe = B.IDThe where b.IDSach ='" + IDSach + "'";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public DataSet LayIDThe(string IDSach)
        {
            DataSet data = new DataSet();
            string query = "select A.IDThe from THONGTINSINHVIEN AS A JOIN THONGTINSACH AS B ON A.IDThe = B.IDThe where b.IDSach ='" + IDSach + "'";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public void TraSach(string IDSach)
        {
            DataSet table = new DataSet();
            string query = "update THONGTINSACH set IDThe = 'null' where idsach = '" + IDSach + "'";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(table, "T");
                connection.Close();
            }
        }
        public DataSet TimIDTheBangCMND(string cmnd)
        {
            DataSet data = new DataSet();
            string query = "select IDThe from THONGTINSINHVIEN where CMND ='" + cmnd + "'";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
    
}
