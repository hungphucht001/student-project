using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLY_TOUR.DTO
{
    class KhuVucDTO
    {
        public int ID_KhuVuc { get; set; }
        public string TenKhuVuc { get; set; }

        public KhuVucDTO(DataRow r)
        {
            this.ID_KhuVuc = int.Parse(r["ID_KhuVuc"].ToString());
            this.TenKhuVuc = r["TenKhuVuc"].ToString();
        }
        public KhuVucDTO(int iD_KhuVuc, string tenKhuVuc)
        {
            ID_KhuVuc = iD_KhuVuc;
            TenKhuVuc = tenKhuVuc;
        }
    }
}
