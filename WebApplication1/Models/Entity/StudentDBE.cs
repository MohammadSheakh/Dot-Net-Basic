using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Entity
{
    public class StudentDBE
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required Field* which is final")]
        [MinLength(2, ErrorMessage = "Min Length is 2*")]
        [MaxLength(10, ErrorMessage = "Max Length is 10*")]
        public string Name { get; set; }
        public string Dob { get; set; }
        public string Gender{ get; set; }
        public float Cgpa { get; set; }
    }
}
// [MinLength(2)]
// [MaxLength(10)]