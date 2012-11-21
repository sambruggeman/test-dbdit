using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using WebMatrix.WebData;

namespace dbdit
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        private const string adminRole = "Admin";
        private const string adminUserName = "Sam";
        private const string adminPassword = "P@ssw0rd";

        protected void Application_Start()
        {
            InitSecurity();

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();

            Bootstrapper.Initialise();

        }

        public static void InitSecurity()
        {
            WebMatrix.WebData.WebSecurity.InitializeDatabaseConnection("DefaultConnection", "UserProfiles", "Id", "UserName", autoCreateTables: true);

            if (!Roles.RoleExists(adminRole))
            {
                Roles.CreateRole(adminRole);
            }

            if (!WebSecurity.UserExists(adminUserName))
            {
                WebSecurity.CreateUserAndAccount(adminUserName, adminPassword);
            }

            if (!Roles.IsUserInRole(adminUserName, adminRole))
            {
                Roles.AddUserToRole(adminUserName, adminRole);
            }
        }
    }
}