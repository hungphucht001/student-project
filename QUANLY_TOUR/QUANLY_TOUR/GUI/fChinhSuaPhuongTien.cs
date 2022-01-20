using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLY_TOUR.DAO;

namespace QUANLY_TOUR.GUI
{
    public partial class fChinhSuaPhuongTien : Form
    {
        private int idPhuongTien;
        public fChinhSuaPhuongTien(int idPhuongTien)
        {
            this.idPhuongTien = idPhuongTien;
            InitializeComponent();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (txtTenPT.Text.Length == 0)
            {
                MessageBox.Show("Tên phương tiên không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboLoaiPT.SelectedValue == null)
            {
                MessageBox.Show("Loại phương tiện không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int res = PhuongTienDAO.Instance.UpdatePhuongTien(idPhuongTien, txtTenPT.Text, int.Parse(cboLoaiPT.SelectedValue.ToString()));
            if (res == 0)
            {
                MessageBox.Show("Chỉnh sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else if (res == 1)
            {
                MessageBox.Show("Khách sạn không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void fChinhSuaPhuongTien_Load(object sender, EventArgs e)
        {
            try
            {
                cboLoaiPT.DataSource = PhuongTienDAO.Instance.GetLoaiPT();
                cboLoaiPT.DisplayMember = "TenLoaiPT";
                cboLoaiPT.ValueMember = "ID_LoaiPT";

                var ks = PhuongTienDAO.Instance.GetPhuongTien().AsEnumerable().Where(t => t.Field<int>("ID_PhuongTien") == idPhuongTien).SingleOrDefault();

                txtTenPT.Text = ks.Field<string>("TenPhuongTien");
                cboLoaiPT.SelectedValue = ks.Field<int>("ID_LoaiPT");
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
