using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_OOPS_Programs
{

    class InheritanceBaseClass
    {
        public void BaseMethod1()
        {
            Console.WriteLine("This is Base class Method 1");
        }

        public void BaseMethod2()
        {
            Console.WriteLine("This is Base class Method 2");
        }

        public virtual void MethodOverride()
        {
            Console.WriteLine("This is Method OverRide");
        }
    }

    class InheritanceChildClass : InheritanceBaseClass
    {
        public void ChildMethod1()
        {
            Console.WriteLine("This is Child Class Method 1");
        }
        public void ChildMethod2()
        {
            Console.WriteLine("This is Child Class method 2");
        }

        public override void MethodOverride()
        {
            Console.WriteLine("This is Method OverRide");
        }
    }
}



