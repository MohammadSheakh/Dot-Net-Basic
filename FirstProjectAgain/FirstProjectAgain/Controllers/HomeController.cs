using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstProjectAgain.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.test1 = "Test 1"; // support dynamic property of object
            ViewData["test2"] = "Test2"; // dynamic string index // like associative array // dictionary
            return View();
        }

        public ActionResult About()
        {
            string[] names = new string[] { "A" , "B" , "C" , "D" };
            ViewBag.Names = names;
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
/**
 * Controller to View value passing
 * 1. Viewbag
 * 
 * landing page : basic html .. 
 *  Name, Email, Contact No. 
 *  
 *  navigation page er nich e 
 *  
 *  Home, Education, Projects, Personal Info, Reference 
 *  hyperlink 
 *  
 *  Education 
 *      HSC
            Institute
            Year, Group, Result 
        SSC
            Institute
            Year, Group, Result 
    
    Projects 
        in Tabular format single border 
            Course Title Description 

    Reference 
        1. ekjon 
        2. arekjon 
 */