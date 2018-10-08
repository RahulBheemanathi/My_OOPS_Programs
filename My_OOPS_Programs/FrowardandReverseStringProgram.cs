using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_OOPS_Programs
{
    class FrowardandReverseStringProgram
    {
        public void Forwared(char[] name)
        {
            Console.WriteLine("Forwarded String name Print out");

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }

        public void ReversePrint(char[] name)
        {
            Console.WriteLine("Reverse String name Print out");

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}
