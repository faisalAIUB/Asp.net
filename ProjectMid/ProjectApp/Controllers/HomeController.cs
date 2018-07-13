using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectRepository;

namespace ProjectApp.Controllers
{
    public class HomeController : Controller
    {
        RentRepository rentRepo = new RentRepository();
        // GET: Home
        public ActionResult Index()
        {
            
            return View(rentRepo.GetAll());
        }
    }
}