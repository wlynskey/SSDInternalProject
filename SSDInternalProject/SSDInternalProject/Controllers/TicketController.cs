using SSDInternalProject.Controllers.Repositories;
using SSDInternalProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSDInternalProject.Controllers
{
    public class TicketController : Controller
    {
        // GET: Ticket
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TicketList()
        {
            TicketRepo tRepo = new TicketRepo();
            List<TicketVM> list = tRepo.GetAllTickets();
            return View(list);
        }
        public ActionResult EvaluationList()
        {
            TicketRepo tRepo = new TicketRepo();
            List<TicketVM> list = tRepo.GetEvaluation();
            return View(list);
        }
        public ActionResult Details(int id)
        {
            TicketRepo tRepo = new TicketRepo();
            TicketVM ticket = tRepo.GetTicket(id);
            return View(ticket);
        }
        public ActionResult Edit(int id)
        {
            TicketRepo tRepo = new TicketRepo();
            TicketVM ticket = tRepo.GetTicket(id);
            return View(ticket);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit()
        {
            //Do stuff for saving and editing here.
            return RedirectToAction("TicketList");
        }
        public ActionResult Delete(int id)
        {
            TicketRepo tRepo = new TicketRepo();
            TicketVM ticket = tRepo.GetTicket(id);
            return View(ticket);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete()
        {
            //Do stuff for deleting here.
            return RedirectToAction("TicketList");
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TicketVM ticket)
        {
            //Do stuff for creating here.
            return RedirectToAction("TicketList");
        }
    }
}