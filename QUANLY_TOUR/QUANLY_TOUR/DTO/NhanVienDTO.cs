using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QUANLY_TOUR.DTO
{
    public class NhanVienDTO
    {
        public int ID_NhanVien { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string NgayVaoLam { get; set; }
        public double Luong { get; set; }
        public string TenChucVu { get; set; }
        public string DiaChi { get; set; }
        public string TrangThai { get; set; }
        public int IdChucVu { get; set; }


        public NhanVienDTO()
        {

        }

        //public NhanVienDTO(DataRow r)
        //{
        //    this.ID_NhanVien = int.Parse(r["ID_NhanVien"].ToString());
        //    this.HoTen = r["HoTen"].ToString();
        //    this.SDT = r["SDT"].ToString();
        //    this.GioiTinh = r["GioiTinh"].ToString();
        //    this.NgaySinh = r["NgaySinh"].ToString();
        //    this.NgayVaoLam = r["NgayVaoLam"].ToString();
        //    this.Luong = double.Parse(r["Luong"].ToString());
        //    this.IdChucVu = int.Parse(r["idChucVu"].ToString());
        //    this.DiaChi = r["DiaChi"].ToString();
        //    this.TrangThai = int.Parse(r["TrangThai"].ToString());
        //}

        public NhanVienDTO(int iD_NhanVien, string hoTen, string sDT, string gioiTinh, string ngaySinh, string ngayVaoLam, double luong, string tenChucVu, string diaChi, string trangThai, int idChucVu)
        {
            ID_NhanVien = iD_NhanVien;
            HoTen = hoTen;
            SDT = sDT;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            NgayVaoLam = ngayVaoLam;
            Luong = luong;
            TenChucVu = tenChucVu;
            DiaChi = diaChi;
            TrangThai = trangThai;
            IdChucVu = idChucVu;
        }

        public NhanVienDTO(string hoTen, string sDT, string gioiTinh, string ngaySinh, string ngayVaoLam, double luong, string tenChucVu, string diaChi, string trangThai, int idChucVu)
        {
            HoTen = hoTen;
            SDT = sDT;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            NgayVaoLam = ngayVaoLam;
            Luong = luong;
            TenChucVu = tenChucVu;
            DiaChi = diaChi;
            TrangThai = trangThai;
            IdChucVu = idChucVu;
        }
    }
}
