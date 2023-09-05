using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Entity;
using System.Data.SqlClient;
using System.Security.Cryptography;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentDatabaseController : Controller
    {
        // GET: StudentDatabase
        public ActionResult Index()
        {
            // view all data // Read // Retrieve
            // ei duita line o Database.cs class e ase .. so, likha lagbe na 
            //string connString = "Server=CHILL-PC\\SQLEXPRESS;Database=UMS;Integrated Security=true;";
            //SqlConnection conn = new SqlConnection(connString);

            /*
            string query = "select * from Students";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            List<StudentDB> Studentlist = new List<StudentDB>(); // Create List

            while (reader.Read()) // hasRows
            {
                StudentDB s = new StudentDB()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Dob = reader.GetString(reader.GetOrdinal("Dob")),
                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                    //Cgpa = (float) reader.GetDouble(reader.GetOrdinal("Cgpa")) // 😥😥 Problem kortese 
                    
                };

                Studentlist.Add(s);

                //reader.GetString(reader.GetOrdinal("Id")); // 😥 bujhi nai 
            }
            conn.Close();
            */
            /**
             *  ei full code ekhon amra Models -> tables -> StudentsDB file er GetAll method e  niye jabo 
             */
            /*
            return View(Studentlist); // jei List ta create korsi 
            */
            // sheta pass kore dilam 

            Database db = new Database();
            var students = db.StudentsDB.GetAll();

            return View(students);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentDBE sdb) //Entity folder er vitor er ta mean kortese na
        {
            // string connString = "Server=CHILL-PC\\SQLEXPRESS;Database=UMS;User Id=sa;Password=123456"; // may be string er age @ dileo hobe .. abar \\ use korleo hobe 
            string connString = "Server=CHILL-PC\\SQLEXPRESS;Database=UMS;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);

            /*
             // this is the default process  
             
            string query = String.Format("Insert into Students values ('{0}', '{1}', '{2}', 0.0)", sdb.Name, sdb.Dob, sdb.Gender, sdb.Cgpa);

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            // er moddhei operation korte hobe 
            int r = cmd.ExecuteNonQuery(); // hoile 1 , na hoile 0 return korbe may be 

            conn.Close();

            // ei tuku code ekhon amra Models -> tables -> StudentsDB file er Add method e  niye jabo 
            */

            // Validation niye kaj kortesi ekhane 
            
            if (ModelState.IsValid){

                Database db = new Database();
                db.StudentsDB.Add(sdb);
                return RedirectToAction("Index"); // Index page e redirect korbe 

            }
            return View(); // etar mane hocche Create page e show korbe .. 

            ///Database db = new Database();
            ///db.StudentsDB.Add(sdb);
            //var students = db.StudentsDB.GetAll();



            //return View();
            ///return RedirectToAction("Index"); // bujhlam na 😥
        }
    }
}