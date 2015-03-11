using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TravelExpenses.View.Startup))]
namespace TravelExpenses.View
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
