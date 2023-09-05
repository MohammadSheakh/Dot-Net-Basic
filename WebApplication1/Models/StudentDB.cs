using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class StudentDB
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Dob { get; set; }
        public string Gender{ get; set; }
        public float Cgpa { get; set; }
    }
}