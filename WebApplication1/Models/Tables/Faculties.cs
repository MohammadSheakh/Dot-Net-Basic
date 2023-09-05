using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.Entity;

namespace WebApplication1.Models.Tables
{
    public class Faculties
    {
        public void Add(Faculty faculty) // Entity ta ke niye ashlam
        {

        }

        public Faculty Get(int id) // single id er against e details show korbe 
        {
            return null;
            // return new Faculty { }
        }

        public List<Faculty> GetAll()
        {
            return null;
            // return new List<Faculty>();
        }
    }
}