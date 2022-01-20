using System.Web.Mvc;

namespace DT.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {

            //Admin
            context.MapRoute(
               name: "Đăng nhập",
               url: "admin/dang-nhap",
               defaults: new { controller = "Login", action = "DangNhap" }
           );

            context.MapRoute(
               name: "Đăng xuất",
               url: "admin/dang-xuat",
               defaults: new { controller = "Login", action = "DangXuat" }
           );

            context.MapRoute(
               name: "Quản lý đơn hàng",
               url: "admin/quan-ly-don-hang",
               defaults: new { controller = "Orders", action = "Index" }
           );

            context.MapRoute(
                name: "Dơn hàng chưa duyệt",
                url:"admin/quan-ly-don-hang/chua-duyet",
                defaults: new {Controller="Orders", action= "UnBrowsedOrders" }
            );
            context.MapRoute(
                name: "Đơn hàng chưa thanh toán",
                url: "admin/don-hang/chua-thanh-toan",
                defaults: new { Controller = "Orders", action = "PaidOrders", MaHDBH = UrlParameter.Optional }
                );
            context.MapRoute(
                name: "Đơn hàng Đã thanh toán",
                url: "admin/don-hang/da-thanh-toan",
                defaults: new { Controller = "Orders", action = "UnpaidOrders", MaHDBH = UrlParameter.Optional }
                );

            context.MapRoute(
                name: "Đơn hàng đã Hủy đơn",
                url: "admin/don-hang/don-hang-da-huy",
                defaults: new { Controller = "Orders", action = "CancelOrders"}
                );

            context.MapRoute(
                name: "Đơn hàng Hủy đơn",
                url: "admin/don-hang/huy-don/{MaHDBH}",
                defaults: new { Controller = "Orders", action = "HuyDonHang", MaHDBH = UrlParameter.Optional }
                );
            
            context.MapRoute(
                name: "Chi tiết đơn hàng",
                url: "admin/chi-tiet-don-hang/{MaHDBH}",
                defaults: new { Controller = "Orders", action = "Details", MaHDBH = UrlParameter.Optional }
                );

            context.MapRoute(
                name: "Chỉnh sửa đơn hàng",
                url: "admin/chinh-sua-don-hang/{MaHDBH}",
                defaults: new { Controller = "Orders", action = "Edit", MaHDBH = UrlParameter.Optional }
                );
            context.MapRoute(
                name: "Duyet đơn hàng",
                url: "admin/don-hang/duyet-don/{MaHDBH}",
                defaults: new { Controller = "Orders", action = "DuyetDon", MaHDBH = UrlParameter.Optional }
                );




            //Thương hiệu
            context.MapRoute(
                name: "Thương hiệu",
                url: "admin/thuong-hieu",
                defaults: new { controller = "Trademark", action = "Index" }
                );
            context.MapRoute(
                name: "Thương hiệu sưae",
                url: "admin/thuong-hieu/sua/{id}",
                defaults: new { controller = "Trademark", action = "Edit", id = UrlParameter.Optional }
                );
            context.MapRoute(
                name: "Thương hiệu chi tiết",
                url: "admin/thuong-hieu/chi-tiet/{id}",
                defaults: new { controller = "Trademark", action = "Details" ,id = UrlParameter.Optional }
                );
            context.MapRoute(
                name: "Thương hiệu xóa",
                url: "admin/thuong-hieu/xoa/{id}",
                defaults: new { controller = "Trademark", action = "Delete", id = UrlParameter.Optional }
                );
            context.MapRoute(
               name: "Thương hiệu thêm mới",
               url: "admin/thuong-hieu/them-moi",
               defaults: new { controller = "Trademark", action = "Create" }
               );
            context.MapRoute(
               name: "Thương hiệu đã xóa",
               url: "admin/thuong-hieu/da-xoa",
               defaults: new { controller = "Trademark", action = "Deleted" }
               );
            //end thường hiệu


            //Thành viên
            context.MapRoute(
                name: "Thành viên",
                url: "admin/thanh-vien",
                defaults: new { Controller = "Members", action = "Index", id = UrlParameter.Optional }
                );
            context.MapRoute(
               name: "Thêm thành viên",
               url: "admin/thanh-vien/them-moi",
               defaults: new { Controller = "Members", action = "Create", id = UrlParameter.Optional }
               );
            context.MapRoute(
               name: "Xóa thành viên",
               url: "admin/thanh-vien/xoa/{id}",
               defaults: new { Controller = "Members", action = "Delete", id = UrlParameter.Optional }
               );
            context.MapRoute(
               name: "Sửa thành viên",
               url: "admin/thanh-vien/sua/{id}",
               defaults: new { Controller = "Members", action = "Edit", id = UrlParameter.Optional }
               );
            context.MapRoute(
               name: "Chi tiết thành viên",
               url: "admin/thanh-vien/chi-tiet/{id}",
               defaults: new { Controller = "Members", action = "Details", id = UrlParameter.Optional }
               );
            context.MapRoute(
                name: "Thành viên đã xóa",
                url: "admin/thanh-vien/da-xoa",
                defaults: new { Controller = "Members", action = "Deleted" }
                );
            context.MapRoute(
                name: "Thành viên Reset mật khẩu",
                url: "admin/thanh-vien/reset-pass/{id}",
                defaults: new { Controller = "Members", action = "ResetPass", id = UrlParameter.Optional }
                );
            
            //end thành viên

            //Nhà cung cấp
            context.MapRoute(
              name: "Nhà cung cấp",
              url: "admin/nha-cung-cap",
              defaults: new { controller = "Supplier", action = "Index" }
          );
            context.MapRoute(
              name: "Nhà cung cấp thêm mới",
              url: "admin/nha-cung-cap/them-moi",
              defaults: new { controller = "Supplier", action = "Create" }
          );
            context.MapRoute(
               name: "Nhà cung cấp xóa",
               url: "admin/nha-cung-cap/xoa/{id}",
               defaults: new { controller = "Supplier", action = "Delete", id = UrlParameter.Optional }
           );
            context.MapRoute(
               name: "Nhà cung cấp sửa",
               url: "admin/nha-cung-cap/sua/{id}",
               defaults: new { controller = "Supplier", action = "Edit" , id = UrlParameter.Optional}
           );
            context.MapRoute(
               name: "Nhà cung cấp chi tiết",
               url: "admin/nha-cung-cap/chi-tiet/{id}",
               defaults: new { controller = "Supplier", action = "Details", id = UrlParameter.Optional }
           );
            context.MapRoute(
               name: "Nhà cung cấp đã người hợp tác",
               url: "admin/nha-cung-cap/ngung-hop-tac",
               defaults: new { controller = "Supplier", action = "Deleted"}
           );

            //end nhà cung cấp
            //Sản phẩm
            context.MapRoute(
              name: "Quản lý sản phẩm",
              url: "admin/quan-ly-san-pham",
              defaults: new { controller = "ProductsQL", action = "Index" }
            );

            context.MapRoute(
              name: "Xóa sản phẩm",
              url: "admin/quan-ly-san-pham/xoa/{id}",
              defaults: new { controller = "ProductsQL", action = "Delete", id = UrlParameter.Optional }
            );

            context.MapRoute(
              name: "Thêm sản phẩm",
              url: "admin/quan-ly-san-pham/them-moi",
              defaults: new { controller = "ProductsQL", action = "Create" }
            );

            context.MapRoute(
              name: "Chi tiết sản phẩm",
              url: "admin/san-pham/{slug}/{id}",
              defaults: new { controller = "ProductsQL", action = "Details", slug = UrlParameter.Optional, id = UrlParameter.Optional }
            );

            context.MapRoute(
              name: "Chỉnh sửa sản phẩm",
              url: "admin/quan-ly-san-pham/sua/{id}",
              defaults: new { controller = "ProductsQL", action = "Edit", id = UrlParameter.Optional }
            );

            context.MapRoute(
              name: "Sản phẩm ngừng kinh doanh",
              url: "admin/quan-ly-san-pham/san-pham-ngung-kinh-doanh",
              defaults: new { controller = "ProductsQL", action = "SPNgungKinhDoanh"}
            );

            context.MapRoute(
             name: "Sản phẩm hết hàng",
             url: "admin/quan-ly-san-pham/san-pham-het-hang",
             defaults: new { controller = "ProductsQL", action = "SPHetHang" }
           );

            context.MapRoute(
             name: "Sản phẩm còn hàng",
             url: "admin/quan-ly-san-pham/san-pham-con-hang",
             defaults: new { controller = "ProductsQL", action = "SPConHang" }
           );
            context.MapRoute(
             name: "Ngừng kinh doanh sản phẩm",
             url: "admin/quan-ly-san-pham/ngung-kinh-doanh/{id}",
             defaults: new { controller = "ProductsQL", action = "NgungKinhDoanh", id=UrlParameter.Optional }
           );
            context.MapRoute(
             name: "Quản lý nhân viên",
             url: "admin/quan-ly-nhan-vien",
             defaults: new { controller = "Member", action = "Index"}
           );
            context.MapRoute(
             name: "Tài khoản",
             url: "admin/tai-khoan",
             defaults: new { controller = "HomeAdmin", action = "TaiKhoan" }
           );
            //Đơn hàng
            //Thông kê
            context.MapRoute(
                "Thống kê doanh thu theo tháng",
                url: "admin/thong-ke/doanh-thu",
                defaults: new { controller = "ThongKe", action = "ThongKeDoanhThuTheoThang" }
            );
            context.MapRoute(
                "thống kê đơn hàng",
                url: "admin/thong-ke/don-hang",
                defaults: new { controller = "ThongKe", action = "ThongKeDonHang" }
            );
            context.MapRoute(
                "Thống kê khách hàng",
                  url: "admin/thong-ke/khach-hang",
                defaults: new { controller = "ThongKe", action = "ThongKeKhachHang" }
            );
            context.MapRoute(
                "Thống kê nhân viên",
                url: "admin/thong-ke/nhan-vien",
                defaults: new { controller = "ThongKe", action = "ThongKeNhanVien" }
            );
            context.MapRoute(
                "Thống kê sản phẩm",
                url: "admin/thong-ke/san-pham",
                defaults: new { controller = "ThongKe", action = "ThongKeSanPham" }
            );
            context.MapRoute(
                 "Thống kê",
                 url: "admin/thong-ke",
                 defaults: new { controller = "ThongKe", action = "Index" }
             );


            /***/
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { controller ="HomeAdmin", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}