using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DT.Models
{
    public class SanPham
    {
        public int ID { get; set; }
        public string TenSP { get; set; }
        public int ThgHieu { get; set; }
        public int MaDanhMuc { get; set; }
        public Nullable<int> Sale { get; set; }
        public Nullable<int> SoLuongTon { get; set; }
        public int ThoiGianBH { get; set; }
        public string UrlHinh { get; set; }
        public string MoTa { get; set; }
        public Nullable<int> TrangThai { get; set; }
        public string ThongSo { get; set; }
    }
}