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
                AllTickets = context.Tickets.Where(i => i.TicketID > -1)
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

     
        
    }
}
