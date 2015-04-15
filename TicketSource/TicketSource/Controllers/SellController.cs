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
        [Authorize]
        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }

        // POST: Sell
        [Authorize]
        [HttpPost]
        public ActionResult Index(SellViewModel thisModel)
        {
            Random rnd = new Random();

            var ticketID = rnd.Next(1, 999999999);

            //Add logic here to skip ticketID if the value exists
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
     
        }
    }

