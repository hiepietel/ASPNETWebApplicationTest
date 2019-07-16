using System;
using System.Web.Mvc;
using ASPNETWebApplicationTest.Models;

namespace ASPNETWebApplicationTest.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET
        public string Index()
        {
            return "Hello World";
        }

        public ActionResult MainView()
        {
            return View(new NumberModel());
        }

        [HttpPost]
        public ActionResult MainView(NumberModel nm)
        {
            int intTemp = int.Parse(nm.number);
            double doubleTemp = double.Parse(nm.number);

            nm.square = doubleTemp * doubleTemp;
            nm.cube = doubleTemp * doubleTemp * doubleTemp;
            //factorial
            nm.factorial = 1;
            for (int i = 0; i < intTemp; i++)
            {
                nm.factorial *= (i + 1);
            }
            //check if number is a prime
            nm.isPrime = true;
            if (intTemp % 2 == 0) nm.isPrime = false;
            for (int i = 3; i < intTemp / 2 + 1; i += 2)
            {
                if (intTemp % i == 0) nm.isPrime = false;
            }
            return View(nm);
        }
    }
}