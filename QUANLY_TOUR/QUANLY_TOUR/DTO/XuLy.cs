using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLY_TOUR.DAO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace QUANLY_TOUR.DTO
{
    public class XuLy:DataProvider
    {
        
        public bool ktraDangNhap(string user, string psw)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string cauLenh = "SELECT COUNT(*) FROM TAIKHOAN WHERE TENDANGNHAP = '" + user + "' AND MATKHAU = '" + EncodeSHA1(psw) + "'";
                SqlCommand cmd = new SqlCommand(cauLenh, conn);
                int kq = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                if (kq >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }


        public bool checkSDT(string number)
        {
            string motif = "^[0-9]{10,11}$";
            if (number != null) return Regex.IsMatch(number, motif);
            else return false;
        }
        public bool checkTenDangNhap(string data)
        {
            string motif = "^[a-zA-Z0-9]{3,20}$";
            if (data != null) return Regex.IsMatch(data, motif);
            else return false;
        }
        public bool checkHoTen(string data)
        {
            string motif = @"^(\p{L}+\s?){1,100}$";
            if (data != null) return Regex.IsMatch(data, motif);
            else return false;
        }
        public bool checkDiaChi(string data)
        {
            string motif = @"^(\p{L}+\s?){1,250}$";
            if (data != null) return Regex.IsMatch(data, motif);
            else return false;
        }
        public string EncodeSHA1(string pass)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(pass);
            bs = sha1.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x1").ToLower());
            }
            pass = s.ToString();
            return pass;
        }
    }
}
