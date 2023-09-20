using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
    internal class FileInfoAgain : Ifile, Ibinary
    {
        void Ibinary.isBinary()
        {
            Console.WriteLine("This is banary");
        }
        public void NextFile()
        {
            Console.WriteLine("next file");
        }
        void Ifile.ReadFile()
        {
            Console.WriteLine("this is read ");
        }

        void Ifile.WriteFile()
        {
            Console.WriteLine("write file");
        }

    }
}
