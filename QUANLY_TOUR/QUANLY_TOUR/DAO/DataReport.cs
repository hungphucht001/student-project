using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLY_TOUR.DAO
{
    class DataReport:DataProvider
    {
        private static DataReport instance;
        public static DataReport Instance
        {
            get { if (instance == null) instance = new DataReport(); return instance; }
            set => instance = value;
        }

        public DataTable HoaDon(int idKhachHang, int idTour)
        {
            DataTable dt = new DataTable();
            string sql = "select ID_KhachHang, HoTen, SDT, ID_Tour, TenTour, NgayDK, NgayBD, NgayKT, Gia, GiamGia, (Gia - (Gia * GiamGia) / 100) as TongTien from KhachHang kh, DangKyTour dk, Tour t where kh.ID_KhachHang = dk.IdKhachHang and dk.IdTour = t.ID_Tour and ID_KhachHang = "+idKhachHang+" and ID_Tour = "+idTour ;
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(dt);

            return dt;
        }
        public DataTable DiaDiemByTour(int idTour)
        {
            DataTable dt = new DataTable();
            string sql = "select ID_DiaDiem, TenDiaDiem, dd.TrangThai, Mota, TenKhuVuc,tdd.NgayThem as NgayMo, TenTour, ID_Tour, Gia, GiamGia, SoVe, NgayBD, NgayKT, nv1.HoTen as NguoiMo, nv2.HoTen as NVDanDoan, ks.TenKhachSan, pt.TenPhuongTien, ttt.TrangThai from DiaDiem dd, Tour_DiaDiem tdd, KhuVuc kv, Tour t, NhanVien nv1, NhanVien nv2, TrangThaiTour ttt, KhachSan ks, PhuongTien pt  where dd.ID_DiaDiem = tdd.idDiaDiem and kv.ID_KhuVuc = dd.idKhuVuc and t.ID_Tour = tdd.idTour and nv1.ID_NhanVien = t.NguoiMo and nv2.ID_NhanVien = t.idNhanVienDanDoan and t.TrangThai = ttt.ID_TrangThai and t.idKhachSan = ks.ID_KhachSan and t.idPhuongTien = pt.ID_PhuongTien and ID_tour =" + idTour;
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(dt);

            return dt;
        }

        public DataTable ThongKeKhuVuc()
        {
            DataTable dt = new DataTable();
            string sql = "select TenKhuVuc, COUNT(*) as SoLuong from DiaDiem dd, KhuVuc kv where dd.idKhuVuc = kv.ID_KhuVuc group by TenKhuVuc";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(dt);

            return dt;
        }

    }
}
