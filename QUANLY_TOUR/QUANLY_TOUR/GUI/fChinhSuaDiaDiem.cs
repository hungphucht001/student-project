using QUANLY_TOUR.DAO;
using QUANLY_TOUR.DTO;
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
    public partial class fChinhSuaDiaDiem : Form
    {
        private int idDD;
        private object[] ltTrangThaiDD;
        public fChinhSuaDiaDiem(int idDD)
        {
            this.idDD = idDD;
            ltTrangThaiDD = new object[]{
            "Hoạt động",
            "Tạm ngưng",
            "Ngừng hoạt động"};
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLuuDD_Click(object sender, EventArgs e)
        {
            if (TextBoxIsEmpty(txtDiaDiem))
            {
                MessageBox.Show("Tên địa điểm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaDiem.Focus();
                return;
            }
            if (TextBoxIsEmpty(txtMoTa))
            {
                MessageBox.Show("Mô tả địa điểm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMoTa.Focus();
                return;
            }
            if (cbbKhuVucDiaDiem.SelectedValue == null)
            {
                MessageBox.Show("Khu vực không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ltTrangThaiDD.Where(t => t.Equals(cbbTrangThaiDD.Text)).Any())
            {
                MessageBox.Show("Trạng thái không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DiaDiemDTO dd = new DiaDiemDTO(idDD,txtDiaDiem.Text, 16, cbbTrangThaiDD.Text, txtMoTa.Text, dtpNgayThemDD.Value, int.Parse(cbbKhuVucDiaDiem.SelectedValue.ToString()));
            var res = DiaDiemDAO.Instance.UpdateDiaDiem(dd);
            if (res==0)
            {
                MessageBox.Show("Chỉnh sửa địa điểm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else if (res == 0)
            {
                MessageBox.Show("Địa điểm không tồn tại. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
            else{
                MessageBox.Show("Có lỗi xảy ra. Chỉnh sửa thất bại.", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool TextBoxIsEmpty(TextBox t)
        {
            if (t.Text != string.Empty) return false;
            return true;
        }

        private void fChinhSuaDiaDiem_Load(object sender, EventArgs e)
        {
            cbbTrangThaiDD.Items.AddRange(ltTrangThaiDD);

            cbbKhuVucDiaDiem.DataSource = KhuVucDAO.Instance.GetKhuVuc();
            cbbKhuVucDiaDiem.DisplayMember = "TenKhuVuc";
            cbbKhuVucDiaDiem.ValueMember = "ID_KhuVuc";
            cbbKhuVucDiaDiem.SelectedIndex = 0;

            var res = DiaDiemDAO.Instance.GetDiaDiem().AsEnumerable().Where(t => t.Field<int>("ID_DiaDiem") == idDD).SingleOrDefault();

            txtDiaDiem.Text = res.Field<string>("TenDiaDiem");
            txtMoTa.Text = res.Field<string>("MoTa");
            cbbKhuVucDiaDiem.SelectedValue = res.Field<int>("idKhuVuc");
            cbbTrangThaiDD.SelectedText = res.Field<string>("TrangThai");
            dtpNgayThemDD.Value = res.Field<DateTime>("NgayThem");
        }
    }
}
