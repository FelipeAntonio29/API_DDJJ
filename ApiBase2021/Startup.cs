using Microsoft.Owin;
using Owin;
using System.Web.Http.WebHost;
using System.Web.SessionState;
using System.Web.Routing;
using System.Web;

[assembly: OwinStartup(typeof(ApiBase2021.Startup))]

namespace ApiBase2021
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }

    public class SessionControllerHandler : HttpControllerHandler, IRequiresSessionState
    {
        public SessionControllerHandler(RouteData routeData)
            : base(routeData)
        { }
    }

    public class SessionHttpControllerRouteHandler : HttpControllerRouteHandler
    {
        protected override IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new SessionControllerHandler(requestContext.RouteData);
        }
    }
}
