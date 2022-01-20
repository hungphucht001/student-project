using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLY_TOUR.DTO;
using System.Data;
using System.Data.SqlClient;

namespace QUANLY_TOUR.DAO
{
    class TourDAO: DataProvider
    {
        private static TourDAO instance;
        public static TourDAO Instance
        {
            get { if (instance == null) instance = new TourDAO(); return instance; }
            set => instance = value;
        }
        public TourDAO()
        {
            LoadTour();
        }
        public void LoadTour()
        {
            string cauLeng = "select * from Tour";

            SqlDataAdapter da = new SqlDataAdapter(cauLeng, conn);

            da.Fill(ds_QLTour, "Tour");

            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLTour.Tables["Tour"].Columns[0];
            key[0].AutoIncrement = true;
            key[0].AutoIncrementSeed = GetIdTourNew();
            key[0].AutoIncrementStep = 1;
            key[0].AllowDBNull = false;
            key[0].Unique = true;
            ds_QLTour.Tables["Tour"].PrimaryKey = key;
        }
        public DataTable LoadTourFull()
        {
            string sql = "SELECT T.*, TenKhachSan, TenPhuongTien, NV1.HoTen as NVDan, NV2.HoTen as NVMo, tt.TrangThai as TrangThaiTour FROM Tour T, PhuongTien PT, KhachSan KS, NhanVien NV1,NhanVien NV2, TrangThaiTour tt WHERE T.idKhachSan = KS.ID_KhachSan AND PT.ID_PhuongTien = T.idPhuongTien AND NV1.ID_NhanVien = T.idNhanVienDanDoan and NV2.ID_NhanVien = T.NguoiMo and T.TrangThai = tt.ID_TrangThai";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            da.Fill(dt);
            return dt;
        }
        public DataTable GetTour()
        {
            return ds_QLTour.Tables["Tour"];
        }
        public DataTable GetTourChuaBD()
        {
            //DataView dv = ds_QLTour.Tables["Tour"].DefaultView;

            //dv.RowFilter = string.Format(DateTime.Parse("NgayBD > '{0}'"), DateTime.Today);

            //return dv.ToTable();

            string sql = "SET DATEFORMAT DMY SELECT ID_Tour, TenTour, SoVe, TrangThaiTour.TrangThai From Tour, TrangThaiTour where Tour.TrangThai = ID_TrangThai and NgayBD > '" + DateTime.Now.ToString("dd-MM-yyyy") + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
        public TourDTO GetTour(int idTour)
        {
            DataRow dr = ds_QLTour.Tables["Tour"].Rows.Find(idTour);
            return new TourDTO(dr);
        }
        public bool InsertTour(DateTime ngayBD, DateTime ngayKT, int soVe, int idPhuongTien, int idKhachSan, int idNhanVien, int gia, int giamGia, int idNguoiMo, string tenToour, int trangThai)
        {
            try
            {
                DataRow dr = ds_QLTour.Tables["Tour"].NewRow();
                dr["NgayBD"] = ngayBD;
                dr["NgayKT"] = ngayKT;
                dr["SoVe"] = soVe;
                dr["IdPhuongTien"] = idPhuongTien;
                dr["IdKhachSan"] = idKhachSan;
                dr["IdNhanVienDanDoan"] = idNhanVien;
                dr["Gia"] = gia;
                dr["GiamGia"] = giamGia;
                dr["NguoiMo"] = idNguoiMo;
                dr["TenTour"] = tenToour;
                dr["TrangThai"] = trangThai;

                ds_QLTour.Tables["Tour"].Rows.Add(dr);
                saveTour();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int UpdateTour(int idTour,DateTime ngayBD, DateTime ngayKT, int soVe, int idPhuongTien, int idKhachSan, int idNhanVien, double gia, int giamGia, int idNguoiMo, string tenToour, int trangThai)
        {
            try
            {
                DataRow dr = ds_QLTour.Tables["Tour"].Rows.Find(idTour);
                if(dr != null)
                {
                    dr["NgayBD"] = ngayBD;
                    dr["NgayKT"] = ngayKT;
                    dr["SoVe"] = soVe;
                    dr["IdPhuongTien"] = idPhuongTien;
                    dr["IdKhachSan"] = idKhachSan;
                    dr["IdNhanVienDanDoan"] = idNhanVien;
                    dr["Gia"] = gia;
                    dr["GiamGia"] = giamGia;
                    dr["NguoiMo"] = idNguoiMo;
                    dr["TenTour"] = tenToour;
                    dr["TrangThai"] = trangThai;
                    saveTour();
                    return 0;
                }
                return 1;
            }
            catch
            {
                return -1;
            }
        }
        public bool DangKyTour(int idTour, int idKhachHang, int idNhanVien, string ngayDK)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string cauLenh = "SET DATEFORMAT DMY INSERT INTO DangKyTour VALUES(" + idTour + ", " + idKhachHang + ", " + idNhanVien + ", '" + ngayDK + "')";
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
        public int KiemTraKHDaDkTuor(int idTour, int idKh)
        {
            try
            {
                string sql = "SELECT count(*) FROM DANGKYTOUR WHERE idTour = "+idTour+" and idKhachHang = " + idKh;
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(sql,conn);

                int count = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open) conn.Close();
                if (count > 0) return 1;

                return 0;
            }
            catch { return -1; }
        }
        public int GetIdTourNew()
        {
            try
            {
                string sql = "select top 1 ID_Tour from Tour order by ID_Tour desc";
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                int count = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open) conn.Close();
                if (count > 0) return count;

                return 0;
            }
            catch { return -1; }
        }
        public int DeleteTour(int idTuor)
        {
            try
            {
                DataRow dr = ds_QLTour.Tables["Tour"].Rows.Find(idTuor);
                if(dr != null)
                {
                    dr.Delete();
                    saveTour();
                    return 0;
                }
                return 1;
            }
            catch
            {
                return -1;
            }
        }
        public void saveTour()
        {
            string sql = "select * from Tour";

            SqlDataAdapter da_Khoa = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da_Khoa);
            da_Khoa.Update(ds_QLTour, "Tour");
        }
        public bool CheckDeleteTour(int idTuor)
        {
            try
            {
                string sql1 = "select * from Tour t, DangKyTour dk where dk.IdTour = t.ID_Tour and ID_Tour = "+idTuor;

                DataTable dt1 = new DataTable();

                SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
                da1.Fill(dt1);
                if(dt1.Rows.Count == 0)
                {
                    string sql2 = "select * from Tour t, Tour_DiaDiem tdd where tdd.idTour = t.ID_Tour and ID_Tour = " + idTuor;

                    DataTable dt2 = new DataTable();

                    SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
                    da2.Fill(dt2);
                    if(dt2.Rows.Count == 0) return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public DataTable LoadDoanhThu(string ngayBD, string ngayKT)
        {
            string sql = "set dateformat DMY select id_dangkytour, ID_Tour, TenTour, KhachHang.HoTen, NhanVien.HoTen, Gia, NgayDK from Tour, DangKyTour, KhachHang, NhanVien where Tour.ID_Tour = DangKyTour.IdTour and DangKyTour.IdKhachHang = KhachHang.ID_KhachHang and DangKyTour.IdNhanVien = NhanVien.ID_NhanVien and NgayDK between '" + ngayBD + "' and '" + ngayKT + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
        public int KTKNDTour_DangKyTour(int id)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string cauLenh = "SELECT COUNT(*) FROM DangKyTour WHERE idTour = '" + id + "'";
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

        public int KTHetVe(int id)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string cauLenh = "select count(*) from Tour where id_tour = "+id+" and trangthai = 2";
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

        public int KTKNDTour_TourDiaDiem(int id)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string cauLenh = "SELECT COUNT(*) FROM Tour_DiaDiem WHERE idTour = '" + id + "'";
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
