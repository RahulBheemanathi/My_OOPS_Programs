using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_OOPS_Programs
{
    class ReverseNumberProgram
    {
        public void NumberReverse()
        {
            int[] a = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Reverse Number");
            for (int i = a.Length - 1; i >= 0; i--)
            //for (int i = 0; i < a.Length; i++)
            {
                
                Console.WriteLine(a[i]);
            }
        }
    }
}
