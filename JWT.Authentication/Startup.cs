using System;
using System.Threading.Tasks;
using System.Web.Http;
using JWT.Authentication.Data;
using JWT.Authentication.Security;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;

[assembly: OwinStartup(typeof(JWT.Authentication.Startup))]

namespace JWT.Authentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
