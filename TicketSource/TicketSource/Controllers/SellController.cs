using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using TicketSource.Models;

namespace TicketSource.Controllers
{
    public class SellController : Controller
    {
        // GET: Sell
        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }

        // POST: Sell
        [HttpPost]
        public ActionResult Index(SellViewModel thisModel)
        {
            Random rnd = new Random();

            var ticketID = rnd.Next(1, 999999999);
            var userId = User.Identity.GetUserId();
            var ticket = new Ticket { PriceWanted = (decimal) thisModel.PriceWanted,
                                      Section = thisModel.TicketSection,
                                      Row = thisModel.TicketRow,
                                      Seat = thisModel.TicketSeat,
                                      SellerID = userId,
                                      TicketID = ticketID
                                     };
            var context = new TicketSourceDBDataContext();
            context.Tickets.InsertOnSubmit(ticket);
            context.SubmitChanges();
            return View();
        }

        // GET: Sell/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sell/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sell/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sell/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sell/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sell/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sell/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
