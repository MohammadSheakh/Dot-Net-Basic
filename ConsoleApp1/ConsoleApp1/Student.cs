using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student()
        {
            // this is constructor ..  
        }

        public int Sum(int num1, int num2)
        {
            var total  = num1 + num2;
            return total;
        }

        public void Greet()
        {
            Console.WriteLine("Whats up good people ! from "+this.FirstName+ this.LastName);
        }
    }
}
