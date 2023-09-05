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
                Id = "id bro",
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
            for (int i = 0; i < 10; i++)
            {
                Student student = new Student()
                {
                    Name = "Mohammad Sheakh" + (i + 1),
                    Id = "id bro",
                    Dob = "434"
                };
                students.Add(student); // prottek bar create hoye add hoye jabe 
            }
            return View(students);
        }

        /////////////////////////////////////////////////////////////////////////////////////////

        public ActionResult Create()
        {
            // ekhon amra view theke data niye ekta user create korbo 

            return View();
        }

        /////////////////////////////////////////////////////////////////////////////////////////

        //public ActionResult CreateSubmit()
        // 1st way requst

        //public ActionResult CreateSubmit(FormCollection fc)
        // 2nd way mvc framework er ekta class ei class er instance parameter e nibo 

        //public ActionResult CreateSubmit(string Name, string Id, string Dob)
        // 3rd way From Direct Variable  // int? -> this is nullable integer

        public ActionResult CreateSubmit(Student s) // constructor call houar shomoy property er default value initialize hoye jay 
        // 4th way 
        {
            //  Submit houwa Data gula amra ei page e dekhabo 

            Student student = new Student();  // 4th way te ei object create kora lagbe na 
            // student er value gula ke ami user jegula dibe .. shegula diye populate korbo 

            // form theke value receive korte pari 4 ta way te
            // 1. from HttpRequstBase -> ei class theke -> er instance hocche Request // dictionary

            /*
             *  // ei ta ekta approach 
                student.Name= Request["Name"];
                student.Id = Request["Id"];
                student.Dob = Request["Dob"];

             */

            // 2. next approach .. Form Collection Object 
            // ekhan theke receive er system hocche .. Dictionary 
            /*
            student.Name = fc["Name"];
            student.Id = fc["Id"];
            student.Dob = fc["Dob"];
            */

            // 3. From Direct Variable 

            /*
            student.Name = Name;
            student.Id = Id;
            student.Dob = Dob;
            */

            // 4. fourth way
            return View(s);  // this is for 4th way 

            //return View(student); // for 1st, 2nd and 3rd way 
        }
    }
}