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
    public class XuLy
    {
        public DataTable select(String sql)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
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
        public int count(String sql)
        {
            SqlConnection conn = null;
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int row = (int)cmd.ExecuteScalar();
            conn.Close();
            if (row > 0) return row;
            return 0;
        }
        public int delete(String sql)
        {
            SqlConnection conn = null;
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int row = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (row > 0) return row;
            return 0;
        }
        public int insert(String sql)
        {
            SqlConnection conn = null;
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int row = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (row > 0) return row;
            return 0;
        }
        public int guiThu(String name, String sdt, String email, String content)
        {
            SqlConnection conn = null;
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn.Open();
            String sql = "INSERT INTO LETTERS (NAME, EMAIL, NUMBERPHONE, CONTENT , TENKHONGDAU) VALUES(@NAME,@EMAIL,@NUMBERPHONE, @CONTENT,@TENKHONGDAU)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@NAME",name);
            cmd.Parameters.AddWithValue("@EMAIL",email);
            cmd.Parameters.AddWithValue("@NUMBERPHONE",sdt);
            cmd.Parameters.AddWithValue("@CONTENT",content);
            cmd.Parameters.AddWithValue("@TENKHONGDAU", Fun.convertToUnSign3(name));
            int row = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (row > 0) return row;
            return 0;
        }
        public DataTable selectThu(int offset, String search)//ok
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn.Open();
                String sql = "SELECT * FROM  LETTERS WHERE TENKHONGDAU LIKE '%'+@TEN+'%'ORDER BY ID_LETTER OFFSET @OFFSET ROWS FETCH NEXT 10 ROWS ONLY";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@OFFSET", offset);
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
        public DataTable selectDonHang(int offset, String search)//ok
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn.Open();
                String sql = "SELECT * FROM  ORDERS WHERE TENKHONGDAU LIKE '%'+@TEN+'%'ORDER BY ID_ORDER OFFSET @OFFSET ROWS FETCH NEXT 10 ROWS ONLY";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@OFFSET", offset);
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
        public DataTable selectDonHangDuyet(int offset, String search, int status)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn.Open();
                String sql = "SELECT * FROM  ORDERS WHERE STATUS = @STATUS AND TENKHONGDAU LIKE '%'+@TEN+'%'ORDER BY ID_ORDER OFFSET @OFFSET ROWS FETCH NEXT 10 ROWS ONLY";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@STATUS", status);
                cmd.Parameters.AddWithValue("@OFFSET", offset);
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
        public DataTable layDonHang(int id_user)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn.Open();
                String sql = "SELECT * FROM ORDERS WHERE ID_USER = @id_user AND DAY(NGAYMUA)  =  DAY(GETDATE()) ORDER BY NGAYMUA DESC";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_user", id_user);
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