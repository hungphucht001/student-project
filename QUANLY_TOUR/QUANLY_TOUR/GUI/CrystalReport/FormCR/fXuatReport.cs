using QUANLY_TOUR.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLY_TOUR.GUI.CrystalReport.FormCR
{
    public partial class fXuatReport : Form
    {
        public fXuatReport()
        {
            InitializeComponent();
        }

        private void fXuatReport_Load(object sender, EventArgs e)
        {

            
        }
        public void loadHoaDon(int idKhachHang, int idTour)
        {
            CRHoaDon rpt = new CRHoaDon();

            rpt.SetDataSource(DataReport.Instance.HoaDon(idKhachHang, idTour));

            crystalReportViewer1.ReportSource = rpt;

            rpt.SetDatabaseLogon("sa", "123", @"ZOBAX\SQLEXPRESS", "QL_Tour");

            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();
        }
        public void loadDiaDiem(int idTour)
        {
            CRDiaDiemTour rpt = new CRDiaDiemTour();

            rpt.SetDataSource(DataReport.Instance.DiaDiemByTour(idTour));

            crystalReportViewer1.ReportSource = rpt;

            rpt.SetDatabaseLogon("sa", "123", @"ZOBAX\SQLEXPRESS", "QL_Tour");

            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();
        }
        public void loadKhachSan()
        {
            CRKhachSan rpt = new CRKhachSan();

            rpt.SetDataSource(KhachSanDAO.Instance.GetKhachSana());

            crystalReportViewer1.ReportSource = rpt;

            rpt.SetDatabaseLogon("sa", "123", @"ZOBAX\SQLEXPRESS", "QL_Tour");

            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();
        }
    }
}
