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
    class KhachSanDAO : DataProvider
    {
        private static KhachSanDAO instance;

        public static KhachSanDAO Instance
        {
            get { if (instance == null) instance = new KhachSanDAO(); return instance; }
            set => instance = value;
        }
        public KhachSanDAO()
        {
            LoadKhachSan();
        }
        public DataTable GetKhachSan(int idKV)
        {
            DataView dv = ds_QLTour.Tables["KhachSan"].DefaultView;
            dv.RowFilter = "idKhuVuc = " + idKV;
            return dv.ToTable();
        }
        public DataTable GetKhachSan()
        {
            return ds_QLTour.Tables["KhachSan"];
        }
        public DataTable GetKhachSana()
        {
            //string sql = "select top 3* from KhachSan";
            string sql = "SELECT ID_KhachSan, TenKhachSan, SoSao, SDT, TenKhuVuc, tt.TrangThai as TrangThai FROM KhachSan ks, KhuVuc kv, TrangThaiKS tt where ks.TrangThai = tt.ID_TrangThai and ID_KhuVuc = IdKhuVuc";
            SqlDataAdapter da_Khoa = new SqlDataAdapter(sql, conn);
            DataTable da = new DataTable();
            da_Khoa.Fill(da);
            return da;
        }
        public DataTable GetTrangThai()
        {
            string sql = "select * from TrangThaiKS";

            SqlDataAdapter da_Khoa = new SqlDataAdapter(sql, conn);

            DataTable da = new DataTable();
            da_Khoa.Fill(da);

            return da;
        }
        public void LoadKhachSan()
        {
            if(ds_QLTour.Tables["KhachSan"] != null)
            {
                ds_QLTour.Tables["KhachSan"].Rows.Clear();
            }

            string cauLeng = "select * from KhachSan";

            SqlDataAdapter da = new SqlDataAdapter(cauLeng, conn);

            da.Fill(ds_QLTour, "KhachSan");

            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLTour.Tables["KhachSan"].Columns[0];
            key[0].AutoIncrement = true;
            key[0].AutoIncrementSeed = GetNewID();
            key[0].AutoIncrementStep = 1;
            key[0].AllowDBNull = false;
            key[0].Unique = true;
            ds_QLTour.Tables["KhachSan"].PrimaryKey = key;
        }

        private long GetNewID()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string cauLenh = "select top 1 ID_KhachSan from KhachSan order by ID_KhachSan desc";
            SqlCommand cmd = new SqlCommand(cauLenh, conn);
            int kq = (int)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return kq + 1;
        }

        public DataTable GetKhachSanByTrangThai(int idTrangThai)
        {
            string sql = "select * from KhachSan, KhuVuc where idKhuVuc = ID_KhuVuc and TrangThai = "+ idTrangThai;

            SqlDataAdapter da_Khoa = new SqlDataAdapter(sql, conn);

            DataTable da = new DataTable();
            da_Khoa.Fill(da);

            return da;
        }
        public bool InsertKhachSan(KhachSanDTO ks)
        {
            try
            {
                DataRow dr = ds_QLTour.Tables["KhachSan"].NewRow();
                dr["TenKhachSan"] = ks.TenKhachSan;
                dr["SDT"] = ks.SDT;
                dr["SoSao"] = ks.SoSao;
                dr["idKhuVuc"] = ks.IdKhuVuc;
                dr["TrangThai"] = 1;

                ds_QLTour.Tables["KhachSan"].Rows.Add(dr);
                saveKhachSan();
                LoadKhachSan();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int UpdateKhachSan(KhachSanDTO ks)
        {
            try
            {
                DataRow dr = ds_QLTour.Tables["KhachSan"].Rows.Find(ks.ID_KhachSan);
                if(dr != null)
                {
                    dr["TenKhachSan"] = ks.TenKhachSan;
                    dr["SDT"] = ks.SDT;
                    dr["SoSao"] = ks.SoSao;
                    dr["idKhuVuc"] = ks.IdKhuVuc;
                    saveKhachSan();
                    return 0;
                }
                return 1;
            }
            catch
            {
                return -1;
            }
        }
        public int DeleteKhachSan(int idKhachSan)
        {
            try
            {
                DataRow dr = ds_QLTour.Tables["KhachSan"].Rows.Find(idKhachSan);
                if (dr != null)
                {
                    dr.Delete();
                    saveKhachSan();
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            catch
            {
                return -1;
            }
        }
        public int CancelKhachSan(int idKhachSan, int idTrangThai)
        {
            try
            {
                DataRow dr = ds_QLTour.Tables["KhachSan"].Rows.Find(idKhachSan);

                if (dr != null)
                {
                    dr["TrangThai"] = idTrangThai;
                    saveKhachSan();
                    return 0;
                }
                return 1;
            }
            catch
            {
                return -1;
            }
        }
        public bool CheckDeleteKS(int KhachSan)
        {
            DataTable dt = new DataTable();

            string sql = "select * from KhachSan ks, Tour t where ks.ID_KhachSan = t.idKhachSan and ID_KhachSan = "+KhachSan;

            SqlDataAdapter da_Khoa = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da_Khoa);
            da_Khoa.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        private void saveKhachSan()
        {
            string sql = "select * from KhachSan";

            SqlDataAdapter da_Khoa = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da_Khoa);
            da_Khoa.Update(ds_QLTour, "KhachSan");
        }
        public int KTKNKhachSan_Tour(int idKhachSan)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string cauLenh = "SELECT COUNT(*) FROM Tour WHERE idKhachSan = '" + idKhachSan + "'";
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
