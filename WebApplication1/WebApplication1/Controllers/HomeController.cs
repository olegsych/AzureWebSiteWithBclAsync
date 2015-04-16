using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.ApplicationInsights;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly TelemetryClient telemetryClient = new TelemetryClient();

        public ActionResult Index()
        {
            telemetryClient.TrackEvent("Index");

            return View();
        }

        public ActionResult About()
        {
            telemetryClient.TrackEvent("About");

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            telemetryClient.TrackEvent("Contact");

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}