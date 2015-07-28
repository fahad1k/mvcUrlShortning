using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcUrlShortning.Models;

namespace mvcUrlShortning.Controllers
{
    public class srtController : Controller
    {

        public ActionResult Index()
        {
            List<urlDetails> lst = staticModel.urlList.OrderBy(ob => ob.Srno).ToList();
            return View(lst);
        }

        [HttpPost]
        public ActionResult Create(string longUrl)
        {
          if (!String.IsNullOrEmpty( longUrl) && longUrl.Length>8) 
            {
                urlDetails udl = staticModel.urlList.SingleOrDefault(url => url.longUrl == longUrl);
                if (udl == null)
                {
                    string uniqueID = staticModel.GenerateString(5);

                    string sUrl = Url.Action("url", "srt", new { id = uniqueID }, "http");

                    udl = new urlDetails() { Srno = staticModel.NextSerial, longUrl = longUrl, uniqueID = uniqueID, shortUrl = sUrl, date = DateTime.Now };
                    staticModel.urlList.Add(udl);
                   
                }

                List<urlDetails> lst = staticModel.urlList.OrderBy(ob => ob.Srno).ToList();
                return View("Index" ,lst);

            }


            ModelState.AddModelError("longUrl", "Url is not valid.");

          return View();

        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpGet]
          public RedirectResult url(string Id)
        {
            urlDetails udl = staticModel.urlList.SingleOrDefault(url => url.uniqueID == Id);
            if (ModelState.IsValid && udl !=null)
            {

                return Redirect(udl.longUrl);
               
            }

            return Redirect("Index");

        }

      

    }
}
