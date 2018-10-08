using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_OOPS_Programs
{
    class ConstructorProgram
    {
        int a = 10, b = 10;
        private string v;

        public ConstructorProgram(string v)
        {
            this.v = v;
        }

        public ConstructorProgram()
        {
        }

        public void ConstructorMetod1()
        {
            Console.WriteLine("This is default Constructor");
        }

        public void ConstructorMethod2(string name)
        {
            Console.WriteLine("Parameter Constructor " + name);
        }


        public void add()
        {
            Console.WriteLine(a + b);
        }

    }
}

