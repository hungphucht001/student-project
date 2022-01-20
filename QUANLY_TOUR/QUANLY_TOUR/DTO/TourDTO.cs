using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLY_TOUR.DTO
{
    class TourDTO
    {
        public int ID_Tour { get; set; }
        public DateTime NgayBD { get; set; }
        public DateTime NgayKT { get; set; }
        public int SoVe { get; set; }
        public int idPhuongTien { get; set; }
        public int idKhachSan { get; set; }
        public int idNhanVienDanDoan { get; set; }
        public float Gia { get; set; }
        public int GiamGia { get; set; }
        public int NguoiMo { get; set; }
        public string TenTour { get; set; }
        public int TrangThai { get; set; }
        public TourDTO(DateTime ngayBD, DateTime ngayKT, int soVe, int idPhuongTien, int idKhachSan, int idNhanVienDanDoan, float gia, int giamGia, int nguoiMo, string tenTour, int trangThai)
        {
            this.NgayBD = ngayBD;
            this.NgayKT = ngayKT;
            this.SoVe = soVe;
            this.idPhuongTien = idPhuongTien;
            this.idKhachSan = idKhachSan;
            this.idNhanVienDanDoan = idNhanVienDanDoan;
            this.Gia = gia;
            this.GiamGia = giamGia;
            this.NguoiMo = nguoiMo;
            this.TenTour = tenTour;
            this.TrangThai = trangThai;
        }

        public TourDTO(int iD_Tour, DateTime ngayBD, DateTime ngayKT, int soVe, int idPhuongTien, int idKhachSan, int idNhanVienDanDoan, float gia, int giamGia, int nguoiMo, string tenTour, int trangThai)
        {
            this.ID_Tour = iD_Tour;
            this.NgayBD = ngayBD;
            this.NgayKT = ngayKT;
            this.SoVe = soVe;
            this.idPhuongTien = idPhuongTien;
            this.idKhachSan = idKhachSan;
            this.idNhanVienDanDoan = idNhanVienDanDoan;
            this.Gia = gia;
            this.GiamGia = giamGia;
            this.NguoiMo = nguoiMo;
            this.TenTour = tenTour;
            this.TrangThai = trangThai;
        }

        
        public TourDTO(DataRow r)
        {
            this.ID_Tour = int.Parse(r["ID_Tour"].ToString());
            this.NgayBD = DateTime.Parse(r["NgayBD"].ToString());
            this.NgayKT = DateTime.Parse(r["NgayKT"].ToString());
            this.SoVe = int.Parse(r["SoVe"].ToString());
            this.idPhuongTien = int.Parse(r["idPhuongTien"].ToString());
            this.idKhachSan = int.Parse(r["idKhachSan"].ToString());
            this.idNhanVienDanDoan = int.Parse(r["idNhanVienDanDoan"].ToString());
            this.Gia = float.Parse(r["Gia"].ToString());
            this.GiamGia = int.Parse(r["GiamGia"].ToString());
            this.NguoiMo = int.Parse(r["NguoiMo"].ToString());
            this.TenTour = r["TenTour"].ToString();
            this.TrangThai = int.Parse(r["TrangThai"].ToString());
        }
    }
}
