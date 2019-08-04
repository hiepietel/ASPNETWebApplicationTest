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
using System.Configuration;
using PagedList;

namespace ASPNETWebApplicationTest.Controllers
{
    public class OrmLiteController : Controller
    {

        // GET: OrmLite
        public ActionResult Index()
        {
            //var dbFactory = new OrmLiteConnectionFactory("DefaultConnection", SqlServerDialect.Provider);
            var dbFactory = new OrmLiteConnectionFactory(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString, SqlServerDialect.Provider);
            //var db = dbFactory.OpenDbConnectionString("HumanResources.Department");     //Open ADO.NET DB Connection
            var db = dbFactory.Open();
            //db.ConnectionString = "";

            //List<HumanResourcesDepartmentModel> output = db.SelectByIds(new[] { 1, 2, 3 }).ToList();
            //int val = db.ExecuteSql("select * from HumanResources.Department");
            //db.DropAndCreateTable<SimpleModel>(); //DROP (if exist) and CREATE Table from User POCO
            //db.Insert(                     //INSERT multiple Users by params
            //    new SimpleModel { Id = 1, Name = "A"},
            //    new SimpleModel { Id = 2, Name = "B"},
            //    new SimpleModel { Id = 3, Name = "C"},
            //    new SimpleModel { Id = 4, Name = "C"});


            return View();
        }
        [HttpPost]
        public ActionResult Create(SimpleModel sm)
        {
            var dbFactory = new OrmLiteConnectionFactory(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString, SqlServerDialect.Provider);
            using (var db = dbFactory.Open())
            {
                db.Insert(sm);
            }

            sm.Name = "";
            sm.Description = "";
            return View(sm);
        }
        public ActionResult Create()
        {
            return View(new SimpleModel());
        }
        public ActionResult Details()
        {
            var dbFactory = new OrmLiteConnectionFactory(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString, SqlServerDialect.Provider);
            using (var db = dbFactory.Open())
            {
                List<SimpleModel> sm = db.Select<SimpleModel>(x => x.Name.Contains(""));
                return View(sm);
            }

        }

        public ActionResult Search()
        {
            return View(new SimpleModel());
        }
        [HttpPost]
        public ActionResult Search(SimpleModel model)
        {
            var dbFactory = new OrmLiteConnectionFactory(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString, SqlServerDialect.Provider);
            using (var db = dbFactory.Open())
            {
                SimpleModel sm = db.Single<SimpleModel>(x => x.Name.Contains(model.Name));
                return View(sm);
            }
            //return View();
        }

        public ActionResult Read()
        {
            return View();
        }    


    }
}