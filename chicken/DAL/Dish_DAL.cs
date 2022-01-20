using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace chicken.DAL
{
    public class Dish_DAL
    {
        public DataTable selectCategorys()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn.Open();

                String sql = "SELECT * FROM CATEGORYS";
                
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
        public DataTable selectMenuByCategory(int id_category)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn.Open();

                String sql = "SELECT TOP 8 * FROM PRODUCTS where ID_CATEGORY = @ID_CATEGORY";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID_CATEGORY", id_category);

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
        public DataTable selectDish(int id_product)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn.Open();
                String sql = "SELECT * FROM PRODUCTS where ID_PRODUCTS = @ID_PRODUCTS";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID_PRODUCTS", id_product);
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
        public DataTable selectMenu(String tensp, int offset)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn.Open();


                String sql;
                if(tensp.Equals(""))
                {
                    sql = "SELECT * FROM PRODUCTS P, CATEGORYS C WHERE P.ID_CATEGORY = C.ID_CATEGORY ORDER BY p.ID_PRODUCTS OFFSET @OFFSET ROWS FETCH NEXT 10 ROWS ONLY";
                }
                else sql = "SELECT * FROM PRODUCTS P, CATEGORYS C WHERE P.ID_CATEGORY = C.ID_CATEGORY AND TENSP LIKE '%' + @TENSP + '%' ORDER BY p.ID_PRODUCTS OFFSET @OFFSET ROWS FETCH NEXT 10 ROWS ONLY";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@OFFSET", offset);
                if (!tensp.Equals(""))
                {
                    cmd.Parameters.AddWithValue("@TENSP", tensp);
                }
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
            public int saleAll(int number)
            {
                SqlConnection conn = null;
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn.Open();

                String sql = "UPDATE PRODUCTS SET SALE = @NUMBER";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NUMBER", number);
            

            int kq =  cmd.ExecuteNonQuery();
            conn.Close();
            return kq;
            }
        public int sale(String number, String id)
        {
            SqlConnection conn = null;
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn.Open();

            String sql = "UPDATE PRODUCTS SET SALE = @NUMBER WHERE ID_PRODUCTS = @ID_PRODUCTS";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@NUMBER", number);
            cmd.Parameters.AddWithValue("@ID_PRODUCTS", id);
            int kq = cmd.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
        public int countMenu(String n)
            {
                SqlConnection conn = null;
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn.Open();

            String sql;
            if (n.Equals(""))
            {
                sql = "SELECT COUNT(*) FROM PRODUCTS";
            }
            else sql = "SELECT COUNT(*) FROM PRODUCTS WHERE TENSP LIKE '%' + @N + '%'";

            SqlCommand cmd = new SqlCommand(sql, conn);
            if (!n.Equals(""))
            {
                cmd.Parameters.AddWithValue("@N", n);
            }
            int row = (int)cmd.ExecuteScalar();
            conn.Close();
            if (row > 0) return row;

            return 0;
            }
        public int deleteDish(int id)
        {
            SqlConnection conn = null;
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn.Open();

            String sql;
          
            sql = "DELETE PRODUCTS WHERE ID_PRODUCTS = @ID";

            SqlCommand cmd = new SqlCommand(sql, conn);
         
            cmd.Parameters.AddWithValue("@ID", id);

            int row = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (row > 0) return row;

            return 0;
        }
        public int themMonAn(String nameDish, String price, String sale, String content, String category, String describe, String unsignedName, String avatar)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn.Open();
                String sql = "INSERT INTO PRODUCTS(ID_CATEGORY,TENSP,TENKHONGGIAU,NOIDUNG,MOTA,AVATAR,GIA,SALE,NGAYMO) VALUES (@ID_CATEGORY,@TENSP,@TENKHONGGIAU,@NOIDUNG,@MOTA,@AVATAR,@GIA,@SALE, GETDATE())";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID_CATEGORY",category);
                cmd.Parameters.AddWithValue("@TENSP",nameDish);
                cmd.Parameters.AddWithValue("@TENKHONGGIAU",unsignedName);
                cmd.Parameters.AddWithValue("@NOIDUNG",content);
                cmd.Parameters.AddWithValue("@MOTA",describe);
                cmd.Parameters.AddWithValue("@AVATAR",avatar);
                cmd.Parameters.AddWithValue("@GIA",price);
                cmd.Parameters.AddWithValue("@SALE",sale);

                int row = cmd.ExecuteNonQuery();
                conn.Close();
                if (row > 0) return row;
                return 0;
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
        public int chinhSuaMonAn(String nameDish, String price, String sale, String content, String category, String describe, String unsignedName, String avatar, String id_products)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn.Open();

                String updateAvatar = "";
                if (!avatar.Equals("")) updateAvatar = "AVATAR = @AVATAR,";

                String sql = "UPDATE PRODUCTS SET ID_CATEGORY = @ID_CATEGORY,TENSP = @TENSP,TENKHONGGIAU = @TENKHONGGIAU,NOIDUNG = @NOIDUNG,MOTA = @MOTA,"+ updateAvatar + "GIA = @GIA ,SALE =@SALE WHERE ID_PRODUCTS = @ID_PRODUCTS";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID_CATEGORY", category);
                cmd.Parameters.AddWithValue("@TENSP", nameDish);
                cmd.Parameters.AddWithValue("@TENKHONGGIAU", unsignedName);
                cmd.Parameters.AddWithValue("@NOIDUNG", content);
                cmd.Parameters.AddWithValue("@MOTA", describe);
                if (!avatar.Equals("")) cmd.Parameters.AddWithValue("@AVATAR", avatar);
                cmd.Parameters.AddWithValue("@GIA", price);
                cmd.Parameters.AddWithValue("@SALE", sale);
                cmd.Parameters.AddWithValue("@ID_PRODUCTS", id_products);

                int row = cmd.ExecuteNonQuery();
                conn.Close();
                if (row > 0) return row;
                return 0;
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