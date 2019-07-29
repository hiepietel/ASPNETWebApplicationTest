using ASPNETWebApplicationTest.Models;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETWebApplicationTest.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Autherize(User user)
        {
            var dbFactory = new OrmLiteConnectionFactory(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString, SqlServerDialect.Provider);
            using (var db = dbFactory.Open())
            {
                bool exist = db.Exists<User>(x => x.UserName == user.UserName && x.Password == user.Password);
                if (exist)
                 {
                    Session["userID"] = user.UserName;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    
                    return View("Index", user);
                }
            }

            
        }
    }
}