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
            return View(uRepo.GetAllCustomers());
        }
        public ActionResult Details(int id)
        {
            UserRepo uRepo = new UserRepo();
            return View(uRepo.GetUserInfo(id));
        }
        public ActionResult Edit(int id)
        {
            UserRepo uRepo = new UserRepo();
            return View(uRepo.GetUserInfo(id));

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit()
        {
            return RedirectToAction("Index", "Customer");
        }
        public ActionResult Delete(int id)
        {
            UserRepo uRepo = new UserRepo();
            return View(uRepo.GetUserInfo(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete()
        {
            return RedirectToAction("Index", "Customer");
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserVM user)
        {
            return RedirectToAction("Index", "Customer");
        }
    }
}