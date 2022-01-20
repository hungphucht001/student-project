using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLY_TOUR.DAO
{
    class ChucVuDAO : DataProvider
    {
        private static ChucVuDAO instance;

        public static ChucVuDAO Instance
        {
            get { if (instance == null) instance = new ChucVuDAO(); return instance; }
            set => instance = value;
        }
        public ChucVuDAO()
        {
            LoadChucVu();
        }
        public void LoadChucVu()
        {
            string sql = "select * from ChucVu";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(ds_QLTour, "ChucVu");

            DataColumn[] key = new DataColumn[1];

            key[0] = ds_QLTour.Tables["ChucVu"].Columns[0];

            ds_QLTour.Tables["ChucVu"].PrimaryKey = key;
        }
        public DataTable GetChucVu()
        {
            return ds_QLTour.Tables["ChucVu"];
        }
    }
}
