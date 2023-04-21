using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestioneAlbergo.Startup))]
namespace GestioneAlbergo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
