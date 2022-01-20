using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLY_TOUR.DTO
{
    class KhachSanDTO
    {
        public int ID_KhachSan { get; set; }
        public string TenKhachSan { get; set; }
        public int SoSao { get; set; }
        public int IdKhuVuc { get; set; }
        public string SDT { get; set; }
        public int TrangThai { get; set; }
        public KhachSanDTO(DataRow r)
        {
            this.ID_KhachSan = int.Parse(r["ID_KhachSan"].ToString());
            this.TenKhachSan = r["TenKhachSan"].ToString();
            this.SoSao = int.Parse(r["SoSao"].ToString());
            this.IdKhuVuc = int.Parse(r["IdKhuVuc"].ToString());
            this.SDT = r["SDT"].ToString();
            this.TrangThai = int.Parse(r["TrangThai"].ToString());
        }

        public KhachSanDTO(int iD_KhachSan, string tenKhachSan, int soSao, int idKhuVuc, string sDT, int trangThai)
        {
            ID_KhachSan = iD_KhachSan;
            TenKhachSan = tenKhachSan;
            SoSao = soSao;
            IdKhuVuc = idKhuVuc;
            SDT = sDT;
            TrangThai = trangThai;
        }

        public KhachSanDTO(string tenKhachSan, int soSao, int idKhuVuc, string sDT, int trangThai)
        {
            TenKhachSan = tenKhachSan;
            SoSao = soSao;
            IdKhuVuc = idKhuVuc;
            SDT = sDT;
            TrangThai = trangThai;
        }
    }
}
