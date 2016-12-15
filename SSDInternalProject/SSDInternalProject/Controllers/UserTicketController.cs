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
        // GET: UserTicket
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TicketUsers(int id)
        {
            UserTicketRepo utRepo = new UserTicketRepo();
            ViewBag.TicketId = id;
            return View(utRepo.GetUsersForTicket(id));
        }
        public ActionResult AddUserTicket(int id)
        {
            ViewBag.TicketId = id;
            RoleRepo rRepo = new RoleRepo();
            ViewBag.Roles = rRepo.GetRolesList();
            UserRoleRepo urRepo = new UserRoleRepo();
            ViewBag.UserRoles = urRepo.GetUserRoleList();
            return View();
        }
    }
}