using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLY_TOUR.DTO
{
    class KhachHangDTO
    {
        public KhachHangDTO(string hoTen, string sDT, string diaChi, string gioiTinh, DateTime ngaySinh)
        {
            HoTen = hoTen;
            SDT = sDT;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
        }

        public KhachHangDTO(int iD_KhachHang, string hoTen, string sDT, string diaChi, string gioiTinh, DateTime ngaySinh)
        {
            ID_KhachHang = iD_KhachHang;
            HoTen = hoTen;
            SDT = sDT;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
        }

        public int ID_KhachHang { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }

        public KhachHangDTO(DataRow r)
        {
            this.ID_KhachHang = int.Parse(r["ID_KhachHang"].ToString());
            this.HoTen = r["HoTen"].ToString();
            this.SDT = r["SDT"].ToString();
            this.DiaChi = r["DiaChi"].ToString();
            this.GioiTinh = r["GioiTinh"].ToString();
            this.NgaySinh = DateTime.Parse(r["NgaySinh"].ToString());
        }
    }
}
