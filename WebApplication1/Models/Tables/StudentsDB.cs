using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Models.Entity;

namespace WebApplication1.Models.Tables
{
    public class StudentsDB
    {
        SqlConnection conn;
        public StudentsDB(SqlConnection conn)
        {
            this.conn = conn;
        }

        public void Add(StudentDBE sdb) // Entity ta ke niye ashlam
        {
            // ekhan theke start 
            // code gula amra StudentDatabaseController er Create method [HttpPost] theke niye ashsi 
            string query = String.Format("Insert into Students values ('{0}', '{1}', '{2}', 0.0)", sdb.Name, sdb.Dob, sdb.Gender, sdb.Cgpa);

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            // single word insert hoy .. name er moddhe .. double word insert hoy na 😥

            // er moddhei operation korte hobe 
            int r = cmd.ExecuteNonQuery(); // hoile 1 , na hoile 0 return korbe may be 

            conn.Close();
        }

        public StudentDB Get(int id) // single id er against e details show korbe 
        {
            return null;
            // return new StudentDB { }
        }

        public List<StudentDBE> GetAll()
        {
            // code gula amra StudentDatabaseController er Index method [GET] theke niye ashsi 

            string connString = "Server=CHILL-PC\\SQLEXPRESS;Database=UMS;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);

            // ekhan theke start 
            string query = "select * from Students";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            List<StudentDBE> Studentlist = new List<StudentDBE>(); // Create List

            while (reader.Read()) // hasRows
            {
                StudentDBE s = new StudentDBE()
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

            return Studentlist;
            // return new List<StudentDB>();
        }
    }
}