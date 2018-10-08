using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_OOPS_Programs
{
    class Polymorphism
    {
        public void Display(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }
        public void Display(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }
        public void Display(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
        public void Display(int a, int b)
        {
            Console.WriteLine("Printing two numbers Mulitpile " + (a * b));
        }
        public void Display(string a, string b)
        {
            Console.WriteLine("Printing Two String Name " + (a + b));
        }
    }
}
