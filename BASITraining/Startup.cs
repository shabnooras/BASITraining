using Microsoft.Owin;
using Microsoft.AspNet.Identity;
using Owin;
using Microsoft.Owin.Security.Cookies;

[assembly: OwinStartupAttribute(typeof(BASITraining.Startup))]
namespace BASITraining
{
    public partial class Startup {
        public void Configuration(IAppBuilder app)
        {
            //configure OWIN cookie authentication
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Login")
            });
        }
    }
}
