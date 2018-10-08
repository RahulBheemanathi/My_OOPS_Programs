using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_OOPS_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            One obj = new One();
            obj.add();

            Second Secondobj = new Second();
            Secondobj.Add();
            Secondobj.Min();
            Secondobj.Mutipile();
            Secondobj.Number(25, 25);
            int Sub = Secondobj.Sub();
            Console.WriteLine("Subt is " + Sub);

            GetSetProgram getSetProgram = new GetSetProgram();
            getSetProgram.Pro1 = 10;
            getSetProgram.Pro2 = 20;
            getSetProgram.Display();

            InheritanceChildClass NewChildClassObj = new InheritanceChildClass();
            NewChildClassObj.BaseMethod1();
            NewChildClassObj.BaseMethod2();
            NewChildClassObj.ChildMethod1();
            NewChildClassObj.ChildMethod2();
            NewChildClassObj.MethodOverride();


            Polymorphism NewPolyObj = new Polymorphism();
            NewPolyObj.Display(10);
            NewPolyObj.Display(236.25);
            NewPolyObj.Display("Rahul Bheemanathi");
            NewPolyObj.Display(10, 5);
            NewPolyObj.Display("Honey", "Rahul");

            Abstraction NewAbstractionObj = new Abstraction();
            NewAbstractionObj.add();

            GetSetNumbersOutPut getSetNumbers = new GetSetNumbersOutPut();
            getSetNumbers.PrentClass();
            getSetNumbers.sum(10, 10);
            getSetNumbers.sum(20, 30);

            ReverseNumberProgram reverseNumberProgram = new ReverseNumberProgram();
            reverseNumberProgram.NumberReverse();

            char[] a = new char[] { 'S', 'R', 'I', 'D', 'E', 'V', 'I' };
            ReverseCharactersPrint reverseCharactersPrint = new ReverseCharactersPrint();
            reverseCharactersPrint.ReverseCharacters(a);

            FizzBuzzProgram fizzBuzzProgram = new FizzBuzzProgram();
            fizzBuzzProgram.FizzBuzz();


            Char[] ReverseChar = new char[] { 'R', 'A', 'H', 'U', 'L' };
            ReverseWhileLoop reverseWhileLoop = new ReverseWhileLoop();
            reverseWhileLoop.SwapChar(ReverseChar);

            char[] Forward = new char[] { 'R', 'A', 'H', 'U', 'L' };
            FrowardandReverseStringProgram frowardandReverseStringProgram = new FrowardandReverseStringProgram();
            frowardandReverseStringProgram.Forwared(Forward);
            frowardandReverseStringProgram.ReversePrint(Forward);

            //ConstructorProgram Constructor = new ConstructorProgram();
            //ConstructorProgram constructorProgram = new ConstructorProgram("Rahul Bheemanathi");

            //Constructor.add();



            //InheritanceOverride
            CityChildClass cityChildClass = new CityChildClass();
            string city = cityChildClass.YourCity();
            Console.WriteLine(city);
            Console.Read();
            Console.ReadKey();

            Console.Read();
        }
    }
}
