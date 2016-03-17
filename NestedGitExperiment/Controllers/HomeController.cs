using LibGit2Sharp;
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
            ViewBag.Text = System.IO.File.ReadAllText(textPath);
            return View();
        }

        public ActionResult UpdateAssets()
        {
            var assetsPath = Server.MapPath("~/Assets");
            using (var repo = new Repository(assetsPath))
            {
                repo.Fetch("origin", new FetchOptions() { TagFetchMode = TagFetchMode.None });
                var remoteBranch = repo.Branches.First(x => x.FriendlyName == "origin/master");
                var signature = new Signature("Jakub Macek", "1@jakubmacek.cz", DateTimeOffset.Now);
                var mergeResult = repo.Merge(remoteBranch, signature);
            }

            return RedirectToAction("Index");
        }
    }
}