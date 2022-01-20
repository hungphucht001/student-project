using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLY_TOUR.DTO
{
    class TourDiaDiemDTO
    {
        public TourDiaDiemDTO(int idTour, int idDiaDiem)
        {
            this.idTour = idTour;
            this.idDiaDiem = idDiaDiem;
        }

        public TourDiaDiemDTO(int idTour, int idDiaDiem, DateTime ngayThem)
        {
            this.idTour = idTour;
            this.idDiaDiem = idDiaDiem;
            NgayThem = ngayThem;
        }

        public TourDiaDiemDTO(int iD_TourDiaDiem, int idTour, int idDiaDiem, DateTime ngayThem)
        {
            ID_TourDiaDiem = iD_TourDiaDiem;
            this.idTour = idTour;
            this.idDiaDiem = idDiaDiem;
            NgayThem = ngayThem;
        }

        public int ID_TourDiaDiem { get; set; }
        public int idTour { get; set; }
        public int idDiaDiem { get; set; }
        public DateTime NgayThem { get; set; }
    }
}
