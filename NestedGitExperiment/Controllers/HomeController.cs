using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NestedGitExperiment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var textPath = Server.MapPath("~/Assets/text.txt");
            //ViewBag.Text = System.IO.File.ReadAllText(textPath);
            return View();
        }
    }
}