using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BirthdayReminder.Startup))]
namespace BirthdayReminder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
