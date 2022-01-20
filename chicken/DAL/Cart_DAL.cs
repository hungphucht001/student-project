using chicken.App_Start;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace chicken.DAL
{
    public class Cart_DAL
    {
        public int insertOrder(String id_order, String id_user, String ten, String sdt, String diachi, String ghichu)
        {
            SqlConnection conn;
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn.Open();

            String sql = "INSERT INTO ORDERS (ID_ORDER, ID_USER, NGAYMUA,HOTEN,SDT,DIACHI,GHICHU,TENKHONGDAU)VALUES(@ID_ORDER, @ID_USER, GETDATE(), @TEN, @SDT, @DIACHI, @GHICHU,@TENKHONGDAU)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            DbParameter paramIdUser = cmd.CreateParameter();
            paramIdUser.ParameterName = "@ID_USER";
            paramIdUser.Value = string.IsNullOrEmpty(id_user) ? (object)DBNull.Value : id_user;

            DbParameter paramGhiChu = cmd.CreateParameter();
            paramGhiChu.ParameterName = "@GHICHU";
            paramGhiChu.Value = string.IsNullOrEmpty(ghichu) ? (object)DBNull.Value : ghichu;

            cmd.Parameters.AddWithValue("@ID_ORDER", id_order);
            cmd.Parameters.Add(paramIdUser);
            cmd.Parameters.AddWithValue("@TEN", ten);
            cmd.Parameters.AddWithValue("@SDT", sdt);
            cmd.Parameters.AddWithValue("@DIACHI", diachi);
            cmd.Parameters.AddWithValue("@TENKHONGDAU", Fun.convertToUnSign3(ten));
            cmd.Parameters.Add(paramGhiChu);

            int row = cmd.ExecuteNonQuery();
            conn.Close();
            
            return row;
        }
    }
}