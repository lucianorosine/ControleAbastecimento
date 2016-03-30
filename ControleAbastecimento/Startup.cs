using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControleAbastecimento.Startup))]
namespace ControleAbastecimento
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
