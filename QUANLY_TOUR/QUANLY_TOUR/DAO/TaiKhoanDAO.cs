using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLY_TOUR.DAO
{
    class TaiKhoanDAO : DataProvider
    {
        public string pMatKhau = "QLTour@2021";
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            set => instance = value;
        }

        public TaiKhoanDAO()
        {
            LoadTaiKhoan();
        }
        public void LoadTaiKhoan()
        {
            string cauLeng = "select * from TaiKhoan";

            SqlDataAdapter da = new SqlDataAdapter(cauLeng, conn);

            da.Fill(ds_QLTour, "TaiKhoan");

            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLTour.Tables["TaiKhoan"].Columns[0];
            key[0].AutoIncrement = true;
            ds_QLTour.Tables["TaiKhoan"].PrimaryKey = key;
        }
        public DataTable GetTaiKhoan()
        {
            return ds_QLTour.Tables["TaiKhoan"];
        }
        public bool InsertTaiKhoan(string tenDangNhap, string matKhau, int idNhanVien)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string cauLenh = "INSERT INTO TAIKHOAN VALUES('" + tenDangNhap + "', '" + matKhau + "', '" + idNhanVien + "')";
                SqlCommand cmd = new SqlCommand(cauLenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                return true;
            }
            catch
            {
                return false;

            }
        }
        public bool xoaTaiKhoan(string idNhanVien)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string cauLenh = "delete from taikhoan where idNhanVien='" + idNhanVien + "'";
                SqlCommand cmd = new SqlCommand(cauLenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DatLaiMK(string idNhanVien, string matKhau)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string cauLenh = "Update TaiKhoan set matkhau = '" + matKhau + "' where idnhanvien = '" + idNhanVien + "'";
                SqlCommand cmd = new SqlCommand(cauLenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int KTTrungTaiKhoan(string tenDangNhap)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string cauLenh = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = '" + tenDangNhap + "'";
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
        public bool DoiMatKhau(string tenDangNhap, string matKhauMoi)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string cauLenh = "Update TaiKhoan set matkhau = '" + matKhauMoi + "' where TenDangNhap = '" + tenDangNhap + "'";
                SqlCommand cmd = new SqlCommand(cauLenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int KTTrungMatKhau(string tenDangNhap, string matKhauMoi)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string cauLenh = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = '" + tenDangNhap + "' and MatKhau = '" + matKhauMoi + "'";
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
