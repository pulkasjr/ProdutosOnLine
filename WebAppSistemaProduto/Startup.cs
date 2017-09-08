using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppSistemaProduto.Startup))]
namespace WebAppSistemaProduto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
