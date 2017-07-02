using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CsvToPo.Startup))]
namespace CsvToPo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
