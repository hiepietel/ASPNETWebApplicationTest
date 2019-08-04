using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using ASPNETWebApplicationTest.Models;
using ServiceStack.OrmLite;

namespace ASPNETWebApplicationTest.Controllers
{
    public class CarController : Controller
    {
        // GET
        public ActionResult Index()
        {
            
            var dbFactory = new OrmLiteConnectionFactory(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString, SqlServerDialect.Provider);
            using (var db = dbFactory.Open())
            {
                //db.DropAndCreateTable<CarModel>();
                List<CarModel> cm = db.Select<CarModel>(x => x.Model.Contains(""));
                return View(cm);
                //return View();
            }
        }

        public ActionResult Create()
        {
            //TODO - make Create Controller and View 
            return View();
        }

        public ActionResult Create(CarModel carModel)
        {
            return View()
        }
    }
}