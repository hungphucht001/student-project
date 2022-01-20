using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using DT.Entity;
using System.Net.Mail;

namespace DT.Controllers
{
    public class HomeController : Controller
    {
        dbPhoneStoreEntities db = new dbPhoneStoreEntities();

        HomeAPIController api = new HomeAPIController();

        public ActionResult Index()
        {
            ViewBag.listPhone = api.GetPhone();
            ViewBag.listAccessory = api.GetAccessory();
            ViewBag.Item1 = api.Get(14);
            ViewBag.Item2 = api.Get(12);
            return View();
        }
        [HttpPost]
        public ActionResult Index(string email)
        {
            if(email == string.Empty)
            {
                ViewBag.showModal = true;
                ViewBag.ModalContent = "Email không được để trống";
            }
            else
            {
                try
                    {
                    MailMessage mail = new MailMessage();
                    mail.To.Add(email);
                    mail.From = new MailAddress("sunkist.hutr@gmail.com");
                    mail.Subject = "Đăng ký email";
                    string Body = "Cảm ơn bạn đã đăng ký email. Chúng tôi sẽ sớm gửi cho bạn những sản phẩm tốt nhất";
                    mail.Body = Body;
                    mail.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential("sunkist.hutr@gmail.com", "hungphuc001"); // Enter seders User name and password  
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    ViewBag.showModal = true;
                        ViewBag.ModalContent = "Đăng ký email thành công";
                    }
                    catch
                    {
                        ViewBag.showModal = true;
                        ViewBag.ModalContent = "Đăng ký email thất bại";
                    }
            }
            ViewBag.listPhone = api.GetPhone();
            ViewBag.listAccessory = api.GetAccessory();
            ViewBag.Item1 = api.Get(14);
            ViewBag.Item2 = api.Get(12);
            return View();
        }
        public ActionResult Err404(){
            return View();
    }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

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