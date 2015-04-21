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

        
        [HttpGet]
        [Authorize]
        // GET: Buy/Purchase/5
        public ActionResult Purchase(string id)
        {
            return View(id);
        }
        

        //this is where the magic happens
        [HttpPost]
        [Authorize]
        // GET: Buy/Purchase/5
        public ActionResult Purchase(int id)
        {
            int rID = id;
            var context = new TicketSourceDBDataContext();
            var newTicket = context.Tickets.FirstOrDefault(i => i.TicketID == rID);
            newTicket.Active = false;

            Debug.WriteLine(rID);
            Debug.WriteLine(newTicket);

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
