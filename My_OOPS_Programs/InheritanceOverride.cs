using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_OOPS_Programs
{
    class InheritanceOverride
    {
    }
}
class CityBaseClass
    {
        public virtual string YourCity()
        {
            return "New York";
        }
    }

    class CityChildClass : CityBaseClass
    {
        public override string YourCity()
        {
            return "London";
        }
    }

    