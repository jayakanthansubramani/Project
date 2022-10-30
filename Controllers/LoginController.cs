using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using TransportWeb.Models;

namespace TransportWeb.Controllers
{
   
    public class LoginController : Controller
    {
        private readonly TransportManagementContext db;

        public LoginController(TransportManagementContext _db)  //constructor
        {
            db = _db;
            //session = httpContextAccessor.HttpContext.Session;

        }
        public IActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserLogin(Admin d)
        {
            var log = (from i in db.Admins//linq function used to select and cmd using in sql
                       where i.UserName == d.UserName && i.Password == d.Password
                       select i).SingleOrDefault();
            if (log != null)
            {
                //HttpContext.Session.SetString("uname", d.Login);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
            return View();

        }
        public IActionResult Logout()
        {
            return View("UserLogin");
        }


    }
}
