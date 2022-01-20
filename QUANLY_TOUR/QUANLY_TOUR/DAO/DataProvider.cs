using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLY_TOUR.DAO
{
    public class DataProvider
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=ZOBAX\SQLEXPRESS;Initial Catalog=QL_TOUR;Integrated Security=True");
        protected DataSet ds_QLTour = new DataSet();
    }
}
