using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlowMania.Startup))]
namespace FlowMania
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
