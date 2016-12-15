using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSDInternalProject.ViewModels;
using SSDInternalProject.Controllers.Repositories;
using SSDInternalProject.Repositories;

namespace SSDInternalProject.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index(int userId)
        {
            UserRoleRepo urRepo = new UserRoleRepo();
            UserRepo uRepo = new UserRepo();
            List<UserRoleVM> userRoles = urRepo.GetUserRoleList();
            for (int i = 0; i < userRoles.Count; i++)
            {
                if (userRoles[i].UserVMId == userId && userRoles[i].RoleVMId == 2)
                {
                    ViewBag.StaffName = uRepo.GetUserInfo(userRoles[i].UserVMId).FirstName;
                }
            }
            ViewBag.HideHeaderImg = true;
            return View();
        }

        public ActionResult StaffDetail(int id)
        {
            UserRepo uRepo = new UserRepo();
            ViewBag.HideHeaderImg = true;
            return View(uRepo.GetUserInfo(id));
        }
        public ActionResult Edit(int id)
        {
            UserRepo uRepo = new Repositories.UserRepo();
            ViewBag.HideHeaderImg = true;
            return View(uRepo.GetUserInfo(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit()
        {
            ViewBag.HideHeaderImg = true;
            return RedirectToAction("Index", "Staff");
        }
    }
}