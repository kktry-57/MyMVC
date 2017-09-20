using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MyMVC.Services;
using MyMVC.Models;
namespace MyMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            MyMVC.Models.MemberViewModel member = new MemberViewModel()
            {
                ID = "1",
                Name = "KK",
                PhoneNo = "03-123456",
                Department = "S1"
            };
            MemberSvc.Add(member);
            MemberSvc.Add(member);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
