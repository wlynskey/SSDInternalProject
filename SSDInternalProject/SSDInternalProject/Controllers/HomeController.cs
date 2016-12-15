
using SSDInternalProject.Controllers.Repositories;
using SSDInternalProject.Repositories;
using SSDInternalProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SSDInternalProject.Controllers {
    public class HomeController : Controller {

        public ActionResult Index() {
            return View();
        }

        [HttpGet]
        public ActionResult Login() {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Login(FormCollection formCollection) {
            string name = formCollection["username"];
            string password = formCollection["password"];
            UserRepo uRpo = new UserRepo();
            if (uRpo.LoginSuccessfully(name, password)) {
                return RedirectToAction("Customer", "Home", new { userName = name, password = password });
            } else {
                ViewBag.errorMessage = "Permission denied, try again the username and password";
                return View();
            }
        }

        [HttpGet]
        public ActionResult Register() {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserVM user) {
            UserRepo aRepo = new UserRepo();
            aRepo.Create(user);
            return RedirectToAction("Customer", "Home", new { userName = user.FirstName + " " + user.LastName });
        }

        public ActionResult Customer(string userName) {
            ViewBag.userName = userName;
            return View();
        }

        public ActionResult Staff(string userName) {
            ViewBag.userName = userName;
            return View();
        }

        public ActionResult AccountDetail(string userName) {
            ViewBag.userName = userName;
            UserRepo aRepo = new UserRepo();
            UserVM item = aRepo.GetUserInfo(userName);
            return View(item);
        }

        [HttpGet]
        public ActionResult EditAccount(int ID) {
            UserRepo aRepo = new UserRepo();
            UserVM item = aRepo.GetUserInfo(ID);
            return View(item);
        }

        [HttpPost]
        public ActionResult EditAccount(UserVM aVm ) {
            UserRepo aRepo = new UserRepo();
            aRepo.Update(aVm);
            return RedirectToAction("AccountDetail", "Home");
        }

        public ActionResult ViewTicketLists(string userName) {
            ViewBag.userName = userName;
            TicketRepo aRepo = new TicketRepo();
            List<TicketVM> items = aRepo.GetSampleTickets(userName);
            return View(items);
        }

        public ActionResult Evaluating(string userName) {
            ViewBag.userName = userName;
            RepairRepo rRepo = new RepairRepo();
            List<RepairVM> items = rRepo.GetRepairList();
            return View(items);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EvaluatingDetail(FormCollection formCollection) {
            string userName = formCollection["userName"];
            ViewBag.userName = userName;
            RepairRepo rRepo = new RepairRepo();
            RepairVM item = rRepo.GetRepair(Convert.ToInt16(formCollection["SelectedRepairItems"]));
            return View(item);
        }
    }
}