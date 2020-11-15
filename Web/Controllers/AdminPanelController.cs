using Data;
using Data.Domain;
using Data.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using blogDemoCom.Web.Models;
using PagedList.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace blogDemoCom.Web.Controllers
{
    [Authorize(Roles = ("Admin"))]
    public class AdminPanelController : Controller
    {
        private DataContext dbcontext = new DataContext();
        private readonly ILogger<AdminPanelController> _logger;

        public AdminPanelController(ILogger<AdminPanelController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index(string searchText = "", int page = 1)
        {
            List<Post> posts = dbcontext.Post.Where(x => x.Status == true).OrderByDescending(x => x.CreateTime).ToList(); 
            User user = GetUser();
            ViewBag.Name = user.FullName;
            if(!String.IsNullOrEmpty(searchText)){
                posts = dbcontext.Post.Where(x => x.Title.Contains(searchText) || x.Content.Contains(searchText)).OrderByDescending(x => x.CreateTime).ToList();                
            }
            PagedList<Post> postsPaged = new PagedList<Post>(posts.AsQueryable(), page, 5); 
            if (IsAjaxRequest(Request))
                return PartialView("~/Views/Shared/_PostList.cshtml", postsPaged);
            return View(postsPaged);
        }
        public IActionResult Settings()
        {
            User user = GetUser(); 
            ViewBag.Name = user.FullName;           
            return View(user);
        }

        public IActionResult PostAdd()
        {
            User user = GetUser(); 
            ViewBag.Name = user.FullName;           
            return View();
        }

        public IActionResult PostSettings(int page = 1)
        {           
            User user = GetUser();
            ViewBag.Name = user.FullName;
            List<Post> posts = dbcontext.Post.OrderByDescending(x => x.CreateTime).ToList();
            PagedList<Post> postsPaged = new PagedList<Post>(posts.AsQueryable(), page, 25);
            return View(postsPaged);
        }

        [HttpPost]
        public JsonResult Guncelle(string Name, string LastName, string Email, string Password, int Id)
        {
            User userUpdate = dbcontext.User.Where(x => x.Id == Id).FirstOrDefault(); 
            userUpdate.Name = Name;
            userUpdate.LastName = LastName;
            userUpdate.Email = Email;
            userUpdate.Password = Password;
            dbcontext.SaveChanges();        
            return Json(new { status = 1, title = "İşlem Başarılı", message = "Ayarlarınız güncellendi!" });
        }

        [HttpPost]
        public JsonResult PostSil(int Id)
        {
            Post postDelete = dbcontext.Post.Where(x => x.Id == Id).FirstOrDefault();
            dbcontext.Remove(postDelete);
            dbcontext.SaveChanges();        
            return Json(new { status = 1, title = "İşlem Başarılı", message = "Ayarlarınız güncellendi!" });
        }

        [HttpPost]
        public async Task<IActionResult> PostEkle(IFormFile File, string Title, string Content)
        {      
            if(File != null){                  
                Post post = new Post()
                {
                    Title = Title,
                    Content = Content,
                    AuthorId = GetUser().Id
                };  
                string filename = "";
                filename = Guid.NewGuid().ToString() + "-" + post.Id + ".png";  
                post.Image = filename;                 
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/postImages", filename);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await File.CopyToAsync(stream);
                }

                dbcontext.Add(post);
                dbcontext.SaveChanges();        
                return Redirect("/AdminPanel/PostSettings");
            }
            return null;            
        }        
        public IActionResult PostEdit(int Id){
            User user = GetUser();
            ViewBag.Name = user.FullName; 
            Post postUpdate = dbcontext.Post.Where(x => x.Id == Id).FirstOrDefault();
            return View(postUpdate);
        }
        [HttpPost("FileUpload")]
        public async Task<IActionResult> PostGuncelle(IFormFile File, int Id, string Title, string Content)
        {                       
            Post postUpdate = dbcontext.Post.Where(x => x.Id == Id).FirstOrDefault();            
            string filename = "";
            filename = Guid.NewGuid().ToString() + "-" + Id + ".png";
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/postImages", filename);
            if(File != null){
                postUpdate.Image = filename;
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await File.CopyToAsync(stream);
                }
            }
            
            postUpdate.Title = Title;
            postUpdate.Content = Content;
            postUpdate.UpdateTime = DateTime.Now;            
            dbcontext.Update(postUpdate);
            dbcontext.SaveChanges();        
            return Redirect("/AdminPanel/PostSettings");
        }        

        public ActionResult PostStatusToggle(int Id)
        {
            Post post = dbcontext.Post.Where(x => x.Id == Id).FirstOrDefault();
            post.Status = !post.Status;
            dbcontext.Update(post);
            dbcontext.SaveChanges(); 
            return Json(new { status = 1, title = "İşlem Başarılı", message = "Ayarlarınız güncellendi!", postStatus = post.Status });
        } 
        public ActionResult Cikis()
        {
            HttpContext.SignOutAsync();
            return Redirect("/Home/Index");
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

        [HttpPost]
        public JsonResult AddPost(Post post, string validationcheck, string validation)
        {
            try
            {                
                if (String.IsNullOrEmpty(post.Title))
                    return Json(new { status = -1, title = "Bilgi Eksik", message = "Lütfen Başlık Yazınız" });
                if (String.IsNullOrEmpty(post.Content))
                    return Json(new { status = -1, title = "Bilgi Eksik", message = "Lütfen İçerik Yazınız" });
                if (String.IsNullOrEmpty(post.Image))
                    return Json(new { status = -1, title = "Bilgi Eksik", message = "Lütfen Fotoğraf Ekleyiniz" });
                if (validationcheck != validation)
                    return Json(new { status = -1, title = "Doğrulama Hatası", message = "Toplama İşlemi Hatalı" });
                post.AuthorId = 1;
                post.CreateTime = DateTime.Now;
                post.Status = true;
                dbcontext.Post.Add(post);
                dbcontext.SaveChanges();
                return Json(new { status = 1, title = "İşlem Başarılı", message = "Kullanıcı Başarılı Bir Şekilde Kayıt Oldu" });
            }
            catch (Exception ex)
            {
                return Json(new { status = -1, title = "Sistem Hatası", message = "Sistemde Bir Hata Meydana Geldi. Lütfen Daha Sonra Tekrar Deneyiniz : " + ex });
            }
        }

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #region ---------User Security
        public User GetUser()
        {
            List<Claim> useridentity = GetIdentitiy();
            if (useridentity == null)
                return null;
            if (useridentity.FirstOrDefault(x => x.Type == "id") == null)
                return null;
            Int16 userid = Convert.ToInt16(useridentity.FirstOrDefault(x => x.Type == "id").Value);
            User user = dbcontext.User.Where(x => x.Id == userid).FirstOrDefault();
            return user;
        }
        public void SetIdentity(User user) 
        {
            var claims = new List<Claim> {                
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.Role,user.Role),
                new Claim("id",user.Id.ToString())
            };
            var userIdentity = new ClaimsIdentity(claims, "user");
            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
            HttpContext.SignInAsync(principal);

        }
        public List<Claim> GetIdentitiy() 
        {
            List<Claim> checkuser = User.Claims.ToList();
            if (checkuser != null)
                return checkuser;
            return null;
        }
        
        #endregion ----------User Security

        public bool IsAjaxRequest(HttpRequest request)
        {
            return request.Headers["X-Requested-With"] == "XMLHttpRequest";
        }
    }
}
