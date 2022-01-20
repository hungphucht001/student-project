using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLY_TOUR.DAO
{
    class PhuongTienDAO:DataProvider
    {
        private static PhuongTienDAO instance;
        public static PhuongTienDAO Instance
        {
            get { if (instance == null) instance = new PhuongTienDAO(); return instance; }
            set => instance = value;
        }
        public PhuongTienDAO()
        {
            LoadPhuongTien();
        }
        public int GetNewID()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string cauLenh = "select top 1 ID_PhuongTien from PhuongTien order by ID_PhuongTien desc";
            SqlCommand cmd = new SqlCommand(cauLenh, conn);
            int kq = (int)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return kq+1;
        }
        public void LoadPhuongTien()
        {
            if (ds_QLTour.Tables["PhuongTien"] != null)
            {
                ds_QLTour.Tables["PhuongTien"].Rows.Clear();
            }
            string cauLeng = "select * from PhuongTien";

            SqlDataAdapter da = new SqlDataAdapter(cauLeng, conn);

            da.Fill(ds_QLTour, "PhuongTien");

            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLTour.Tables["PhuongTien"].Columns[0];
            key[0].AutoIncrement = true;
            key[0].AutoIncrementSeed = GetNewID();
            key[0].AutoIncrementStep = 1;
            key[0].AllowDBNull = false;
            key[0].Unique = true;
            ds_QLTour.Tables["PhuongTien"].PrimaryKey = key;
        }
        public DataTable GetPhuongTienLoaiPT()
        {
            DataTable dt = new DataTable();
            string cauLeng = "select ID_PhuongTien, TenPhuongTien, TenLoaiPT from PhuongTien pt, LoaiPT l where pt.ID_LoaiPT = l.ID_LoaiPT";

            SqlDataAdapter da = new SqlDataAdapter(cauLeng, conn);
            new SqlCommandBuilder(da);

            da.Fill(dt);
            return dt;
        }
        public DataTable GetPhuongTien()
        {
            return ds_QLTour.Tables["PhuongTien"];
        }
        public DataTable GetLoaiPT()
        {
            string sql = "select * from LoaiPT";

            SqlDataAdapter da_Khoa = new SqlDataAdapter(sql, conn);

            DataTable da = new DataTable();
            da_Khoa.Fill(da);

            return da;
        }
        public bool InsertPT(string tenPT, int loaiPT)
        {
            try
            {
                DataRow dr = ds_QLTour.Tables["PhuongTien"].NewRow();
                dr["TenPhuongTien"] = tenPT;
                dr["ID_LoaiPT"] = loaiPT;

                ds_QLTour.Tables["PhuongTien"].Rows.Add(dr);
                savePhuongTien();
                LoadPhuongTien();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int UpdatePhuongTien(int idPhuongTien, string tenPT, int loaiPT)
        {
            try
            {
                DataRow dr = ds_QLTour.Tables["PhuongTien"].Rows.Find(idPhuongTien);
                if (dr != null)
                {
                    dr["TenPhuongTien"] = tenPT;
                    dr["ID_LoaiPT"] = loaiPT;

                    savePhuongTien();
                    return 0;
                }
                return 1;
            }
            catch
            {
                return -1;
            }
        }
        public int XoaPhuongTien(string ID)
        {
            try
            {
                DataRow rowData = ds_QLTour.Tables["PhuongTien"].Rows.Find(ID);
                if(rowData != null)
                {
                    rowData.Delete();
                    savePhuongTien();
                    return 0;
                }
                return 1;
            }
            catch
            {
                return -1;
            }
        }
        public void savePhuongTien()
        {
            string sql = "select * from PhuongTien";
            SqlDataAdapter da_Khoa = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da_Khoa);
            da_Khoa.Update(ds_QLTour, "PhuongTien");
        }
        public int KTKNDPhuongTien_Tour(int id)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string cauLenh = "SELECT COUNT(*) FROM Tour WHERE idPhuongTien = '" + id + "'";
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
