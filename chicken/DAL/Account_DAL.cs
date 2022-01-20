using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using chicken.App_Start;

namespace chicken.DAL
{
    public class Account_DAL
    {
        String message;
        public String Message { get { return Message; } set { message = value; } }

        public int checkUsername(String username, bool isKhacHang)
        {
            SqlConnection conn = null;
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn.Open();
            String sqlUsername;
            if (isKhacHang) sqlUsername = "SELECT COUNT(*) FROM CUSTOMER C, USERS U WHERE C.ID_USER = U.ID_USER AND [USERNAME] = @USERNAME";
            else sqlUsername = "SELECT COUNT(*) FROM MEMBERS M, USERS U WHERE M.ID_USER = U.ID_USER AND [USERNAME] = @USERNAME";
            SqlCommand cmdUser = new SqlCommand(sqlUsername, conn);
            cmdUser.Parameters.AddWithValue("@USERNAME", username);

            int row = (int)cmdUser.ExecuteScalar();
            conn.Close();
            if (row > 0) return row;

            return 0;
        }
        public int checkUser(String username)
        {
            SqlConnection conn = null;
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn.Open();
            String sqlUsername;
            sqlUsername = "SELECT COUNT(*) FROM USERS WHERE [USERNAME] = @USERNAME";
            SqlCommand cmdUser = new SqlCommand(sqlUsername, conn);
            cmdUser.Parameters.AddWithValue("@USERNAME", username);

            int row = (int)cmdUser.ExecuteScalar();
            conn.Close();
            if (row > 0) return row;

            return 0;
        }
        public int checkPassword(String username, String password)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn.Open();

                String sqlPassword = "SELECT * FROM USERS U WHERE [USERNAME] = @USERNAME AND [PASSWORD] = @PASSWORD";
                SqlCommand cmdPass = new SqlCommand(sqlPassword, conn);
                cmdPass.Parameters.AddWithValue("@USERNAME", username);
                cmdPass.Parameters.AddWithValue("@PASSWORD", Fun.EncryptPassword(password));

                SqlDataReader sqlReader = cmdPass.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    if (sqlReader.Read())
                    {
                        var idUser = sqlReader.GetInt32(0);
                        return idUser;
                    }
                }
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
        public DataTable selectUser(int idUser, bool isKhacHang)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn.Open();
                String sqlPassword;
                if (isKhacHang)
                {
                    sqlPassword = "SELECT * FROM CUSTOMER C, USERS U WHERE C.ID_USER = U.ID_USER AND U.ID_USER = @ID_USER";
                }
                else
                {
                    sqlPassword = "SELECT * FROM MEMBERS M, USERS U WHERE M.ID_USER = U.ID_USER AND U.ID_USER = @ID_USER";
                }
                SqlCommand cmdPass = new SqlCommand(sqlPassword, conn);
                cmdPass.Parameters.AddWithValue("@ID_USER", idUser);

                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmdPass);
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
        public int dangKyUser(String tDangNhap, String mKhau, String hTen, String sdt, String dChi,String ngaysinh, String gTinh, bool isKhach)
        {
        SqlConnection conn;
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn.Open();

            String sql = "INSERT INTO USERS (FULLNAME,NGAYSINH,GIOITINH,USERNAME,PASSWORD,SDT,DIACHI,TENKHONGDAU)VALUES(@TEN, @NGAYSINH, @GIOITINH, @TENDANGNHAP, @MATKHAU, @SDT, @DIACHI,@TENKHONGDAU)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TEN", hTen);
            cmd.Parameters.AddWithValue("@NGAYSINH", ngaysinh);
            cmd.Parameters.AddWithValue("@GIOITINH", gTinh);
            cmd.Parameters.AddWithValue("@TENDANGNHAP", tDangNhap);
            cmd.Parameters.AddWithValue("@MATKHAU", Fun.EncryptPassword(mKhau));
            cmd.Parameters.AddWithValue("@SDT", sdt);
            cmd.Parameters.AddWithValue("@DIACHI", dChi);
            cmd.Parameters.AddWithValue("@TENKHONGDAU", Fun.convertToUnSign3(hTen));

            int row = cmd.ExecuteNonQuery();
            conn.Close();
            if(row > 0)
            {
                if (isKhach)
                {
                    int id = idUser(tDangNhap);
                    if (dangKyKhachHang(id + "") > 0)
                    {
                        return 1;
                    }
                }
                return 1;
            }
            return 0;
        }
        public int dangKyKhachHang(String id)
        {
            SqlConnection conn;
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn.Open();

            String sql = "INSERT INTO CUSTOMER(ID_USER) VALUES(@ID)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID", id);

            int row = cmd.ExecuteNonQuery();
            conn.Close();

            return row;
        }
        public int idUser(String username)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn.Open();

                String sqlPassword = "SELECT * FROM USERS U WHERE [USERNAME] = @USERNAME";
                SqlCommand cmdPass = new SqlCommand(sqlPassword, conn);
                cmdPass.Parameters.AddWithValue("@USERNAME", username);

                SqlDataReader sqlReader = cmdPass.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    if (sqlReader.Read())
                    {
                        var idUser = sqlReader.GetInt32(0);
                        return idUser;
                    }
                }
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
        public int themNhanVien(String id_user, String chucvu)
        {
            SqlConnection conn;
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn.Open();

            String sql = "INSERT INTO MEMBERS (ID_USER,CHUCVU,NGAYVAOLAM) VALUES (@ID_USER, @CHUCVU, GETDATE())";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID_USER", id_user);
            cmd.Parameters.AddWithValue("@CHUCVU", chucvu);

            int row = cmd.ExecuteNonQuery();
            conn.Close();

            return row;
        }
        public int capNhatUser(String id_user, String ten, String ngaysinh, String gioitinh, String username, String password, String sdt, String diachi)
        {
            SqlConnection conn;
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn.Open();

            String sql = "UPDATE USERS SET FULLNAME = @FULLNAME, NGAYSINH = @NGAYSINH, GIOITINH = @GIOITINH,USERNAME = @USERNAME, PASSWORD = @PASSWORD, SDT = @SDT, DIACHI = @DIACHI, TENKHONGDAU = @TENKHONGDAU WHERE ID_USER = @ID_USER";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@FULLNAME", ten);
            cmd.Parameters.AddWithValue("@NGAYSINH", ngaysinh);
            cmd.Parameters.AddWithValue("@GIOITINH", gioitinh);
            cmd.Parameters.AddWithValue("@USERNAME", username);
            cmd.Parameters.AddWithValue("@PASSWORD", password);
            cmd.Parameters.AddWithValue("@SDT", sdt);
            cmd.Parameters.AddWithValue("@DIACHI", diachi);
            cmd.Parameters.AddWithValue("@ID_USER", id_user);
            cmd.Parameters.AddWithValue("@TENKHONGDAU", Fun.convertToUnSign3(ten));


            int row = cmd.ExecuteNonQuery();
            conn.Close();

            return row;
        }
        public int capNhatMember(String id_user, String chucvu)
        {
            SqlConnection conn;
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn.Open();
            String sql = "UPDATE MEMBERS SET CHUCVU = @CHUCVU WHERE ID_USER = @ID_USER";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CHUCVU", chucvu);
            cmd.Parameters.AddWithValue("@ID_USER", id_user);
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            return row;
        }
    }
}
