using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        //public string Index()
        //{
        //    return "This is my <b>default</b> action...";
        //}

        // 
        // GET: /HelloWorld/Welcome/ 
        public ActionResult Welcome(string userid, int num = 1)
        {
            ViewBag.UserID = userid;
            ViewBag.Num = num;

            return View();
        }
        
        //public string Welcome(string userid, int num = 1)
        //{
        //    ViewBag.UserID = userid;
        //    ViewBag.Num = num;

        //    return HttpUtility.HtmlEncode("Hello " + userid + ", Num is: " + num);
        //}

    }
}