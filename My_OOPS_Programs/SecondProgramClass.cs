using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_OOPS_Programs
{
    class SecondProgramClass
    {
    }
}

class Second
{
    int a = 10, b = 10;
    public void Add()
    {
        Console.WriteLine("addition is " + (a + b));
    }

    int c = 12, d = 10;
    public void Min()
    {
        Console.WriteLine("Mins Value is " + (c - d));
    }

    int e = 10, f = 10;
    public void Mutipile()
    {
        Console.WriteLine("mutipile number is " + (e * f));
    }

    public void Number(int i, int j)
    {
        Console.WriteLine("Number adding is " + (i + j));

    }

    public int Sub()
    {
        return a - b;
    }

}