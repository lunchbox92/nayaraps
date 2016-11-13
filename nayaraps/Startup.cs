using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nayaraps.Startup))]
namespace nayaraps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
