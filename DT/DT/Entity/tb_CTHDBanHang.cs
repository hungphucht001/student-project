//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DT.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_CTHDBanHang
    {
        public int MaHDBH { get; set; }
        public string IMEI { get; set; }
        public Nullable<int> MaSanPham { get; set; }
        public int ID_CTHD { get; set; }
        public Nullable<double> GiaBan { get; set; }
        public Nullable<int> SoLuong { get; set; }
    
        public virtual tb_SanPham tb_SanPham { get; set; }
        public virtual tb_HDBanHang tb_HDBanHang { get; set; }
    }
}
