using SSDInternalProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSDInternalProject.Repositories
{
    public class RoleRepo
    {
        private RoleVM[] rolesList = {
            new RoleVM
            {
                RoleVMId = 1,
                Role = "customer"
            },
            new RoleVM
            {
                RoleVMId = 2,
                Role = "staff"
            },
            new RoleVM
            {
                RoleVMId = 3,
                Role = "admin"
            }
        };

        public List<RoleVM> GetRolesList()
        {
            List<RoleVM> list = new List<RoleVM>();
            foreach(RoleVM item in rolesList)
            {
                list.Add(item);
            }
            return list;
        }

    }
}