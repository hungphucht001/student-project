using QUANLY_TOUR.DAO;
using QUANLY_TOUR.GUI.CrystalReport.FormCR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLY_TOUR.GUI
{
    public partial class fQuanLyDoanhThu : Form
    {
        public fQuanLyDoanhThu()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[5].DefaultCellStyle.Format = "0,0 đ";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "dd-MM-yyyy";

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void fQuanLyDoanhThu_Load(object sender, EventArgs e)
        {

        }


        private void btnXemDoanhThu_Click_1(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = TourDAO.Instance.LoadDoanhThu(dtpNgayBD.Text, dtpNgayKT.Text);
                txtSoVe.Text = dataGridView1.Rows.Count.ToString();
                double doanhThu = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    doanhThu += double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                }
                txtDoanhThu.Text = string.Format("{0:0,00} VNĐ", doanhThu);
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            fCRDoanhThu f = new fCRDoanhThu();
            f.ShowDialog();
        }
    }
}
