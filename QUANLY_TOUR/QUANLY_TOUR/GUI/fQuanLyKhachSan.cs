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
using QUANLY_TOUR.DTO;
using QUANLY_TOUR.GUI.CrystalReport.FormCR;
using QUANLY_TOUR.GUI.Design;

namespace QUANLY_TOUR.GUI
{
    public partial class fQuanLyKhachSan : Form
    {
        XuLy xl = new XuLy();
        DataTable dt;
        public fQuanLyKhachSan()
        {
            InitializeComponent();
            ThietKe.designDGV(dgvKhachSan);
        }

        private void fQuanLyKhachSan_Load(object sender, EventArgs e)
        {
            cbbKhuVuc.DataSource = KhuVucDAO.Instance.GetKhuVuc();
            cbbKhuVuc.DisplayMember = "TenKhuVuc";
            cbbKhuVuc.ValueMember = "ID_KhuVuc";
            cbbKhuVuc.SelectedIndex = 0;

            cbbTrangThai.DataSource = KhachSanDAO.Instance.GetTrangThai();
            cbbTrangThai.DisplayMember = "TrangThai";
            cbbTrangThai.ValueMember = "ID_TrangThai";
            cbbTrangThai.SelectedIndex = 0;
            txtTenKS.Focus();
        }

        public void loadData()
        {
            cbbTrangThai.DisplayMember = "TrangThai";
            cbbTrangThai.ValueMember = "ID_TrangThai";
            dgvKhachSan.AutoGenerateColumns = false;
            dt = KhachSanDAO.Instance.GetKhachSanByTrangThai(int.Parse(cbbTrangThai.SelectedValue.ToString()));
            dgvKhachSan.DataSource = dt;
        }
        private void clear()
        {
            txtSDT.Clear();
            txtSoSao.Clear();
            txtTenKS.Clear();
            cbbKhuVuc.SelectedItem = null;
            txtTenKS.Focus();
        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachSan.SelectedRows.Count > 0)
            {
                if (cbbTrangThai.SelectedIndex == 0) Cancel();
                else Cancel(1);
            }
        }

        private void cbbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTrangThai.SelectedIndex == 0)
                btnHuyHopTac.Text = "Hủy hợp tác";
            else btnHuyHopTac.Text = "Hợp tác";
            loadData();
        }
        private void Cancel(int idTrangThai = 2)
        {
            int idKhachSan = int.Parse(dgvKhachSan.CurrentRow.Cells[0].Value.ToString());
            int res = KhachSanDAO.Instance.CancelKhachSan(idKhachSan, idTrangThai);

            string tt = "Hủy hợp tác";
            if (idTrangThai == 1) tt = "Hợp tác";

            if (res == 0)
                MessageBox.Show(tt+" thành công");
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
            loadData();
        }
 
        private void txtSoSao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThem_KH_Click(object sender, EventArgs e)
        {
            //SỬa
            if (dgvKhachSan.SelectedRows.Count > 0)
            {
                int idKhachSan = int.Parse(dgvKhachSan.CurrentRow.Cells[0].Value.ToString());
                fChinhSuaKhachSan f = new fChinhSuaKhachSan(idKhachSan);
                f.ShowDialog();
                loadData();
            }
        }

        private void btnSua_KH_Click(object sender, EventArgs e)
        {
            //XÓa
            if (dgvKhachSan.SelectedRows.Count > 0)
            {
                string tenKS = dgvKhachSan.CurrentRow.Cells[1].Value.ToString();
                int idKs = int.Parse(dgvKhachSan.CurrentRow.Cells[0].Value.ToString());
                if (KhachSanDAO.Instance.KTKNKhachSan_Tour(idKs)==1)
                {
                    MessageBox.Show("Không thể xóa do khách sạn đang được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xóa khách sạn: "+ tenKS+" không?", "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (!KhachSanDAO.Instance.CheckDeleteKS(idKs))
                    {
                        int kq = KhachSanDAO.Instance.DeleteKhachSan(idKs);
                        if (kq == 0)
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData();
                        }
                        else if (kq == 1)
                        {
                            MessageBox.Show("Khách sạn không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa khách sạn này. Bạn có thể hủy hợp tác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        //Thêm ks
        private void button1_Click_1(object sender, EventArgs e)
        {
            //Them
            if (txtTenKS.Text == string.Empty)
            {
                MessageBox.Show("Tên khách sạn không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSoSao.Text == string.Empty)
            {
                MessageBox.Show("Số sao không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (int.Parse(txtSoSao.Text) < 0 || int.Parse(txtSoSao.Text) > 5)
            {
                MessageBox.Show("Số sao phải lớn hơn không hoặc bé hơn 5", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSDT.Text == string.Empty)
            {
                MessageBox.Show("Số điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSDT.Text.Trim().Length > 10 || txtSDT.Text.Trim().Length < 9)
            {
                MessageBox.Show("Số điện thoại Không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbbKhuVuc.SelectedValue == null)
            {
                MessageBox.Show("Khu vực Không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            KhachSanDTO ks = new KhachSanDTO(txtTenKS.Text, int.Parse(txtSoSao.Text), int.Parse(cbbKhuVuc.SelectedValue.ToString()), txtSDT.Text, 1);
            var res = KhachSanDAO.Instance.InsertKhachSan(ks);
            if (res)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                clear();
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("TenKhachSan like '%{0}%'", txtSearch.Text);
            dgvKhachSan.DataSource = dv.ToTable();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            fXuatReport f = new fXuatReport();
            f.loadKhachSan();
            f.ShowDialog();
        }

        private void btnLamMoi_KH_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void fQuanLyKhachSan_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        void myMenu_ItemCLick(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "refresh":
                    btnLamMoi_KH.PerformClick();
                    break;
                case "edit":
                    btnChinhSua.PerformClick();
                    break;
                case "print":
                    btnXuat.PerformClick();
                    break;
                case "delete":
                    btnXoa.PerformClick();
                    break;
                case "huyHopTac":
                    btnHuyHopTac.PerformClick();
                    break;
            }
        }

        private void dgvKhachSan_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new ContextMenuStrip();
                int currentMouseOverRow = dgvKhachSan.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    myMenu.Items.Add("Làm mới").Name = "refresh";
                    myMenu.Items.Add("Chỉnh sửa").Name = "edit";
                    myMenu.Items.Add("Xuất").Name = "print";
                    myMenu.Items.Add("Xóa").Name = "delete";
                    if (cbbTrangThai.SelectedIndex == 0)
                        myMenu.Items.Add("Hủy hợp tác").Name = "huyHopTac";
                    else myMenu.Items.Add("Hợp tác").Name = "huyHopTac";
                }
                myMenu.Show(dgvKhachSan, new Point(e.X, e.Y));

                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemCLick);
            }
        }
    }
}
