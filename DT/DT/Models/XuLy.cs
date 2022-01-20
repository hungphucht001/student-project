using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace DT.Models
{
    public class XuLy
    {
        private static XuLy instance;
        public static XuLy Instance
        {
            get { if (instance == null) instance = new XuLy(); return instance; }
            set => instance = value;
        }
        public string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D').Replace(" ","-").Replace("|","-").Replace("/", "-");
        }
    }
}