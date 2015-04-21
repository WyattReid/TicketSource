using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using TicketSource.Models;

namespace TicketSource.Controllers
{
    public class BuyController : Controller
    {
        // GET: Buy
        public ActionResult Index()
        {
            var context = new TicketSourceDBDataContext();
            var model = new BuyViewModel
            {
                AllTickets = context.Tickets.Where(i => (i.TicketID > -1) && (i.Active == true))
            };
            context.SubmitChanges();

            return View(model);
        }

        // GET: Buy/Details/5
        public ActionResult Details(int id)
        {
            var context = new TicketSourceDBDataContext();
            var model = new BuyViewModel
            {
                newTicket = context.Tickets.First(i => i.TicketID == id)
            };
            context.SubmitChanges();

            return View(model);
        }

        

        

        //this is where the magic happens
        [HttpGet]
        [Authorize]
        // GET: Buy/Purchase/5
        public ActionResult Purchase(int id)
        {
            var userId = User.Identity.GetUserId();
            int rID = id;
            var context = new TicketSourceDBDataContext();
            var newTicket = context.Tickets.FirstOrDefault(i => i.TicketID == rID);

            newTicket.Active = false;
            newTicket.BuyerID = userId;

            Debug.WriteLine("Ticket # " +rID);
            Debug.WriteLine("Sold to: " +newTicket.BuyerID);

            context.SubmitChanges();

            Debug.WriteLine("The magic happenned");

            return RedirectToAction("Finalized");
        }


        [HttpGet]
        [Authorize]
        // GET: Buy/Purchase/5
        public ActionResult Finalized()
        {
            
            return View();
        }



    }
}
