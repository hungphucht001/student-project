using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLY_TOUR.DTO
{
    class TaiKhoanDTO
    {
        public TaiKhoanDTO(string tenDangNhap, string matKhau, int idNhanVien)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            IdNhanVien = idNhanVien;
        }

        public TaiKhoanDTO(int iD_TaiKhoan, string tenDangNhap, string matKhau, int idNhanVien)
        {
            ID_TaiKhoan = iD_TaiKhoan;
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            IdNhanVien = idNhanVien;
        }

        public int ID_TaiKhoan { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public int IdNhanVien { get; set; }
    }
}
