using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.Entity;

namespace WebApplication1.Models.Tables
{
    public class Courses
    {
        public void Add(Course course) // Entity ta ke niye ashlam
        {

        }

        public Course Get(int id) // single id er against e details show korbe 
        {
            return null;
            // return new Course { }
        }

        public List<Course> GetAll()
        {
            return null;
            // return new List<Course>();
        }
    }
}