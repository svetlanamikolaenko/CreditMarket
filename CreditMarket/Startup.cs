using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CreditMarket.Startup))]
namespace CreditMarket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
