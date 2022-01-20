using DT.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PagedList;

namespace DT.Entity.DAO
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;
        public static SanPhamDAO Instance
        {
            get { if (instance == null) instance = new SanPhamDAO(); return instance; }
            set => instance = value;
        }
        private dbPhoneStoreEntities db = new dbPhoneStoreEntities();

        

        //public List<tb_SanPham> getProductsLimit(bool isPhone = true)
        //{
        //    var modeltemp = db.tb_SanPham;
        //    var model = modeltemp.Where(x => x.MaDanhMuc == 1);
        //    if (!isPhone)
        //        model = modeltemp.Where(x => x.MaDanhMuc == 2);
        //   return model.OrderBy(x => x.ID).Skip(0).Take(8).ToList();
        //}
    }
}