using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Spire.Doc;
using Spire.Doc.Documents;


namespace DocuVie.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            Document document = new Document();
            string path = AppDomain.CurrentDomain.BaseDirectory + "/Documents/word.docx";
            document.LoadFromFile(path);
            document.SaveToFile(AppDomain.CurrentDomain.BaseDirectory + "/Documents/"+"PDF_VERSION.PDF", FileFormat.PDF);
            ViewBag.IFrame = "~/Documents/" + "PDF_VERSION.PDF";
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