using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceStack;
using ServiceStack.Text;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.SqlServer;
using ServiceStack.DataAnnotations;
using ASPNETWebApplicationTest.Models;

namespace ASPNETWebApplicationTest.Controllers
{
    public class OrmLiteController : Controller
    {
        // GET: OrmLite
        public ActionResult Index()
        {
            var dbFactory = new OrmLiteConnectionFactory("connectionString", SqlServerDialect.Provider);
            var db = dbFactory.Open();     //Open ADO.NET DB Connection

            db.DropAndCreateTable<HumanResourcesDepartmentModel>(); //DROP (if exist) and CREATE Table from User POCO

            return View();
        }
    }
}