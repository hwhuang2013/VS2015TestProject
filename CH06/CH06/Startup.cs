using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CH06.Startup))]
namespace CH06
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
