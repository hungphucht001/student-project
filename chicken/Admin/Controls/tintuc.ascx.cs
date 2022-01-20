using chicken.App_Start;
using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.Admin.Controls
{
    public partial class tintuc : System.Web.UI.UserControl
    {
        News news = new News();
        XuLy xuly = new XuLy();
        private String title1, title2, titleBtn;
        private bool isUpdate;
        private String id_member, ten, tenkhongdau, mota, avatar, gioithieu;
        public string Title1 { get => title1; set => title1 = value; }
        public string Title2 { get => title2; set => title2 = value; }
        public bool IsUpdate { get => isUpdate; set => isUpdate = value; }
        public string TitleBtn { get => titleBtn; set => titleBtn = value; }
        public object DataTale { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (isUpdate == true)
                {
                    titleBtn = "Lưu";
                    taiDuLieuLen();
                }
                else titleBtn = "Thêm";
                btnSubmit.Text = titleBtn;
            }
        }
        
        private void themBaiViet()
        {
            layThongTinTuNguoiDung();
            news.themBaiViet(id_member, ten, tenkhongdau, mota, avatar, gioithieu);
        }
        private void layThongTinTuNguoiDung()
        {
            id_member = Session["ID_AD"].ToString();
            ten = txtName.Text;
            tenkhongdau = Fun.convertToUnSign3(ten);
            mota = txtContent.Text;
            avatar = "";
            gioithieu = txtGioiThieu.Text;
            if (Page.IsValid && FileUploadAvatar.HasFile && CheckFileType(FileUploadAvatar.FileName))
            {
                string fileName = "/upload/news/" + DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + FileUploadAvatar.FileName;
                string filePath = MapPath(fileName);
                FileUploadAvatar.SaveAs(filePath);
                avatar = fileName;
            }
        }
        bool CheckFileType(string fileName)
        {
            string ext = Path.GetExtension(fileName);
            switch (ext.ToLower())
            {
                case ".gif":
                    return true;
                case ".png":
                    return true;
                case ".jpg":
                    return true;
                case ".jpeg":
                    return true;
                default:
                    return false;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isUpdate == false) themBaiViet();
            else capNhatTinTuc();
        }
        private void capNhatTinTuc()
        {
            layThongTinTuNguoiDung();
           if(news.capNhatBaiViet(id_member, ten, tenkhongdau, mota, avatar, gioithieu,Request.QueryString["id"].ToString()) > 0) Response.Redirect("/admin/tintuc/quanlybaiviet");
        }
        private void taiDuLieuLen()
        {
            String sql = "SELECT * FROM NEWS WHERE ID_NEWS =" + Request.QueryString["id"].ToString();
            DataTable dt = xuly.select(sql);
            foreach(DataRow r in dt.Rows)
            {
                txtName.Text = r["TEN"].ToString();
                txtContent.Text = r["MOTA"].ToString();
                txtGioiThieu.Text = r["GIOITHIEU"].ToString();
            }
        }
    }
}