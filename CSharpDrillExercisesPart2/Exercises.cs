using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDrillExercisesPart2
{
    class Exercises
    {



        static void Main(string[] args)
        {

            OutsideResources outRsrc = new OutsideResources();


            // Public, protected, internal, private, protected internal
            Console.WriteLine("\nCode assembly references all of the code within this namespace.");
            Console.WriteLine("This code is written in the Exercises class within the CSharpDrillExercises2");
            Console.WriteLine("namespace.");
            Console.WriteLine("\n\tClasses, Methods, or variables created with Public can be");
            Console.WriteLine("\taccessed outside this namespace.");
            Console.WriteLine("\n\tProtected allows only the class and its derived children");
            Console.WriteLine("\tto use it.");
            Console.WriteLine("\n\tInternal allows only being used within this namespace assembly.");
            Console.WriteLine("\n\tPrivate will only allow the item to be used within the container");
            Console.WriteLine("\tit is in.");
            Console.WriteLine("\n\tProtected Internal means protected OR internal and allows being");
            Console.WriteLine("\tused in the namespace assembly or within a derived class.");
            Console.WriteLine("\n\nOn the following screens each of these types will be demonstrated.");


            // Clear console in between examples
            outRsrc.clrScreen();


            // Demonstration of public accessor
            Console.WriteLine("\nA public method was created in the outside resources class that will");
            Console.WriteLine("return sample text for printing or other uses.  Here is the example text:\n\n");

            string printExample = outRsrc.publicExample();
            Console.WriteLine(printExample);


            // Clear console in between examples
            outRsrc.clrScreen();


            // Demonstration of internal accesor

        }
    }
}
