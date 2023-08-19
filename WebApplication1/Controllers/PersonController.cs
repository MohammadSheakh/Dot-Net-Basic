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
            // view and controller e viewbag ta accessable 



            // initialization kore dite hobe 
            var e = 10; // without declaring any data type amra value assign korte pari 
            // guess based assignment .. 10 er type jeita .. e er type o sheita hoye jabe ..
            // value er upor base kore data type define kori 
            dynamic d = 12; // dynamic er moddhe jekono data type er value rakha jabe ... 
            // d.hello = "hello"; //🔴😥 runtime e error dibe 

            ViewBag.a = a; // variable a ke assign kore dilam viewbag er a er moddhe 
            ViewBag.b = b;
            ViewBag.c = c; // a,b,c property kintu kothao define kora nai 
            // view te giye kintu amra eta easily access korte parbo 

            /// List() er request er moddhei ei value access kora jabe .. Create() er moddhe
            /// access kora jabe na ..
            /// ❤ eta shudhu action theke view porjonto data niye ashbe 

            // viewbag er moddhe c sharp er object o rakha jabe .. 
            string[] names = new string[3];
            names[0] = "Tanvir";
            names[1] = "OPU";
            names[2] = "name 3";
            
            // viewbag er moddhe array ta niye jabo 

            ViewBag.NamesArray = names;

            // ViewBag er moto .. arekta hocche ViewData[""] // key value pair // dictionary 
            ViewData["A"] = a; // a variable ta rekhe dilam ViewData er moddhe



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