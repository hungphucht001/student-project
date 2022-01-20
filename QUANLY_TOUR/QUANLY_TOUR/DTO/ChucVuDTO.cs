using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLY_TOUR.DTO
{
    class ChucVuDTO
    {
        public int ID_ChucVu { get; set; }
        public string TenChucVu { get; set; }

        
        public ChucVuDTO(DataRow r)
        {
            this.ID_ChucVu = int.Parse(r["ID_ChucVu"].ToString());
            this.TenChucVu = r["TenChucVu"].ToString();
        }

        public ChucVuDTO(int iD_ChucVu, string tenChucVu)
        {
            ID_ChucVu = iD_ChucVu;
            TenChucVu = tenChucVu;
        }
    }
}
