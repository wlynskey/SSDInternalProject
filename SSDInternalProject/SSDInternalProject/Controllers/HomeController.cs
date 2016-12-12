using SSDInternalProject.Controllers.Repositories;
using SSDInternalProject.ViewModels;
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
            string catagory = formCollection["choice"];
            string name = formCollection["username"];
            string password = formCollection["password"];
            switch(catagory) {
                case "Customer":
                    return RedirectToAction("Customer", "Home", new { userName = name, password = password });
                case "Staff":
                case "Administrator":
                    return RedirectToAction("Staff", "Home", new { userName = name, password = password });
                default:
                    return View();
            }
        }

        [HttpGet]
        public ActionResult Register() {
            return View();
        }

        [HttpPost]
        public ActionResult Register(string Name, 
                string Password, string Phone, string Address) {
            AccountRepo aRepo = new AccountRepo();
            aRepo.CreateAccount(Name, Password, Phone, Address);
            return RedirectToAction("Customer", "Home", new { userName = Name });
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
            AccountRepo aRepo = new AccountRepo();
            AccountVM item = aRepo.GetAccountInfo(userName);
            return View(item);
        }

        [HttpGet]
        public ActionResult EditAccount(int ID) {
            AccountRepo aRepo = new AccountRepo();
            AccountVM item = aRepo.GetAccountInfoByID(ID);
            return View(item);
        }

        [HttpPost]
        public ActionResult EditAccount(AccountVM aVm ) {
            AccountRepo aRepo = new AccountRepo();
            aRepo.EditAccount(aVm);
            return RedirectToAction("AccountDetail", "Home");
        }

        public ActionResult ViewTicketLists(string userName) {
            ViewBag.userName = userName;
            TicketRepo aRepo = new TicketRepo();
            List<TicketVM> items = aRepo.GetTickets(userName);
            return View(items);
        }

        public ActionResult Evaluating(string userName) {
            ViewBag.userName = userName;
            return View();
        }
    }
}