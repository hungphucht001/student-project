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
    public partial class thucdon : System.Web.UI.UserControl
    {
        private String title, titleBtn, idEdit;
        private String nameDish, price, sale, content, category, describe, unsignedName, avatar;
        XuLy xuly = new XuLy();
        Dish_DAL dish = new Dish_DAL();
        private bool isUpdate;
        public string Title { get => title; set => title = value; }
        public bool IsUpdate { get => isUpdate; set => isUpdate = value; }
        public string TitleBtn { get => titleBtn; set => titleBtn = value; }
        public string IdEdit { get => idEdit; set => idEdit = value; }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (isUpdate == false)
                {
                    titleBtn = "Thêm";
                    loadDataDropDownListCategory("");
                }
                else
                {
                    titleBtn = "Lưu";
                    idEdit = Request.QueryString["id"].ToString();
                    layThongTinMonAn(idEdit);
                }
                btnSubmit.Text = titleBtn;
            }
        }

        private void loadDataDropDownListCategory(String selected)
        {
            String sql = "SELECT * FROM CATEGORYS";
            DataTable dtCategorys = xuly.select(sql);
            DropDownListCategory.DataSource = dtCategorys;
            DropDownListCategory.DataTextField = "TEN_CATEGORY"; //Text hiển thị
            DropDownListCategory.DataValueField = "ID_CATEGORY"; //Giá trị khi chọn
            DropDownListCategory.DataBind();
            if(!selected.Equals(""))DropDownListCategory.SelectedValue = DropDownListCategory.Items.FindByValue(selected).Value;
        }
        private void addDish()
        {
            layThongTinTuNguoiDung();
            int kq = dish.themMonAn(nameDish, price, sale, content, category, describe, unsignedName, avatar);
        }
        bool CheckFileType(String fileName)
        {
            String ext = Path.GetExtension(fileName);
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
        private static String convertToUnSign3(String s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            String ky = regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
            return ky.Replace(" ", "_");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (isUpdate == false) addDish();
            else
            {
                capNhatMonAn();
            }
        }
        private void layThongTinMonAn(String idEdit)
        {
            String sql = "SELECT * FROM PRODUCTS WHERE ID_PRODUCTS = "+ idEdit;
            DataTable dt = xuly.select(sql);
            foreach(DataRow r in dt.Rows){
                txtName.Text = r["TENSP"].ToString();
                txtGia.Text = r["GIA"].ToString();
                txtGiamGia.Text = r["SALE"].ToString();
                txtNoiDung.Text = r["NOIDUNG"].ToString();
                txtMoTa.Text = r["MOTA"].ToString();
                loadDataDropDownListCategory(r["ID_CATEGORY"].ToString());
            }
        }
        private void layThongTinTuNguoiDung()
        {
            nameDish = txtName.Text;
            price = txtGia.Text;
            sale = txtGiamGia.Text;
            content = txtNoiDung.Text.Trim();
            describe = txtMoTa.Text;
            unsignedName = convertToUnSign3(nameDish);
            category = DropDownListCategory.SelectedValue.ToString();
            avatar = "";
            if (Page.IsValid && FileUpload.HasFile && CheckFileType(FileUpload.FileName))
            {
                String fileName = "/upload/news/" + DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + FileUpload.FileName;
                String filePath = MapPath(fileName);
                FileUpload.SaveAs(filePath);
                avatar = fileName;
            }
        }
        private void capNhatMonAn()
        {
            layThongTinTuNguoiDung();
            if (dish.chinhSuaMonAn(nameDish, price, sale, content, category, describe, unsignedName, avatar, Request.QueryString["id"].ToString()) > 0)
                Response.Redirect("/admin/thucdon/quanlythucdon");
        }
    }
}