using ProjectRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ProjectApp.Controllers
{
    public class UserController : Controller
    {
        UserRepository repo = new UserRepository();
        RentRepository rentRepo = new RentRepository();
        // GET: User
        
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid) { 
            repo.Insert(user);
            return RedirectToAction("Index","Home");
            }
            else
            {
                return View(user);
            }
        }
        [HttpGet]
        public ActionResult LogIn()
        {
               
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(string Email,string Password)
        {
           int i=repo.LogIn(Email, Password);
            
            if (i == 0)
            {
                return View();
            }
            else
            {
                Session["id"] = i;
                return RedirectToAction("Profile", "User");
            }
        }
        [HttpGet]
        public ActionResult Profile()
        {
            try
            {
                int id = (Int32)Session["id"];
                return View(rentRepo.GetById(id));
            }
            catch (Exception)
            {
                RedirectToAction("LogIn", "User");
            }
            return RedirectToAction("LogIn", "User");
            // ViewBag.RentAd = rentRepo.GetById(id);

        }
        [HttpPost]
        [ActionName("Profile")]
        public ActionResult profile()
        {
            Session.Contents.RemoveAll();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult EditProfile()
        {
            int id = (Int32)Session["id"];
            return View(repo.Get(id));
        }
        [HttpPost]
        public ActionResult EditProfile(UserEdit user)
        {
            repo.Edit(user);
            return RedirectToAction("Profile", "User");
        }
        //public string test()
        //{
        //    int i = 0;
        //    RentAd[] a = new RentAd[100];
        //    int id = 1;
        //    var s = rentRepo.GetById(id).ToString();
        //    foreach(RentAd r in rentRepo.GetById(id))
        //    {
        //        a[i] = r;
        //        i++;
        //    }
        //    return a[1].HouseNo;
        //}
    }
}