using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProgettoSettimanale.Startup))]
namespace ProgettoSettimanale
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
