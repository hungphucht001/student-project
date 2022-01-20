using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLY_TOUR.DTO
{
    class PhuongTienDTO
    {
        public int ID_PhuongTien { get; set; }
        public string TenPhuongTien { get; set; }
        public int ID_LoaiPT { get; set; }

        public PhuongTienDTO(DataRow r)
        {
            this.ID_PhuongTien = int.Parse(r["ID_PhuongTien"].ToString());
            this.TenPhuongTien = r["TenPhuongTien"].ToString();
            this.ID_LoaiPT = int.Parse(r["ID_LoaiPT"].ToString());
        }

        public PhuongTienDTO(int iD_PhuongTien, string tenPhuongTien, int iD_LoaiPT)
        {
            ID_PhuongTien = iD_PhuongTien;
            TenPhuongTien = tenPhuongTien;
            ID_LoaiPT = iD_LoaiPT;
        }

        public PhuongTienDTO(string tenPhuongTien, int iD_LoaiPT)
        {
            TenPhuongTien = tenPhuongTien;
            ID_LoaiPT = iD_LoaiPT;
        }
    }
}
