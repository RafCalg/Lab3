using Lab3.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Lab3.Controllers
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
            
        public ActionResult Products(string id)
        {
            List<Product> products = ProductDB.GetProductByID(id);
            return View(products);
        }
    }
}