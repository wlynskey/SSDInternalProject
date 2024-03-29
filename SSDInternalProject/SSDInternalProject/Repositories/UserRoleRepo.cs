﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSDInternalProject.ViewModels;

namespace SSDInternalProject.Repositories
{
    public class UserRoleRepo
    {
        private UserRoleVM[] userRoleList =
        {
            new UserRoleVM
            {
                UserRoleVMId = 1,
                RoleVMId = 1,
                UserVMId = 1,
                DateAssigned = new DateTime()
            },
            new UserRoleVM
            {
                UserRoleVMId = 2,
                RoleVMId = 2,
                UserVMId = 2,
                DateAssigned = new DateTime()
            }
        };
        public List<UserRoleVM> GetUserRoleList()
        {
            List<UserRoleVM> list = new List<UserRoleVM>();
            foreach(UserRoleVM item in userRoleList)
            {
                list.Add(item);
            }
            return list;
        }
        public UserRoleVM GetUserRole(int id)
        {
            List<UserRoleVM> list = GetUserRoleList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].UserRoleVMId == id)
                {
                    return list[i];
                }
            }
            return null;
        }
    }
}