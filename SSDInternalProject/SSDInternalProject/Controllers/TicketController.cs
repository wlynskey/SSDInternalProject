using SSDInternalProject.Controllers.Repositories;
using SSDInternalProject.Repositories;
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
            ViewBag.HideHeaderImg = true;
            return View();
        }
        public ActionResult TicketList()
        {
            TicketRepo tRepo = new TicketRepo();
            List<TicketVM> list = tRepo.GetAllTickets();
            ViewBag.HideHeaderImg = true;
            return View(list);
        }
        public ActionResult EvaluationList()
        {
            TicketRepo tRepo = new TicketRepo();
            List<TicketVM> list = tRepo.GetEvaluation();
            ViewBag.HideHeaderImg = true;
            return View(list);
        }
        public ActionResult Details(int id)
        {
            TicketRepo tRepo = new TicketRepo();
            TicketVM ticket = tRepo.GetTicket(id);
            ViewBag.HideHeaderImg = true;
            return View(ticket);
        }
        public ActionResult Edit(int id)
        {
            TicketRepo tRepo = new TicketRepo();
            TicketVM ticket = tRepo.GetTicket(id);
            StatusRepo sRepo = new StatusRepo();
            ViewBag.Statuses = sRepo.GetStatusList();
            DeviceRepo dRepo = new DeviceRepo();
            ViewBag.Devices = dRepo.GetDeviceList();
            RepairRepo rRepo = new RepairRepo();
            ViewBag.Repairs = rRepo.GetRepairList();
            BrandRepo bRepo = new BrandRepo();
            ViewBag.Brands = bRepo.GetBrandList();
            ViewBag.HideHeaderImg = true;
            return View(ticket);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit()
        {
            //Do stuff for saving and editing here.
            ViewBag.HideHeaderImg = true;
            return RedirectToAction("TicketList");
        }
        public ActionResult Delete(int id)
        {
            TicketRepo tRepo = new TicketRepo();
            TicketVM ticket = tRepo.GetTicket(id);
            ViewBag.HideHeaderImg = true;
            return View(ticket);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete()
        {
            //Do stuff for deleting here.
            ViewBag.HideHeaderImg = true;
            return RedirectToAction("TicketList");
        }
        public ActionResult Create()
        {
            StatusRepo sRepo = new StatusRepo();
            ViewBag.Statuses = sRepo.GetStatusList();
            DeviceRepo dRepo = new DeviceRepo();
            ViewBag.Devices = dRepo.GetDeviceList();
            RepairRepo rRepo = new RepairRepo();
            ViewBag.Repairs = rRepo.GetRepairList();
            BrandRepo bRepo = new BrandRepo();
            ViewBag.Brands = bRepo.GetBrandList();
            ViewBag.HideHeaderImg = true;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TicketVM ticket)
        {
            //Do stuff for creating here.
            ViewBag.HideHeaderImg = true;
            return RedirectToAction("TicketList");
        }
    }
}