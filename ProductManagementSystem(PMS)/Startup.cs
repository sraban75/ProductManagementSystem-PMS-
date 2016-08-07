using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductManagementSystem_PMS_.Startup))]
namespace ProductManagementSystem_PMS_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
