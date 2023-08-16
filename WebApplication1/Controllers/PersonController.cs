using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class PersonController : Controller
    {
        // action likhbo .. 

        // static html page dekhanor jonno 
        // return type hocche ActionResult .. nam hocche List 
        public ActionResult List()
        {
            // action theke kono data view te pass korte chaile ..  
            int a = 10;
            int b = 20;
            int c = a+b;
            // ViewBag
            // ViewData
            // ViewBag // dynamic object // global object // type dynamic 

            var e = 10; // without declaring any data type amra value assign korte pari 
            dynamic d = 12;

            // ei action ta ke call korte chai .. request er through te .. url ta hobe person/list
            return View();
        }

        // aro ekta static html page banabo 
        public ActionResult Create()
        {

            return View();
        }
    }
}