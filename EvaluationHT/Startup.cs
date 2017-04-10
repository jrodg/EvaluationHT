using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EvaluationHT.Startup))]
namespace EvaluationHT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
