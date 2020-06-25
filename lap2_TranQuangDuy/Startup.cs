using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lap2_TranQuangDuy.Startup))]
namespace lap2_TranQuangDuy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
