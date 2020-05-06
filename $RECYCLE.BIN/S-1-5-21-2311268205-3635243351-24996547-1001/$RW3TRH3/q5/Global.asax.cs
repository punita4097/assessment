using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace q5
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Application["Total Application"] = 0;
            Application["Total User session"] = 0;
            Application["Total Application"] = (int)Application["Total Application"] + 1;



        }
        void Session_start(object sender,EventArgs e)
        {
            Application["Total user session"] = (int)Application["Total user session"] + 1;

        }

        void Session_end(object sender, EventArgs e)
        {
            Application["Total user session"] = (int)Application["Total user session"] - 1;

        }


    }
}