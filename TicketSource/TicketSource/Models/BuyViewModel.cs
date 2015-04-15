using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace TicketSource.Models
{
    public class BuyViewModel
    {
            public IEnumerable<Ticket> AllTickets { get; set; }
            public Ticket newTicket { get; set; }
            public string Url { get; set; }
        
    }


}