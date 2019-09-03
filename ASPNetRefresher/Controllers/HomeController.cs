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
                        mineral = t.mineral
                    })
                    .Take(100)
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