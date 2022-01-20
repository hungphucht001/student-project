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

namespace QUANLY_TOUR.GUI
{
    public partial class fThongKe : Form
    {
        public fThongKe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fThongKe_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            chart1.Series["age"].Points.Clear();
            int count = 0;
            foreach (DataRow r in DataReport.Instance.ThongKeKhuVuc().Rows)
            {
                chart1.Series["age"].Points.AddXY(r[0], r[1]);
                count += (int)r[1];
            }
            textBox1.Text = count.ToString();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
