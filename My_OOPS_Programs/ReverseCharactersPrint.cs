using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_OOPS_Programs
{
    class ReverseCharactersPrint
    {
        int x;
        public void ReverseCharacters(char[] name)
        {
            Console.WriteLine("Reverse Characters Printing");
            for (int x = name.Length - 1; x >= 0; x--)
            //for (int i=0; i<name.Length; i++)
            {
                Console.WriteLine(name[x]);
            }
        }
    }
}
