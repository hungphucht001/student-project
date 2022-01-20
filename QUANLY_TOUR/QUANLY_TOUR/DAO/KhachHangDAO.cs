using QUANLY_TOUR.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLY_TOUR.DAO
{
    class KhachHangDAO : DataProvider
    {
        private static KhachHangDAO instance;
        string cauLeng = "select * from KhachHang";
        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            set => instance = value;
        }
        public KhachHangDAO()
        {
            LoadKhacHang();
        }
        public void LoadKhacHang()
        {
            SqlDataAdapter da = new SqlDataAdapter(cauLeng, conn);

            da.Fill(ds_QLTour, "KhachHang");

            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLTour.Tables["KhachHang"].Columns[0];

            key[0].AutoIncrement = true;
            key[0].AutoIncrementSeed = MAMAx();
            key[0].AutoIncrementStep = 1;
            key[0].AllowDBNull = false;
            key[0].Unique = true;

            ds_QLTour.Tables["KhachHang"].PrimaryKey = key;
        }
        public int MAMAx()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string cauLenh = "select top 1 ID_KhachHang from KhachHang order by ID_KhachHang desc";
            SqlCommand cmd = new SqlCommand(cauLenh, conn);
            int kq = (int)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return kq + 1;
        }
        public DataTable GetKhachHang()
        {
            return ds_QLTour.Tables["KhachHang"];
        }
        public bool xoaKhachHang(int ID)
        {
            try
            {
                DataRow rowData = ds_QLTour.Tables["KhachHang"].Rows.Find(ID);
                rowData.Delete();
                SaveKhachHang();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool suaKhachHang(KhachHangDTO kh)
        {
            try
            {
                DataRow rowData = ds_QLTour.Tables["KhachHang"].Rows.Find(kh.ID_KhachHang);
                rowData["HoTen"] = kh.HoTen;
                rowData["DiaChi"] = kh.DiaChi;
                rowData["GioiTinh"] = kh.GioiTinh;
                rowData["NgaySinh"] = kh.NgaySinh;

                SaveKhachHang();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public int KTTrungSDT_KH(string sdt)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string cauLenh = "SELECT COUNT(*) FROM KHACHHANG WHERE SDT = '" + sdt + "'";
                SqlCommand cmd = new SqlCommand(cauLenh, conn);
                int kq = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                if (kq >= 1)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            catch
            {
                return 3;
            }
        }
        public bool themKhachHang(KhachHangDTO kh)
        {
            //try
            //{
                DataRow rowData = ds_QLTour.Tables["KhachHang"].NewRow();
                rowData["HoTen"] = kh.HoTen;
                rowData["SDT"] = kh.SDT;
                rowData["DiaChi"] = kh.DiaChi;
                rowData["GioiTinh"] = kh.GioiTinh;
                rowData["NgaySinh"] = kh.NgaySinh;

                ds_QLTour.Tables["KhachHang"].Rows.Add(rowData);
                SaveKhachHang();
                return true;
            //}
            //catch
            //{
            //    return false;
            //}

        }
        public void SaveKhachHang()
        {
            SqlDataAdapter sda = new SqlDataAdapter(cauLeng, conn);
            new SqlCommandBuilder(sda);
            sda.Update(ds_QLTour, "KhachHang");
        }
        public DataTable GetKHByMaTour(int idMaTour)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select * from KhachHang kh, DangKyTour dk where dk.IdKhachHang = kh.ID_KhachHang and IdTour = " + idMaTour;
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public int XoaTourKhachHang(int idTour, int idKH)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql = "delete DangKyTour where IdTour = "+idTour+" and IdKhachHang = "+ idKH;
                SqlCommand cmd = new SqlCommand(sql, conn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                return kq;
            }
            catch
            {
                return -1;
            }
        }
        public int getIDKhachHang(string sdt)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string cauLenh = "select ID_KhachHang from khachhang where SDT = '" + sdt + "'";
            SqlCommand cmd = new SqlCommand(cauLenh, conn);
            int kq = (int)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return kq;
        }
        public int KTKNKhachHang_DangKyTour(int id)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string cauLenh = "SELECT COUNT(*) FROM DangKyTour WHERE idKhachHang = '" + id + "'";
                SqlCommand cmd = new SqlCommand(cauLenh, conn);
                int kq = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                if (kq >= 1)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            catch
            {
                return 3;
            }
        }
    }
}
