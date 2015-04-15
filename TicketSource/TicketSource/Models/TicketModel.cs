namespace TicketSource.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Entity;

    public class TicketModel : DbContext
    {
        // Your context has been configured to use a 'TicketModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TicketSource.Models.TicketModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TicketModel' 
        // connection string in the application configuration file.
        public TicketModel()
            : base("DefaultConnection")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Tickets> TicketSet { get; set; }
        public virtual DbSet<UserTickets> UserTicketSet { get; set; }
    }

    // Adding class for Tickets
    public class Tickets
    {
        public String TicketID { get; set; }
        public String TicketSection { get; set; }
        public String TicketRow { get; set; }
        public String TicketSeat { get; set; }
        public Double PriceWanted { get; set; }
        public string Url { get; set; }
    }

    //Adding association table for (Users HAS Tickets)
    public class UserTickets
    {
        public String TicketID { get; set; }
        public String UserID { get; set; }
        public string Url { get; set; }
    }



}