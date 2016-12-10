using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace the_volume_360.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public String FileTransfer()
        {
            String folder = "~/Views";
            
           
            return  folder;
        }
        public ActionResult Gallery()
        {
            string path = Server.MapPath("~/Products");
            List<string> Folders = new List<string>();

          //  if (Directory.GetFiles(path, "*.jpg").Length > 0)
            //    picFolders.Add(path);

           //// if (Directory.GetFiles(path).Length > 0)
           // var path1 = path + "/folder From project";
           // Directory.CreateDirectory(path1);
             //   Folders.Add(path);
            foreach (string dir in Directory.GetDirectories(path))
            {
                //if (Directory.GetFiles(dir).Length > 0)
                   // Folders.Add(dir);
                Folders.Add(new DirectoryInfo(dir).Name);
            }

            return View(Folders);
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