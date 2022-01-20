using DT.Entity;
using DT.Entity.DAO;
using DT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DT.Controllers
{
    public class ProductApiController : ApiController
    {
        // GET api/<controller>
        dbPhoneStoreEntities db = new dbPhoneStoreEntities();
        public List<SanPham> GetPhone(int page = 1)
        {
            int pageSize = 12;
            var list = from a in db.tb_SanPham
                       select new SanPham()
                       {
                           ID = a.ID,
                           TenSP = a.TenSP,
                           Sale = a.Sale,
                           ThgHieu = a.ThgHieu,
                           MaDanhMuc = a.MaDanhMuc,
                           SoLuongTon = a.SoLuongTon,
                           ThoiGianBH = a.ThoiGianBH,
                           UrlHinh = a.UrlHinh,
                           MoTa = a.MoTa,
                           TrangThai = a.TrangThai,
                           ThongSo = a.ThongSo
                       };

            return list.OrderBy(t=>t.ID).Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }

    }
}