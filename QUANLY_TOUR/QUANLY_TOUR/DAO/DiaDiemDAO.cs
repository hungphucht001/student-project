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
    class DiaDiemDAO : DataProvider
    {
        private static DiaDiemDAO instance;
        private string query = "select * from DiaDiem";
        public static DiaDiemDAO Instance
        {
            get { if (instance == null) instance = new DiaDiemDAO(); return instance; }
            set => instance = value;
        }

        public DiaDiemDAO()
        {
            LoadDiaDiem();
        }

        public void LoadDiaDiem()
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conn);

            da.Fill(ds_QLTour, "DiaDiem");

            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLTour.Tables["DiaDiem"].Columns[0];
            key[0].AutoIncrement = true;
            key[0].AutoIncrementSeed = GetNewID();
            key[0].AutoIncrementStep = 1;
            key[0].AllowDBNull = false;
            key[0].Unique = true;
            ds_QLTour.Tables["DiaDiem"].PrimaryKey = key;
        }

        private int GetNewID()
        {
            
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string cauLenh = "select top 1 ID_DiaDiem from DiaDiem order by ID_DiaDiem desc";
            SqlCommand cmd = new SqlCommand(cauLenh, conn);
            int kq = (int)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return kq + 1;
        }

        public DataTable GetDiaDiem(int idKV)
        {
            string sql = "select * from DiaDiem, KhuVuc where idKhuVuc = ID_KhuVuc and idKhuVuc = " + idKV;
            SqlDataAdapter da_Khoa = new SqlDataAdapter(sql, conn);
            DataTable da = new DataTable();
            da_Khoa.Fill(da);
            return da;
        }

        public DataTable GetDiaDiem()
        {
            string sql = "select * from DiaDiem dd, NhanVien nv, KhuVuc kv where dd.IdNhanVien = nv.ID_NhanVien and kv.ID_KhuVuc =  dd.idKhuVuc";
            SqlDataAdapter da_Khoa = new SqlDataAdapter(sql, conn);
            DataTable da = new DataTable();
            da_Khoa.Fill(da);
            return da;
        }
        public DataTable GetDiaDiemByIdTour(int idTour)
        {
            string sql = "select dd.*,kv.TenKhuVuc, tdd.NgayThem as NgayMo from DiaDiem dd, Tour_DiaDiem tdd, KhuVuc kv where dd.ID_DiaDiem = tdd.idDiaDiem and kv.ID_KhuVuc = idKhuVuc and idTour ="+idTour;
            SqlDataAdapter da_Khoa = new SqlDataAdapter(sql, conn);
            DataTable da = new DataTable();
            da_Khoa.Fill(da);
            return da;
        }
        public bool InsertDiaDiem(DiaDiemDTO dd)
        {
            try
            {
                DataRow dr = ds_QLTour.Tables["DiaDiem"].NewRow();

                dr["TenDiaDiem"] = dd.TenDiaDiem;
                dr["NgayThem"] = dd.NgayThem;
                dr["Mota"] = dd.Mota;
                dr["TrangThai"] = dd.TrangThai;
                dr["idKhuVuc"] = dd.idKhuVuc;
                dr["IdNhanVien"] = dd.IdNhanVien;

                ds_QLTour.Tables["DiaDiem"].Rows.Add(dr);

                saveDiaDiem();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int UpdateDiaDiem(DiaDiemDTO dd)
        {
            try
            {
                DataRow dr = ds_QLTour.Tables["DiaDiem"].Rows.Find(dd.ID_DiaDiem);

                if(dr != null)
                {
                    dr["TenDiaDiem"] = dd.TenDiaDiem;
                    dr["NgayThem"] = dd.NgayThem;
                    dr["Mota"] = dd.Mota;
                    dr["TrangThai"] = dd.TrangThai;
                    dr["idKhuVuc"] = dd.idKhuVuc;
                    dr["IdNhanVien"] = dd.IdNhanVien;

                    saveDiaDiem();
                    return 0;
                }
                return 1;
            }
            catch
            {
                return -1;
            }
        }

        public int DeletetDiaDiem(int idTour)
        {
            try
            {
                if (checkDelete(idTour))
                {
                    DataRow dr = ds_QLTour.Tables["DiaDiem"].Rows.Find(idTour);

                    if (dr != null)
                    {
                        dr.Delete();
                        saveDiaDiem();
                        return 0;
                    }
                }
                return 1;
            }
            catch
            {
                return -1;
            }
        }

        public void saveDiaDiem()
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            new SqlCommandBuilder(da);
            da.Update(ds_QLTour, "DiaDiem");
        }

        public bool checkDelete(int idTour)
        {
            string sql = "select * from Tour_DiaDiem where idTour = " + idTour;
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return true;
            }
            return false;
        }

        public int XoaTourDiaDiem(TourDiaDiemDTO t)
        {
            try
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql = "delete Tour_DiaDiem where idTour = " + t.idTour + " and idDiaDiem = " + t.idDiaDiem;
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

        public int ThemDiaDiem(TourDiaDiemDTO t)
        {
            try
            {
                string sql = "SET DATEFORMAT DMY insert into Tour_DiaDiem (idTour, idDiaDiem, NgayThem) values(" + t.idTour + "," +t.idDiaDiem + ",Getdate())";

                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int res = cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open) conn.Close();
                return res;
            }
            catch
            {
                return -1;
            }
        }
        public int KTKNDiaDiem_TourDiaDiem(int idDiaDiem)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string cauLenh = "SELECT COUNT(*) FROM Tour_DiaDiem WHERE idDiaDiem = '" + idDiaDiem + "'";
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
