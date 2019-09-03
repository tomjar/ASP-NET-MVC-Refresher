using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPNetRefresher.Models;

namespace ASPNetRefresher.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var ctx = new ASPNetRefresherDbContext())
            {
                var data = ctx.Titanites
                    .Select(t => new MineralViewModel()
                    {
                        lat_max = t.latitude_max,
                        long_max = t.longitude_max,
                        rock_name = t.rock_name,
                        sample_name = t.sample_name,
                        mineral = t.mineral,
                        tectonic_setting = t.tectonic_setting
                    })
                    .Take(250)
                    .ToList();

                return View(data);
            }
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
    }
}