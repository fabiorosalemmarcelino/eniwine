using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EniWine.Investigacao.WebApplication.Startup))]
namespace EniWine.Investigacao.WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
