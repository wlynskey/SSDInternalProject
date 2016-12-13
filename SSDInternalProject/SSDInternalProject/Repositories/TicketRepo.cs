using SSDInternalProject.ViewModels;
using System.Collections.Generic;

namespace SSDInternalProject.Controllers.Repositories {
    public class TicketRepo {
        public List<TicketVM> GetTickets(string userName) {
            List <TicketVM> items = new List<TicketVM>();
            TicketVM item = new TicketVM();
            // Hard code now, query the DB in the future
            item.ID = "001";
            item.Status = "Shipping";
            item.OrderName = "Pat";
            item.Cost = "10$";
            items.Add(item);
            TicketVM item2 = new TicketVM();
            item2.ID = "002";
            item2.Status = "Processing";
            item2.OrderName = "Pat";
            item2.Cost = "20$";
            items.Add(item2);
            return items;
        }
    }
}
