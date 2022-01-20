using chicken.App_Start;
using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.Admin.Controls
{
    public partial class nhanvien : System.Web.UI.UserControl
    {
        Account_DAL acc = new Account_DAL();
        XuLy xuly = new XuLy();
        private String title1, title2;
        private bool isUpdate;
        private String message, id_Update;
        private String hTen, nSinh, gTinh, cVu, tDangNhap, mKhau, sdt, dChi;
        private int quyen;
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
           
            if (isUpdate == false)
            {
                themnhanvien();
                lbMessage.Text = message;
            }
            else
            {
                chinhSuaThanhVien();
                lbMessage.Text = message;
            }    
        }

        public string Title1 { get => title1; set => title1 = value; }
        public string Title2 { get => title2; set => title2 = value; }
        public bool IsUpdate { get => isUpdate; set => isUpdate = value; }
        public string Message { get => message; set => message = value; }
        public int Quyen { get => quyen; set => quyen = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["HUAOJATQQ"] != null)
            {
                Quyen = Decentralization.quyen(Session["CHUCVU"].ToString());
                if (Quyen != 1)
                {
                    DropDownListCV.Items.Remove("Quản lý");
                    DropDownListCV.Items.Remove("Giám đốc");
                }
            }

            if (isUpdate == false)
                {
                    title1 = "Thêm nhân viên";
                    title2 = title1 + " mới";
                    btnSubmit.Text = "Thêm";
                }
                else
                {
                    title1 = "Chỉnh sửa nhân viên";
                    title2 = title1;
                    btnSubmit.Text = "Lưu";
                    id_Update = Request.QueryString["id"].ToString();
                    if(!IsPostBack) layDuLieuRaForm(id_Update);

            }
        }
        private void layThongTin()
        {
            hTen = txtName.Text;
            nSinh = txtNgaySinh.Text;
            gTinh = DropDownListGT.SelectedValue.ToString();
            cVu = DropDownListCV.SelectedValue.ToString();
            tDangNhap = txtTenDangNhap.Text;
            mKhau = txtMatKhau.Text;
            sdt = txtSDT.Text;
            dChi = txtDiaChi.Text;
        }
        private void themnhanvien()
        {
            layThongTin();
            if (acc.checkUser(tDangNhap) < 1)
            {
                if (acc.dangKyUser(tDangNhap, mKhau, hTen, sdt, dChi, nSinh, gTinh, false) > 0)
                {
                    if (acc.themNhanVien(acc.idUser(tDangNhap).ToString(), cVu) > 0)
                    {
                        message = "Đăng kí thành công"; return;
                    }
                }
            }else
            {
                message = "Tài khoản đã tồn tại"; return;
            }
        }
        private void layDuLieuRaForm(String id)
        {
            String sql = "SELECT * FROM MEMBERS M, USERS U WHERE M.ID_USER = U.ID_USER AND M.ID_USER = "+id;
            DataTable dt = xuly.select(sql);
            
            foreach(DataRow r in dt.Rows)
            {
                txtName.Text = r["FULLNAME"].ToString();
                txtNgaySinh.Text = DateTime.Parse(r["NGAYSINH"].ToString()).ToString("d");
                txtTenDangNhap.Text = r["USERNAME"].ToString();
                txtMatKhau.Text = r["PASSWORD"].ToString();
                txtSDT.Text = r["SDT"].ToString();
                txtDiaChi.Text = r["DIACHI"].ToString();
                DropDownListGT.SelectedValue = DropDownListGT.Items.FindByValue(r["GIOITINH"].ToString()).Value;
                DropDownListCV.SelectedValue = DropDownListCV.Items.FindByValue(r["CHUCVU"].ToString()).Value;
            }

        }
        public void chinhSuaThanhVien()
        {
            layThongTin();
            id_Update = Request.QueryString["id"].ToString();
            if (acc.capNhatUser(id_Update, hTen, nSinh, gTinh, tDangNhap, Fun.EncryptPassword(mKhau), sdt, dChi) > 0 && acc.capNhatMember(id_Update, cVu) > 0)
            {
                message = "Cập nhật thành công"; return;
            }
        }
    }
}