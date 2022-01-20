using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLY_TOUR.DTO
{
    class DangKyTourDTO
    {
        public DangKyTourDTO(int idTour, int idKhachHang, int idNhanVien, DateTime ngayDK)
        {
            IdTour = idTour;
            IdKhachHang = idKhachHang;
            IdNhanVien = idNhanVien;
            NgayDK = ngayDK;
        }

        public DangKyTourDTO(int iD_DangKyTour, int idTour, int idKhachHang, int idNhanVien, DateTime ngayDK)
        {
            ID_DangKyTour = iD_DangKyTour;
            IdTour = idTour;
            IdKhachHang = idKhachHang;
            IdNhanVien = idNhanVien;
            NgayDK = ngayDK;
        }

        public int ID_DangKyTour { get; set; }
        public int IdTour { get; set; }
        public int IdKhachHang { get; set; }
        public int IdNhanVien { get; set; }
        public DateTime NgayDK { get; set; }
    }
}
