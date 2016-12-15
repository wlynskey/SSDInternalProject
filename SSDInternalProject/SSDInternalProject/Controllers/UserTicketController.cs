using SSDInternalProject.Repositories;
using SSDInternalProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SSDInternalProject.Controllers
{
    public class UserTicketController : Controller
    {

        public ActionResult TicketUsers(int id)
        {
            UserTicketRepo utRepo = new UserTicketRepo();
            ViewBag.TicketId = id;
            ViewBag.HideHeaderImg = true;
            return View(utRepo.GetUsersForTicket(id));
        }
        public ActionResult AddUserTicket(int id)
        {
            ViewBag.TicketId = id;
            RoleRepo rRepo = new RoleRepo();
            ViewBag.Roles = rRepo.GetRolesList();
            UserRoleRepo urRepo = new UserRoleRepo();
            ViewBag.UserRoles = urRepo.GetUserRoleList();
            ViewBag.HideHeaderImg = true;
            return View();
        }
        public ActionResult Details(int id)
        {
            UserTicketRepo urRepo = new UserTicketRepo();
            ViewBag.HideHeaderImg = true;
            return View(urRepo.GetUserTicket(id));
        }
        public ActionResult Delete(int id)
        {
            UserTicketRepo urRepo = new UserTicketRepo();
            ViewBag.HideHeaderImg = true;
            return View(urRepo.GetUserTicket(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete()
        {
            ViewBag.HideHeaderImg = true;
            return RedirectToAction("TicketUsers", "UserTicket");
        }
    }
}