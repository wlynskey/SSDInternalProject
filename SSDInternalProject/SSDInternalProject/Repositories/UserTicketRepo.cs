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
                UserVMId = 1,
                TicketVMId = 2,
                RoleVMId = 1
            },
            new UserTicketVM
            {
                UserTicketVMId = 3,
                UserVMId = 1,
                TicketVMId = 3,
                RoleVMId = 1
            },
            new UserTicketVM
            {
                UserTicketVMId = 4,
                UserVMId = 2,
                TicketVMId = 2,
                RoleVMId = 2
            },
             new UserTicketVM
            {
                UserTicketVMId = 5,
                UserVMId = 2,
                TicketVMId = 3,
                RoleVMId = 2
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
        public List<UserTicketVM> GetUsersForTicket(int id)
        {
            List<UserTicketVM> list = GetUserTicketList();
            List<UserTicketVM> returnList = new List<UserTicketVM>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].TicketVMId == id)
                {
                    returnList.Add(list[i]);
                }
            }
            return returnList;
        }
        public UserTicketVM GetUserTicket(int id)
        {
            List<UserTicketVM> list = GetUserTicketList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].UserTicketVMId == id)
                {
                    return list[i];
                }
            }
            return null;
        }
    }
}