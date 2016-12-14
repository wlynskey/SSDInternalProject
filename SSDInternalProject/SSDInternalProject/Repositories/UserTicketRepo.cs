using SSDInternalProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSDInternalProject.Repositories
{
    public class UserTicketRepo
    {
        private UserTicketVM[] userTickets =
        {
            new UserTicketVM
            {
                UserTicketVMId = 1,
                UserVMId = 1,
                TicketVMId = 1,
                RoleVMId = 1
            },
            new UserTicketVM
            {
                UserTicketVMId = 2,
                UserVMId = 2,
                TicketVMId = 2,
                RoleVMId = 1
            },
            new UserTicketVM
            {
                UserTicketVMId = 3,
                UserVMId = 3,
                TicketVMId = 3,
                RoleVMId = 1
            }
        };

        public List<UserTicketVM> GetUserTicketList()
        {
            List<UserTicketVM> list = new List<UserTicketVM>();
            foreach(UserTicketVM item in userTickets)
            {
                list.Add(item);
            }
            return list;
        }
    }
}