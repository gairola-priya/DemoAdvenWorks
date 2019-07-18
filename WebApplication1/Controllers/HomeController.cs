using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private AdventureWorks2017Entities db = new AdventureWorks2017Entities();
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

        [HttpGet]
        public ActionResult SalesData(String ZipCode,String StartDate,String EndDate)
        { 
            DateTime l_StartDate = Convert.ToDateTime(StartDate);
            DateTime l_EndDate = Convert.ToDateTime(EndDate); 
            
            List<WebApplication1.Models.SalesData> l_Result = new List<WebApplication1.Models.SalesData>();
        
            foreach (var l_item in db.sp_getSalesAvgData(ZipCode, l_StartDate, l_EndDate))
            {
                l_Result.Add(new WebApplication1.Models.SalesData(l_item)); 
            }
             
             //  SalesOrderHeader salesOrderHeader = db.SalesOrderHeaders.Find(id);

            return Json(new { json = l_Result }, JsonRequestBehavior.AllowGet); 
        }
    }
}