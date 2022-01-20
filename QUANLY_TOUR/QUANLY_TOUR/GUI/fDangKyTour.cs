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

using QUANLY_TOUR.DTO;
using QUANLY_TOUR.GUI.Design;

namespace QUANLY_TOUR.GUI
{
    public partial class fDangKyTour : Form
    {
        private DataTable dtTuor;
        private DataTable dtKH;
   
        XuLy xl = new XuLy();
        public fDangKyTour()
        {
            InitializeComponent();
            ThietKe.designDGV(dgvDsTour);
        }

        private void fDangKyTour_Load(object sender, EventArgs e)
        {
            dtTuor = TourDAO.Instance.GetTourChuaBD();
            dgvDsTour.AutoGenerateColumns = false;
            dgvDsTour.DataSource = dtTuor;

            dtKH = KhachHangDAO.Instance.GetKhachHang();
            dgvDSKH.AutoGenerateColumns = false;
            dgvDSKH.DataSource = dtKH;

            KiemTraDsRong();
        }

        private void rdbDaTung_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbDaTung.Checked)
            {
                pnDaTung.Visible = true;
                pnChuaTung.Visible = false;
            }
        }

        private void rdbChuaTung_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbChuaTung.Checked)
            {
                pnDaTung.Visible = false;
                pnChuaTung.Visible = true;
            }
        }

        public void KiemTraDsRong()
        {
            if(dgvDSKH.Rows.Count ==0 || dgvDsTour.Rows.Count == 0)
            {
                btnThem.Enabled = false;
            }    
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDsTour.DataSource = TourDAO.Instance.GetTourChuaBD();
            dgvDSKH.DataSource = KhachHangDAO.Instance.GetKhachHang();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtTuor.DefaultView;
            dv.RowFilter = string.Format("TenTour like '%{0}%'", txtTimKiem.Text);
            dgvDsTour.DataSource = dv.ToTable();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDsTour.SelectedRows.Count > 0)
                {
                    int id_Tour = int.Parse(dgvDsTour.CurrentRow.Cells[0].Value.ToString());
                    string tenTour = dgvDsTour.CurrentRow.Cells[1].Value.ToString();
                    NhanVienDTO nv = new NhanVienDTO();
                    nv = NhanVienDAO.Instance.getThongTinNV(fDangNhap.ptenDangNhap);
                    int id_NhanVien = nv.ID_NhanVien;
                    string ngayDK = DateTime.Today.ToString("yyyyMMdd");
                    int ktHetVe = TourDAO.Instance.KTHetVe(id_Tour);
                    if (rdbChuaTung.Checked)
                    {
                        string hoTen = txtHoTen.Text;
                        string sdt = txtSDT.Text;
                        string diaChi = txtDiaChi.Text;
                        string gioiTinh = string.Empty;
                        if (rdbNam.Checked) gioiTinh = "Nam";
                        else if (rdbNu.Checked) gioiTinh = "Nữ";
                        DateTime ngaySinh = dtpNgaySinh.Value;

                        if (hoTen == string.Empty)
                        {
                            MessageBox.Show("Họ tên không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (xl.checkSDT(sdt)==false)
                        {
                            MessageBox.Show("Số điện thoại không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        var today = DateTime.Today;
                        var age = today.Year - ngaySinh.Year;
                        if (age < 18)
                        {
                            MessageBox.Show("Tuổi phải từ 18", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (dtpNgaySinh.Value > DateTime.Now)
                        {
                            MessageBox.Show("Ngày sinh phải bé hơn ngày hiện tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }


                        if (sdt == string.Empty)
                        {
                            MessageBox.Show("Số điện thoại không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (KhachHangDAO.Instance.KTTrungSDT_KH(sdt) == 1)
                        {
                            MessageBox.Show("Số điện thoại '" + sdt + "' đang được sử dụng bởi 1 khách hàng khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (diaChi.Length == 0)
                        {
                            MessageBox.Show("Địa chỉ không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (gioiTinh.Length == 0)
                        {
                            MessageBox.Show("Bạn chưa chọn giới tính", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (MessageBox.Show("Bạn có muốn thêm tour '" + tenTour + "' cho khách hàng '" + hoTen + "' không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            if(ktHetVe == 1)
                            {
                                MessageBox.Show("Tour đã hết vé", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            KhachHangDTO kh = new KhachHangDTO(hoTen, sdt, diaChi, gioiTinh, ngaySinh);
                            bool kq = KhachHangDAO.Instance.themKhachHang(kh);
                            int id_KhachHang = KhachHangDAO.Instance.getIDKhachHang(sdt);
                            
                            bool kq2 = TourDAO.Instance.DangKyTour(id_Tour, id_KhachHang, id_NhanVien, ngayDK);
                            if (kq && kq2)
                            {
                                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvDsTour.DataSource = TourDAO.Instance.GetTourChuaBD();
                                dgvDSKH.DataSource = KhachHangDAO.Instance.GetKhachHang();
                            }
                            else MessageBox.Show("Có lỗi xảy ra vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (dgvDSKH.SelectedRows.Count > 0)
                        {
                            int id_KhachHang = int.Parse(dgvDSKH.CurrentRow.Cells[0].Value.ToString());
                            string tenKH = dgvDSKH.CurrentRow.Cells[1].Value.ToString();
                            if (MessageBox.Show("Bạn có muốn thêm tour '" + tenTour + "' cho khách hàng '" + tenKH + "' không", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                if (ktHetVe == 1)
                                {
                                    MessageBox.Show("Tour đã hết vé", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                int res = TourDAO.Instance.KiemTraKHDaDkTuor(id_Tour, id_KhachHang);
                                if (res == 0)
                                {
                                    if (TourDAO.Instance.DangKyTour(id_Tour, id_KhachHang, id_NhanVien, ngayDK))
                                    {
                                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        dgvDsTour.DataSource = TourDAO.Instance.GetTourChuaBD();
                                        dgvDSKH.DataSource = KhachHangDAO.Instance.GetKhachHang();

                                    }
                                    else MessageBox.Show("Có lỗi xảy ra vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else if (res == 1)
                                {
                                    MessageBox.Show("Khách hàng :" + tenKH + " đã đăng ký tour này.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                }
                                else MessageBox.Show("Có lỗi xảy ra vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra! Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

 

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //tìm kiếm khách hàng
            DataView dv = dtKH.DefaultView;
            dv.RowFilter = string.Format("SDT like '%{0}%'",textBox2.Text);
            dgvDSKH.DataSource = dv.ToTable();
        }
    }
}
