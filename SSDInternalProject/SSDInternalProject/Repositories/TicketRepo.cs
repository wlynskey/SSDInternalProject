using SSDInternalProject.ViewModels;
using System.Collections.Generic;
using SSDInternalProject.Repositories;
using System;

namespace SSDInternalProject.Controllers.Repositories {
    public class TicketRepo {

        private TicketVM[] tickets =
        {
            new TicketVM
            {
                TicketVMId = 3,
                StatusVMId = 1,
                DeviceVMId = 1,
                RepairVMId = 1,
                CreationDate = new DateTime(),
                Notes = "Need to switch out hard drive is SSD",
                QuotedCost = 100.95M
            },
            new TicketVM
            {
                TicketVMId = 2,
                StatusVMId = 2,
                DeviceVMId = 2,
                CreationDate = new DateTime(2016, 11, 10),
                RepairStartDate = new DateTime(),
                Notes = "He doesn't know what's wrong, it just needs to be fixed",
                QuotedCost = 500M
            },
            new TicketVM
            {
                TicketVMId = 1,
                StatusVMId = 4,
                DeviceVMId = 3,
                RepairVMId = 2,
                CreationDate = new DateTime(2016, 11, 1),
                RepairStartDate = new DateTime(2016, 11, 15),
                RepairFinishDate = new DateTime(),
                Notes = "Upgrade Ram from 4 GB to 16 GB",
                QuotedCost = 200M
            }
        };


        public List<TicketVM> GetSampleTickets(string userName) {
            List <TicketVM> items = new List<TicketVM>();
            foreach(TicketVM item in tickets)
            {
                items.Add(item);
            }
            return items;
        }

        public List<TicketVM> GetAllTickets()
        {
            List<TicketVM> items = new List<TicketVM>();
            foreach (TicketVM item in tickets)
            {
                items.Add(item);
            }
            return items;
        }

        public TicketVM GetTicket(int id)
        {
            List<TicketVM> items = GetAllTickets();
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].TicketVMId == id)
                {
                    return items[i];
                }
            }
            return null;
        }

        public List<TicketVM> GetEvaluation()
        {
            List<TicketVM> items = new List<TicketVM>();
            foreach (TicketVM item in tickets)
            {
                if (item.StatusVMId == 1)
                {
                    items.Add(item);
                }                
            }
            return items;
        }
    }
}
