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
            //For TESTING
            if(userId == 0)
            {
                userId = 2;
            }
            // ---------------
            UserRoleRepo urRepo = new UserRoleRepo();
            UserRepo uRepo = new UserRepo();
            List<UserRoleVM> userRoles = urRepo.GetUserRoleList();
            for(int i = 0; i < userRoles.Count; i++)
            {
                if (userRoles[i].UserVMId == userId && userRoles[i].RoleVMId == 2)
                {
                    ViewBag.StaffName = uRepo.GetUserInfo(userRoles[i].UserVMId).FirstName;
                }
            }
            return View();
        }
    }
}