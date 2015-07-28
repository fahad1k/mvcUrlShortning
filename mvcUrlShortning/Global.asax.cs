using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using mvcUrlShortning.Models;

namespace mvcUrlShortning
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "srt", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterRoutes(RouteTable.Routes);

            Application["urlList"] = new List<urlDetails>() { 
              new urlDetails()
                    {
                        Srno = 1,
                        longUrl = "http://www.bbc.com/urdu/regional/2015/07/150728_abdul_kalam_remembered_mb",
                        uniqueID = "xCetRe",
                        shortUrl= "http://localhost:50898/srt/url/xCetRe",
                        date = new DateTime(2015,07, 12),
                        
                    },
                   new urlDetails()
                    {
                        Srno = 2,
                        longUrl = "http://www.huffingtonpost.com/news/cnn/",
                        uniqueID = "xDepRe",
                         shortUrl= "http://localhost:50898/srt/url/xDepRe",
                        date = new DateTime(2015,7, 1),
                        
                    },
            new urlDetails()
                    {
                        Srno = 3,
                        longUrl = "http://www.huffingtonpost.com/2015/06/24/conferderate-flag-jefferson_n_7656316.html?utm_hp_ref=cnn",
                        uniqueID = "zDepRe",
                         shortUrl= "http://localhost:50898/srt/url/zDepRe",
                        date = new DateTime(2015,07, 12),
                        
                    }
           
            };
        }
    }
}