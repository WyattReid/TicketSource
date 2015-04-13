using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TicketSource.Startup))]
namespace TicketSource
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
