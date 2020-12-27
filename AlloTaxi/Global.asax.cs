using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AlloTaxi.Models;
using System.Data.Entity;
using AlloTaxi.Models.Db;

namespace AlloTaxi
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
           
            var context = new DbModels();
            context.Database.Initialize(true);
        }
    }
}
