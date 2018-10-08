using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_OOPS_Programs
{
    class Abstraction
    {
        private int a = 10, b = 10, c = 20;
        void Mutipile()
        {
            Console.WriteLine("Mutipile two numbers " + (a * b));
        }

        void get()
        {
            Console.WriteLine("Welcome to my Abstraction Application");
        }

        void dobuleplus()
        {
            Console.WriteLine("This Double plus " + (a * b + c));
        }

        public void add()
        {
            get();
            Mutipile();
            dobuleplus();
            Console.WriteLine("adding Two numbers " + (a + b));
        }
    }
}
