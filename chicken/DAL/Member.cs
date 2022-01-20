using chicken.App_Start;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace chicken.DAL
{
    public class Member
    {
        public DataTable selectMember(int offset, String search)//ok
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn.Open();
                String sql = "SELECT * FROM  MEMBERS M, USERS U WHERE M.ID_USER = U.ID_USER AND TENKHONGDAU LIKE '%' + @TEN + '%' ORDER BY ID_MEMBER OFFSET @OFSET ROWS FETCH NEXT 10 ROWS ONLY";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@OFSET", offset);
                cmd.Parameters.AddWithValue("@TEN", Fun.convertToUnSign3(search));
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
        public DataTable selectCustomer(int offset, String search)//ok
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn.Open();
                String sql = "SELECT * FROM  CUSTOMER C, USERS U WHERE C.ID_USER = U.ID_USER AND TENKHONGDAU LIKE '%' + @TEN + '%' ORDER BY ID_KHACHHANG OFFSET @OFSET ROWS FETCH NEXT 10 ROWS ONLY";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@OFSET", offset);
                cmd.Parameters.AddWithValue("@TEN", Fun.convertToUnSign3(search));
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
    }
}