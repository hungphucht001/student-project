using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLY_TOUR.DTO
{
    class DiaDiemDTO
    {
        public int ID_DiaDiem { get; set; }
        public string TenDiaDiem { get; set; }
        public int IdNhanVien { get; set; }
        public string TrangThai { get; set; }
        public string Mota { get; set; }
        public DateTime NgayThem { get; set; }
        public int idKhuVuc { get; set; }
        public DiaDiemDTO()
        {

        }
        public DiaDiemDTO(string tenDiaDiem, int idNhanVien, string trangThai, string mota, DateTime ngayThem, int idKhuVuc)
        {
            this.TenDiaDiem = tenDiaDiem;
            this.IdNhanVien = idNhanVien;
            this.TrangThai = trangThai;
            this.Mota = mota;
            this.NgayThem = ngayThem;
            this.idKhuVuc = idKhuVuc;
        }
        public DiaDiemDTO(int ID_DiaDiem, string tenDiaDiem, int idNhanVien, string trangThai, string mota, DateTime ngayThem, int idKhuVuc)
        {
            this.ID_DiaDiem = ID_DiaDiem;
            this.TenDiaDiem = tenDiaDiem;
            this.IdNhanVien = idNhanVien;
            this.TrangThai = trangThai;
            this.Mota = mota;
            this.NgayThem = ngayThem;
            this.idKhuVuc = idKhuVuc;
        }
    }
}
