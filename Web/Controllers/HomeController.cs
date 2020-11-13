using Data;
using Data.Domain;
using Data.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using blogDemoCom.Web.Models;

namespace blogDemoCom.Web.Controllers
{
    public class HomeController : Controller
    {
        private DataContext dbcontext = new DataContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CreateUser(User user, string validationcheck, string validation)
        {
            try
            {                
                if (String.IsNullOrEmpty(user.Name))
                    return Json(new { status = -1, title = "Bilgi Eksik", message = "Lütfen İsim Yazınız" });
                if (String.IsNullOrEmpty(user.LastName))
                    return Json(new { status = -1, title = "Bilgi Eksik", message = "Lütfen Soyisim Yazınız" });
                if (String.IsNullOrEmpty(user.Email))
                    return Json(new { status = -1, title = "Bilgi Eksik", message = "Lütfen Email Yazınız" });
                if (String.IsNullOrEmpty(user.Password))
                    return Json(new { status = -1, title = "Bilgi Eksik", message = "Lütfen Şifre Yazınız" });
                if (validationcheck != validation)
                    return Json(new { status = -1, title = "Doğrulama Hatası", message = "Toplama İşlemi Hatalı" });
                user.Role = "Admin";
                user.CreateTime = DateTime.Now;
                user.Status = true;
                dbcontext.User.Add(user);
                dbcontext.SaveChanges();
                return Json(new { status = 1, title = "İşlem Başarılı", message = "Kullanıcı Başarılı Bir Şekilde Kayıt Oldu" });
            }
            catch (Exception ex)
            {
                return Json(new { status = -1, title = "Sistem Hatası", message = "Sistemde Bir Hata Meydana Geldi. Lütfen Daha Sonra Tekrar Deneyiniz : " + ex });
            }
        }

        public IActionResult Test(int kontrol)
        {
            if(kontrol == 1){
                return Json(new { status = 1, title = "Başarılı", message = "Başarılı" }); 
            }
            return Json(new { status = -1, title = "Başarısız", message = "Başarısız" }); 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
