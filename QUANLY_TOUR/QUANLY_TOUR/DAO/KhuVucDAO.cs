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
    class KhuVucDAO : DataProvider
    {
        private static KhuVucDAO instance;

        public static KhuVucDAO Instance
        {
            get { if (instance == null) instance = new KhuVucDAO(); return instance; }
            set => instance = value;
        }
        public KhuVucDAO()
        {
            LoadKhuVuc();
        }
        public void LoadKhuVuc()
        {
            string cauLeng = "select * from KhuVuc";

            SqlDataAdapter da = new SqlDataAdapter(cauLeng, conn);

            da.Fill(ds_QLTour, "KhuVuc");

            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLTour.Tables["KhuVuc"].Columns[0];
            key[0].AutoIncrement = true;
            ds_QLTour.Tables["KhuVuc"].PrimaryKey = key;
        }
        public DataTable GetKhuVuc()
        {
            return ds_QLTour.Tables["KhuVuc"];
        }

    }
}
