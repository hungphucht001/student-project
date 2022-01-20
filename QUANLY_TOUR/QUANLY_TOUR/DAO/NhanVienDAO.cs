using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLY_TOUR.DTO;

namespace QUANLY_TOUR.DAO
{
    public class NhanVienDAO : DataProvider
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            set => instance = value;
        }
        public NhanVienDAO()
        {
            LoadNhanVien();
            LoadNhanVienChucVu();
            LoadTrangThaiNV();
        }
        public void LoadNhanVien()
        {
            if(ds_QLTour.Tables["NhanVien"] != null)
            {
                ds_QLTour.Tables["NhanVien"].Rows.Clear();
            }

            string cauLeng = "select * from NhanVien";

            SqlDataAdapter da = new SqlDataAdapter(cauLeng, conn);

            da.Fill(ds_QLTour, "NhanVien");

            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLTour.Tables["NhanVien"].Columns[0];
            key[0].AutoIncrement = true;
            key[0].AutoIncrementSeed = 1;
            ds_QLTour.Tables["NhanVien"].PrimaryKey = key;
        }
        public DataTable GetNhanVien()
        {
            return ds_QLTour.Tables["NhanVien"];
        }
        public void LoadNhanVienChucVu()
        {
            string cauLeng = "select * from NhanVien, ChucVu, TrangThaiNV where idChucVu = ID_ChucVu and NhanVien.TrangThai = id_trangThai";

            SqlDataAdapter da = new SqlDataAdapter(cauLeng, conn);

            da.Fill(ds_QLTour, "NhanVien_ChucVu");
        }
       
        public DataTable GetNhanVienChucVu()
        {
            if (ds_QLTour.Tables["NhanVien_ChucVu"] != null)
            {
                ds_QLTour.Tables["NhanVien_ChucVu"].Rows.Clear();
                LoadNhanVienChucVu();
            }
            return ds_QLTour.Tables["NhanVien_ChucVu"];
        }

        public DataTable GetNhanVienDanDoan()
        {
            DataView dv = ds_QLTour.Tables["NhanVien"].DefaultView;
            dv.RowFilter = "idChucVu = 4";
            return dv.ToTable();
        }

        public void LoadTrangThaiNV()
        {
            string cauLeng = "select * from TrangThaiNV";

            SqlDataAdapter da = new SqlDataAdapter(cauLeng, conn);

            da.Fill(ds_QLTour, "TrangThaiNV");
        }

        public DataTable GetTrangThaiNV()
        {
            if (ds_QLTour.Tables["TrangThaiNV"] != null)
            {
                ds_QLTour.Tables["TrangThaiNV"].Rows.Clear();
                LoadTrangThaiNV();
            }
            return ds_QLTour.Tables["TrangThaiNV"];
        }
        public bool InsertNhanVien(string hoten, string sdt, string gioitinh, string ngaysinh, string ngayvl, double luong, int idchucvu, string diachi, int trangThai)
        {            
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string cauLenh = "set dateformat DMY INSERT INTO NHANVIEN VALUES(N'" + hoten + "', '" + sdt + "', N'" + gioitinh + "', '" + ngaysinh + "', '" + ngayvl + "', '" + luong + "', '" + idchucvu + "', N'" + diachi + "','" + trangThai + "')";
                SqlCommand cmd = new SqlCommand(cauLenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                LoadNhanVien();
                return true;
            }
            catch
            {
                return false;

            }
            
        }

        //Để thêm nhân viên mới
        public int getIDNhanVien() 
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string cauLenh = "select top 1 ID_NhanVien from NhanVien order by ID_NhanVien desc";
            SqlCommand cmd = new SqlCommand(cauLenh, conn);
            int kq = (int)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return kq;
        }

        public bool UpdateNhanVien(int idNhanVien, string hoten, string sdt, string gioitinh, DateTime ngaysinh, DateTime ngayvl, double luong, int idchucvu, string diachi, int trangThai)
        {
            try
            {
                DataRow dt = ds_QLTour.Tables["NhanVien"].Rows.Find(idNhanVien);

                if(dt != null)
                {
                    dt["HoTen"] = hoten;
                    dt["SDT"] = sdt;
                    dt["GioiTinh"] = gioitinh;
                    dt["NgaySinh"] = ngaysinh;
                    dt["NgayVaoLam"] = ngayvl;
                    dt["Luong"] = luong;
                    dt["idChucVu"] = idchucvu;
                    dt["DiaChi"] = diachi;
                    dt["TrangThai"] = trangThai;

                    string sql = "select * from NhanVien";

                    SqlDataAdapter da_Khoa = new SqlDataAdapter(sql, conn);

                    SqlCommandBuilder builder = new SqlCommandBuilder(da_Khoa);

                    da_Khoa.Update(ds_QLTour, "NhanVien");
                    LoadNhanVien();
                    return true;

                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaNhanVien(string ID)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string cauLenh = "delete from nhanvien where id_NhanVien='" + ID + "'";
                SqlCommand cmd = new SqlCommand(cauLenh, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                LoadNhanVien();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public NhanVienDTO getThongTinNV(string tenDangNhap)
        {
            NhanVienDTO nv = new NhanVienDTO();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                var command = new SqlCommand();
                command.Connection = conn;

                string sql = "set dateformat DMY select ID_NhanVien, HoTen, SDT, GioiTinh, NgaySinh, NgayVaoLam, Luong, TenChucVu, DiaChi, trangthainv.TrangThai, idChucVu from NhanVien, TaiKhoan, ChucVu, TrangThaiNV where ID_NhanVien = idNhanVien and idchucvu = ID_ChucVu and nhanvien.TrangThai = ID_TrangThai and TenDangNhap = '" + tenDangNhap + "'";
                command.CommandText = sql;

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        nv.ID_NhanVien = reader.GetInt32(0);
                        nv.HoTen = reader["HoTen"].ToString();
                        nv.SDT = reader["SDT"].ToString();
                        nv.GioiTinh = reader["GioiTinh"].ToString();
                        nv.NgaySinh = reader["NgaySinh"].ToString();
                        nv.NgayVaoLam = reader["NgayVaoLam"].ToString();
                        nv.Luong = int.Parse(reader["Luong"].ToString());
                        nv.TenChucVu = reader["TenChucVu"].ToString();
                        nv.DiaChi = reader["DiaChi"].ToString();
                        nv.TrangThai = reader["TrangThai"].ToString();
                        nv.IdChucVu = int.Parse(reader["idChucVu"].ToString());

                    }
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                //DataTable dt = new DataTable();

                //SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                //da.Fill(dt);
                //return new NhanVienDTO(dt.Rows[0]);
            }
            catch
            {
                return null;
            }
            return nv;
        }
        public int KTKNNhanVien_DKTour(int id)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string cauLenh = "SELECT COUNT(*) FROM DangKyTour WHERE idNhanVien = '" + id + "'";
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
        public int KTKNNhanVien_Tour(int id)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string cauLenh = "SELECT COUNT(*) FROM Tour WHERE idNhanVienDanDoan = '" + id + "' OR NguoiMo = '" + id + "'";
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
        public int KTKNNhanVien_DiaDiem(int id)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string cauLenh = "SELECT COUNT(*) FROM DiaDiem WHERE idNhanVien = '" + id + "'";
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
