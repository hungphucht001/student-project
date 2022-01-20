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
    public partial class fCRDoanhThu : Form
    {
        CRDoanhThu rpt = new CRDoanhThu();
        public fCRDoanhThu()
        {
            InitializeComponent();
        }

        private void btnXemDoanhThu_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            rpt.SetDataSource(TourDAO.Instance.LoadDoanhThu(dtpNgayBD.Text, dtpNgayKT.Text));

            crystalReportViewer1.ReportSource = rpt;

            rpt.SetDatabaseLogon("sa", "123", @"ZOBAX\SQLEXPRESS", "QL_Tour");

            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();
        }

        private void fCRDoanhThu_Load(object sender, EventArgs e)
        {
            dtpNgayBD.Value = DateTime.Now.AddDays(-30);
            LoadData();
        }
    }
}
