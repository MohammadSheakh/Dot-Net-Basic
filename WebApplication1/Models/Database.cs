using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Models.Entity;
using WebApplication1.Models.Tables;

namespace WebApplication1.Models
{
    public class Database
    {
        public StudentsDB StudentsDB { get; set; } // bujhlam na 😥
        public Courses Courses { get; set; }

        public Faculties Faculties { get; set; }

        public Database() {
            // Connection String 
            string connString = "Server=CHILL-PC\\SQLEXPRESS;Database=UMS;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            
            StudentsDB = new StudentsDB(conn); // bujhlam na 😥
            Courses = new Courses();
            Faculties = new Faculties();

        }
    }
}