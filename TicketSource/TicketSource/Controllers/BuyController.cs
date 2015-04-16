using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
            return View(model);
        }


        // GET: Buy/Purchase/5
        public ActionResult Purchase(int id)
        {
            var context = new TicketSourceDBDataContext();
            var model = new BuyViewModel
            {
                newTicket = context.Tickets.First(i => i.TicketID == id)
            };
            return View(model);
        }


        // GET: Buy/Purchase/5
        public ActionResult Finalized(int id)
        {
            var context = new TicketSourceDBDataContext();
            var model = new BuyViewModel
            {
                newTicket = context.Tickets.First(i => i.TicketID == id)
            };
            model.newTicket.Active = false;
            context.SubmitChanges();
            return View(model);
        }



    }
}
