using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;
using chicken.App_Start;

namespace chicken.DAL
{
    public class News
    {
        public DataTable selectNews(int offset, String search, int limit)//ok
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn.Open();
                String sql = "SELECT * FROM NEWS N, MEMBERS M, USERS U WHERE N.ID_MEMBER = M.ID_MEMBER AND M.ID_USER = U.ID_USER AND N.TENKHONGDAU LIKE '%' + @TEN + '%' ORDER BY N.ID_NEWS OFFSET @OFSET ROWS FETCH NEXT @LIMIT ROWS ONLY";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@OFSET", offset);
                cmd.Parameters.AddWithValue("@LIMIT", limit);
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
        public int countNews(String search,int a)
        {
            SqlConnection conn = null;
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn.Open();

            String sql = "SELECT COUNT(*) FROM NEWS WHERE TEN LIKE '%'+ @SEARCH +'%'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@SEARCH",search);

            int row = (int)cmd.ExecuteScalar();
            conn.Close();
            if (row > 0) return row;

            return 0;
        }
        public DataTable randNewsRow()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn.Open();
                String sql = "SELECT top 4 * FROM NEWS N, MEMBERS M, USERS U WHERE N.ID_MEMBER = M.ID_MEMBER AND M.ID_USER = U.ID_USER ORDER BY newid()";

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
        public DataTable selectNewsItem(String id)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn.Open();

                String sql = "SELECT * FROM NEWS N, MEMBERS M, USERS U WHERE ID_NEWS = @ID AND N.ID_MEMBER = M.ID_MEMBER AND M.ID_USER = U.ID_USER ";

                SqlCommand cmd = new SqlCommand(sql, conn);
               
                    cmd.Parameters.AddWithValue("@ID", id);
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
        public int countNews(String n)
        {
            SqlConnection conn = null;
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn.Open();

            String sql;
            if (n.Equals(""))
            {
                sql = "SELECT COUNT(*) FROM NEWS";
            }
            else sql = "SELECT COUNT(*) FROM NEWS WHERE TENKHONGDAU LIKE '%' + @N + '%'";

            SqlCommand cmd = new SqlCommand(sql, conn);
            if (!n.Equals(""))
            {
                cmd.Parameters.AddWithValue("@N", Fun.convertToUnSign3(n));
            }
            int row = (int)cmd.ExecuteScalar();
            conn.Close();
            if (row > 0) return row;

            return 0;
        }
        public int deletenNews(int id)
        {
            SqlConnection conn = null;
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn.Open();

            String sql;

            sql = "DELETE NEWS WHERE ID_NEWS = @ID";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@ID", id);

            int row = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (row > 0) return row;

            return 0;
        }
        public int themBaiViet(String id_member, String ten, String tenkhongdau, String mota, String avatar, String gioithieu)
        {

            SqlConnection conn = null;
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn.Open();

            String sql;

            sql = "INSERT INTO NEWS(ID_MEMBER, TEN,TENKHONGDAU, MOTA, NGAYDANG,NGAYSUA,AVATAR,GIOITHIEU) VALUES(@ID_MEMBER, @TEN, @TENKHONGDAU, @MOTA, getdate(), getdate(), @AVATAR, @GIOITHIEU)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@ID_MEMBER", id_member);
            cmd.Parameters.AddWithValue("@TEN", ten);
            cmd.Parameters.AddWithValue("@TENKHONGDAU", tenkhongdau);
            cmd.Parameters.AddWithValue("@MOTA", mota);
            cmd.Parameters.AddWithValue("@AVATAR", avatar);
            cmd.Parameters.AddWithValue("GIOITHIEU", gioithieu);

            int row = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (row > 0) return row;

            return 0;
        }
        public int capNhatBaiViet(String id_member, String ten, String tenkhongdau, String mota, String avatar, String gioithieu, String id_news)
        {
            SqlConnection conn = null;
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn.Open();

            String updateAvatar = "";
            if (!avatar.Equals("")) updateAvatar = "AVATAR = @AVATAR,";
            String sql = "UPDATE NEWS SET ID_MEMBER = @ID_MEMBER, TEN = @TEN,TENKHONGDAU = @TENKHONGDAU, MOTA =  @MOTA, NGAYSUA = getdate()," + updateAvatar +  "GIOITHIEU = @GIOITHIEU WHERE ID_NEWS = @ID_NEWS";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@ID_MEMBER", id_member);
            cmd.Parameters.AddWithValue("@TEN", ten);
            cmd.Parameters.AddWithValue("@TENKHONGDAU", tenkhongdau);
            cmd.Parameters.AddWithValue("@MOTA", mota);
            if (!avatar.Equals("")) cmd.Parameters.AddWithValue("@AVATAR", avatar);
            cmd.Parameters.AddWithValue("@GIOITHIEU", gioithieu);
            cmd.Parameters.AddWithValue("@ID_NEWS", id_news);

            int row = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (row > 0) return row;

            return 0;
        }
    }
}