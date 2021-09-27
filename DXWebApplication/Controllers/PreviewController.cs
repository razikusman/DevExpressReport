using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.XtraReports.Web;
using DXWebApplication.Models;

namespace DXWebApplication.Controllers
{
    public class PreviewController : Controller
    {
        // GET: Preview
        public ActionResult Index()
        {  
            // Create a report instance.
            var report = new XtraReport2();

            // Obtain a parameter, and set its value.
            //report.Parameters["parameter1"].Value = "Vetro Raccordi";

            //report.RequestParameters = false;

            // Hide the Parameters UI from end-users.
            var cachedReportSource = new CachedReportSourceWeb(report);
            return View(cachedReportSource);
        }
    }
}