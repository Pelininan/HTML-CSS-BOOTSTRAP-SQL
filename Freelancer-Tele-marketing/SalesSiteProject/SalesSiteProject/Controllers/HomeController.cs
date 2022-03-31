

using SalesSiteProject.Models;
using System.Web.Mvc;

namespace SalesSiteProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       [Route("About")]
        public ActionResult About()
        {
            return View();
        }
        [Route("Products")]
        public ActionResult Products()
        {
            return View();
        }
        [Route("Store")]
        public ActionResult Store()
        {
            return View();
        } 

        [Route("Communication")]
        public ActionResult Communication()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Communication(FormCollection form)
        {
            
            SalessSiteProjectDBEntities db = new SalessSiteProjectDBEntities();
            FormDb model = new FormDb();
            model.City = form["city"].Trim();
            model.UserName = form["name"].Trim();
            model.UserEmail = form["email"].Trim();
            model.PhoneNumber = form["phoneNumber"].Trim();
            model.Product = form["product"].Trim();
            model.Message = form["message"].Trim();
            db.FormDbs.Add(model);
            db.SaveChanges();
      
            

            return View();
        }

    
    }
}