using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Student
    {
        [Required]
        public string Name { get; set; } // property 
        public string Id { get; set; } // property 2 type -> auto property , full property 

        public float? Cgpa { get; set; }
        // better practice nullable use kora int float double er jonno 
        // auto property example 
        public string Dob { get; set; }

        // full property example 
        private int myVar; // ekta field variable nilam 
        // and oi tar against e alada kore property declare korlam 
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public string name; // field variable // etar upor ar kono rule impose korte parbo na

        // auto property and field er moddhe difference ta ki ? 
        public string Dob1 { get;  } // eta baire theke set kora jabe na 
        public string Dob2 { get; private set; } // vitor e set kora jabe .. baire theke  set
        // kora jabe na 
        public string Dob3 { get; protected set; } // within the class access korte parbo 
        // othoba sub class gula te access korte parbo // baire theke set korte parbo na 
        // shudhu get korte parbo 
    }
}