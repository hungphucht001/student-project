using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace chicken.App_Start
{
    public class Fun
    {
        public static string EncryptPassword(string input)
        {
            MD5 encrypt = MD5.Create();
            byte[] hashCode = encrypt.ComputeHash(Encoding.Unicode.GetBytes(input));

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < hashCode.Length; i++)
            {
                stringBuilder.Append(hashCode[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }
        public static String ranString()
        {
            Random ran = new Random();
            String b = "abcdefghijklmnopqrstuvwxyz1234567890ZXCVBNMASDFGHJKLPOIUYTREWQ";
            int length = 10;
            String id_random = "MH01_";
            for (int i = 0; i < length; i++)
            {
                int a = ran.Next(26);
                id_random = id_random + b.ElementAt(a);
            }
            return id_random;
        }
        public static String fromatMoney(String mon)
        {
            String newMoney = "";
            newMoney = string.Format("{0:C}", Convert.ToDecimal(mon)).Replace("$", "").Replace(",", ".");
            newMoney = newMoney.Substring(0, newMoney.Length - 3) + " đ";
            return newMoney;
        }
        public static string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            String ky = regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
            return ky.Replace(" ", "-");
        }

    }
}