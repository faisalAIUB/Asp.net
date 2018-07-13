using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectRepository;

namespace ProjectApp.Controllers
{
    public class RentController : Controller
    {
        RentRepository repo = new RentRepository();
        [HttpGet]
        public ActionResult UploadAd()
        {
            ViewBag.District = repo.GetDistrict();
            ViewBag.Thana = repo.GetThana();
            return View();
        }
        [HttpPost]
        public ActionResult UploadAd(RentAd rent)
        {
            if (ModelState.IsValid) { 
                repo.Insert(rent);
            return RedirectToAction("Profile","User");
            }
            else
            {
                return View(rent);
            }

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            
           
            return View(repo.Get(id));
        }
        [HttpPost]
        public ActionResult Edit(RentAd rent)
        {
            repo.Edit(rent);
            return RedirectToAction("Profile", "User");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(repo.Get(id));
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            repo.Delete(id);
            return RedirectToAction("Profile", "User");
        }
        public ActionResult Detail(int id)
        {
            TempData["thana"] = repo.GetThana(id);
            TempData["dis"] = repo.GetDistrict(id);
            return View(repo.Get(id));
        }
        
    }
}