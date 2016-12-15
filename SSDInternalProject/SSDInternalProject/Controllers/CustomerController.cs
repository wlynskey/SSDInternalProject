using SSDInternalProject.Controllers.Repositories;
using SSDInternalProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSDInternalProject.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            UserRepo uRepo = new UserRepo();
            ViewBag.HideHeaderImg = true;        
            return View(uRepo.GetAllCustomers());
        }
        public ActionResult Details(int id)
        {
            UserRepo uRepo = new UserRepo();
            ViewBag.HideHeaderImg = true;
            return View(uRepo.GetUserInfo(id));
        }
        public ActionResult Edit(int id)
        {
            UserRepo uRepo = new UserRepo();
            ViewBag.HideHeaderImg = true;
            return View(uRepo.GetUserInfo(id));

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit()
        {
            ViewBag.HideHeaderImg = true;
            return RedirectToAction("Index", "Customer");
        }
        public ActionResult Delete(int id)
        {
            ViewBag.HideHeaderImg = true;
            UserRepo uRepo = new UserRepo();
            return View(uRepo.GetUserInfo(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete()
        {
            ViewBag.HideHeaderImg = true;
            return RedirectToAction("Index", "Customer");
        }
        public ActionResult Create()
        {
            ViewBag.HideHeaderImg = true;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserVM user)
        {
            ViewBag.HideHeaderImg = true;
            return RedirectToAction("Index", "Customer");
        }
    }
}