using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_OOPS_Programs
{
    class ReverseWhileLoop
    {
        
        public void SwapChar(char[] name)
        {
            Console.WriteLine("Swap the characters using while loop");
            int i = 0;

            int j = name.Length-1;

            while (i < j)
            {
                char temp = name[i];
                name[i] = name[j];
                name[j] = temp;
                i++;
                j--;


            }
            Console.WriteLine(name);
       

        }
    }
}
