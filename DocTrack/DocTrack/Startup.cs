using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DocTrack.Startup))]
namespace DocTrack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
