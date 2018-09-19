using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Business;

namespace TestMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult BooksInfo()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Gallery()
        {
            ViewData["Message"] = "Your gallery page.";

            return View();
        }



        public ActionResult VehicleData()
        {
            ViewBag.Message = "Vehicle models";

            //Get the vehicle Data from Business Layer
            var vehicle = CrazyBike.GetVehicleData();
            return View(vehicle);

        }

        //public ActionResult EmployeeData()
        //{
        //    ViewBag.Message = "Employee Information";

        //    var IndivDemo = Demographics.GetEmployeeInformationData();
         
        //    return View(IndivDemo);

        //}


        //public ActionResult TestData()
        //{
        //    ViewBag.Message = "Employee Information";

        //    var IndivDemo = Demographics.GetEmployeeInformationData();

        //    return View(IndivDemo);

        //}
    }
}