using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_OOPS_Programs
{
    class GetSetProgram
    {
        int _a, _b;

        public int Pro1
        {
            set { _a = value; }
            get { return _a; }
        }
        public int Pro2
        {
            set { _b = value; }
            get { return _b; }
        }
        public void Display()
        {
            Console.WriteLine(_a + _b);
        }
    }
}
