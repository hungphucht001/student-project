using DT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DT.Entity;
using System.Net.Mail;

namespace DT.Controllers
{
    public class PayController : Controller
    {

        dbPhoneStoreEntities db = new dbPhoneStoreEntities();
        // GET: Pay
        public ActionResult Index()
        {

            if (Session["cart"] == null)
            {
                return Redirect("/san-pham");
            }
            else
            {
                ViewBag.totalPri = (Session["cart"] as Cart).totalPri();
            }

            return View();
        }
        public ActionResult Thankyou()
        {
            return View();
        }

        //POST: Pay
        [HttpPost]
        public ActionResult Index(tb_KhachHang khachHang)
        {
            if (ModelState.IsValid)
            {
                Cart cart = (Cart)Session["cart"];

                tb_KhachHang kh = db.tb_KhachHang.SingleOrDefault(t => t.SDT == khachHang.SDT && t.HoTen.Equals(khachHang.HoTen) && t.DiaChi.Equals(khachHang.DiaChi) && t.Email.Equals(khachHang.Email));
                if(kh == null)
                {
                    db.tb_KhachHang.Add(khachHang);
                    kh = khachHang;
                }
                tb_HDBanHang hdbh = new tb_HDBanHang()
                {
                    MaKH = kh.MaKH,
                    NgayLap = DateTime.Now,
                    TongTien = Convert.ToDecimal(cart.totalPri()),
                    TrangThai = 1
                };

                db.tb_HDBanHang.Add(hdbh);

                List<tb_CTHDBanHang> lt = new List<tb_CTHDBanHang>();
                string dsDH = "";
                int sl = 0;
      
                foreach(CartItem item in cart.Items)
                {
                    dsDH += "<tr><td width=\"250\"style=\"text-align: start;color:rgb(4, 6, 85); font-weight: bold;color:#fff\">" + item.ProductName + "</td><td>" + string.Format("{0:C}", item.Price).Replace("$","").Replace(".00","") + " VNĐ</td><td width=\"50\"style=\"text-align:end;\">x "+item.Quantity+"</td></tr>";
                    sl += item.Quantity;
                  
                    tb_CTHDBanHang tb = new tb_CTHDBanHang()
                    {
                        MaHDBH = hdbh.MaHDBH,
                        MaSanPham = item.ProductID,
                        SoLuong = item.Quantity
                    };
                    lt.Add(tb);
                }
                db.tb_CTHDBanHang.AddRange(lt);
                db.SaveChanges();

                try
                {
                    MailMessage mail = new MailMessage();
                    mail.To.Add(khachHang.Email);
                    mail.From = new MailAddress("sunkist.hutr@gmail.com");
                    mail.Subject = "Đặt hàng thành công";
                    string Body = "<div style=\"padding:30px;margin:0 auto; width: 500px;background-color: rgb(0, 145, 145);\">" +
                        "<div style=\"background-color: rgb(4, 6, 85);padding: 2px 20px;color:#fff; margin-bottom: 20px;\"><h2>Thông tin đặt hàng:</h2></div>" +
                        "<table style=\"color:#fff\"><tr><th width=\"120\" style=\"text-align:start;\">Mã đơn hàng:</th><td>" + hdbh.MaHDBH + "</td></tr>" +
                        "<tr><th width=\"120\" style=\"text-align:start;\">Họ tên:</th><td>" + khachHang.HoTen+ "</td></tr>" +
                        "<tr><th width=\"120\"style=\"text-align:start;\">Số điện thoại:</th><td>" + khachHang.SDT + "</td></tr><tr><th width=\"120\"style=\"text-align:start;\">Địachỉ:</th><td>" + khachHang.DiaChi + "</td></tr></table>" +
                        "<div style=\"background-color: rgb(4, 6, 85);padding: 2px 20px;color:#fff; margin: 20px 0;\"><h2>Chi tiết đơn hàng:</h2></div>" +
                        "<table style=\"color:#fff\">"+ dsDH + "</table>" +
                        "<div style=\"background-color: rgb(4, 6, 85); padding: 2px 20px; margin: 20px 0; \"><table style = \"color:#fff\"><tr><td width = \"250\" style = \"text-align: start;color:rgb(4, 6, 85); color:#fff; font-weight: bold;padding:10px 0\" >Số lượng: </td>" +
                        "<td style = \"color:#fff;\" > "+ sl + " </td></tr><tr><td width =\"250\" style =\"text-align: start;color:rgb(4, 6, 85);color:#fff; font-weight: bold;padding:10px 0\"> Tổng tiền: </td><td style = \"color:#fff;\" > "+ string.Format("{0:C}", cart.totalPri()).Replace("$", "").Replace(".00", "") + " VNĐ </td></tr></table></div> " +
                        "<div><a href = \"https://localhost:44360/tra-cuu-don-hang?sdt="+khachHang.SDT+"\" style = \"background-color:rgb(4, 6, 85); color:#fff; padding:10px 20px; font-size: 16px;text-decoration: none; margin-top:10px;display: inline-block;\" > Xem chi tiết</a></div>" +
                        "</div>";
                    mail.Body = Body;
                    mail.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential("sunkist.hutr@gmail.com", "hungphuc001"); // Enter seders User name and password  
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
                catch
                {
                }

                Session.Remove("cart");
                    
                return Redirect("/cam-on");
            }
            if (Session["cart"] == null)
            {
                return Redirect("/san-pham");
            }
            else
            {
                ViewBag.totalPri = (Session["cart"] as Cart).totalPri();
            }
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}