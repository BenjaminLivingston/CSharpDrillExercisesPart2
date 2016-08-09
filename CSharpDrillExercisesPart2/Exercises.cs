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
            Exercises ex = new Exercises();
            OutsideResources outRsrc = new OutsideResources();
            PublicResources.ExternalResources exRsrc = new PublicResources.ExternalResources();


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
            Console.WriteLine("\nA public method was created in the external resources class in a");
            Console.WriteLine("separate namespace called public resources taht will return sample");
            Console.WriteLine("text for printing or other uses.  Here is the example text:\n\n");

            string printExample = exRsrc.publicExample();
            Console.WriteLine(printExample);

            // Clear console in between examples
            outRsrc.clrScreen();



            // Demonstration of internal accesor
            Console.WriteLine("\nExternal resources also has an internal integer variable named");
            Console.WriteLine("internalExample.  If the code tries to print the value of the");
            Console.WriteLine("variable without referring to the external namespace, it will");
            Console.WriteLine("have an error.");
            //Console.WriteLine(internalExample);

            Console.WriteLine("\nHowever, I can use a copy of the internalExample within this namepsace");
            Console.WriteLine("or access the external namespace to access its members:");
            Console.WriteLine("\nIn this namespace the internalExample is equal to {0}",outRsrc.internalExample);
            Console.WriteLine("\nIn the external namespace internalExample is equal to {0}", exRsrc.internalExample);

            // Clear console in between examples
            outRsrc.clrScreen();



            // Demonstration of private accesor
            Console.WriteLine("\nExternal resources a private integer variable named private example.");
            Console.WriteLine("Private example cannot be accessed from this namespace. Attempting to will");
            Console.WriteLine("create an error.");
            //Console.WriteLine("\nIn the external namespace privateExample is equal to {0}", exRsrc.privateExample);
            Console.WriteLine("\nA method can be created in the other namespace that accesses the");
            Console.WriteLine("privateExample.  It is called access private example.  Using this");
            Console.WriteLine("we can access the private example.");

            int integer2 = exRsrc.accessPrivateExample();
            Console.WriteLine("\nIn the external namespace privateExample is equal to {0}", integer2);

            // Clear console in between examples
            outRsrc.clrScreen();

        }
    }
}
