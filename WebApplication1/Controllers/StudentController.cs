using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using WebApplication1.Models; // ei namespace ta na use korle amra Class ta access korte parbo na

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student // Action er nam dilam list 
        public ActionResult Index()
        {
            // List Action er baire kintu viewbag er value thakbe na 
            ViewBag.Name = "Tanvir Ahmed";
            string[] names = new string[3];
            names[0] = "Mohammad";
            names[1] = "Sheakh";
            names[2] = "Awsome";

            ViewBag.Names = names; // viewbag ekta global object // acess from anywhere // 
            // dynamic type 

            // Action and view er name same rakhte hobe

            // Models theke Student Class ke access korbo ekhon amra ekhane 
            // Student student = new Student(); // onno vabe korbo 
            Student student = new Student() // amra evabeo object create korte pari 
            {
                Name = "Mohammad Sheakh",
                Id = 1,
                Dob = "434"
            }; // instance create korlam 
            // ekhon amra viewbag er moddhe value pass na kore compact way tei object ta ke pass korbo 
            // View te ei object ta niye kaj korbo 


            return View(student); // instace ta view te pass kore dilam 
            // one view associated with a single object 
            // ekta type er shathei view ta associate hote parbe 
            // and View er moddhe upore amake define korte hobe rajor diye 
            // je amar ei view ta kon model er shathe ba kon class er shathe bind hoye thakbe
        }


        /////////////////////////////////////////////////////////////////////////////////////////
        
        public ActionResult List()
        {
            // amra list of student nibo .. sheta view te pathabo 
            List<Student> students = new List<Student>();
            // for loop use kore list er moddhe value assign korbo 
            for (int i = 0; i< 10; i++) 
            {
                Student student = new Student() 
                {
                    Name = "Mohammad Sheakh" + ( i + 1 ),
                    Id = 1,
                    Dob = "434"
                };
                students.Add(student); // prottek bar create hoye add hoye jabe 
            }
            return View(students);
        }
    }
}