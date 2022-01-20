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
    public partial class fChinhSuaKhachSan : Form
    {
        private int idKhachSan;
        public fChinhSuaKhachSan(int idKhachSan)
        {
            this.idKhachSan = idKhachSan;
            InitializeComponent();
        }

        private void fChinhSuaKhachSan_Load(object sender, EventArgs e)
        {
            try
            {
                cbbKhuVuc.DataSource = KhuVucDAO.Instance.GetKhuVuc();
                cbbKhuVuc.DisplayMember = "TenKhuVuc";
                cbbKhuVuc.ValueMember = "ID_KhuVuc";

                var ks = KhachSanDAO.Instance.GetKhachSan().AsEnumerable().Where(t => t.Field<int>("ID_KhachSan") == idKhachSan).SingleOrDefault();

                txtTenKS.Text = ks.Field<string>("TenKhachSan");
                txtSDT.Text = ks.Field<string>("SDT");
                txtSoSao.Text = ks.Field<int>("SoSao").ToString();
                cbbKhuVuc.SelectedValue = ks.Field<int>("idKhuVuc");
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (txtTenKS.Text.Length == 0)
            {
                MessageBox.Show("Tên khách sạn không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtSoSao.Text.Length == 0)
            {
                MessageBox.Show("Số sao không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.Parse(txtSoSao.Text) < 0 || int.Parse(txtSoSao.Text) > 5)
            {
                MessageBox.Show("Số sao không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtSDT.Text.Length == 0)
            {
                MessageBox.Show("Số điện thoại không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtSDT.Text.Trim().Length > 10 || txtSDT.Text.Trim().Length < 9)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            KhachSanDTO ks = new KhachSanDTO(idKhachSan, txtTenKS.Text, int.Parse(txtSoSao.Text), int.Parse(cbbKhuVuc.SelectedValue.ToString()), txtSDT.Text, 1);
            int res = KhachSanDAO.Instance.UpdateKhachSan(ks);
            if (res == 0)
            {
                MessageBox.Show("Chỉnh sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else if(res == 1)
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
