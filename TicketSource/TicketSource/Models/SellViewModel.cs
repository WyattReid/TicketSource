﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace TicketSource.Models
{
    public class SellViewModel
    {
            
            public string TicketID { get; set; }

            [Required]
            [Display(Name = "Ticket Section")]
            public string TicketSection { get; set; }

            [Required]
            [Display(Name = "Ticket Row")]
            public string TicketRow { get; set; }

            [Required]
            [Display(Name = "Ticket Seat")]
            public string TicketSeat { get; set; }

            [Required]
            [Display(Name = "Price Wanted")]
            public double PriceWanted { get; set; }

            public string SellerID { get; set; }

            public string Url { get; set; }
        
    }


}