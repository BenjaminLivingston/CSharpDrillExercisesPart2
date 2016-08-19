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
            Console.WriteLine("separate namespace called public resources that will return sample");
            Console.WriteLine("text for printing or other uses.  Here is the example text:\n\n");

            string printExample = exRsrc.publicExample();
            Console.WriteLine(printExample);

            // Clear console in between examples
            outRsrc.clrScreen();



            // Demonstration of protected accesor
            Console.WriteLine("\nProtected resources can only be used by the containing type.");
            Console.WriteLine("This namespace has a class called rectangle that takes variables");
            Console.WriteLine("for the length and width.  The rectangle has a protected method");
            Console.WriteLine("called area which will return the area of the rectangle.");
            Console.WriteLine("Only the rectangle class can access this method, so in this context");
            Console.WriteLine("The area cannot be returned.");

            rectangle rect = new rectangle(3.0, 7.0);
            Console.WriteLine("\n\nAn example rectangle has the length of {0} and width of {1}.", rect.length, rect.width);
            //Console.WriteLine("has the area of " + rect.rectArea());
            Console.WriteLine("The area cannot be returned of this rectangle without error");
            Console.WriteLine("due to the area method being protected.");

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
            Console.WriteLine("\nExternal resources contains a private integer variable named private example.");
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


            // Protected Internal
            Console.WriteLine("\nProtected Internal resources are protected or internal meaning that the");
            Console.WriteLine("it can be accessed from within the container or from within this namespace.");
            Console.WriteLine("A duplicate of the rectangle area method has been created here that is");
            Console.WriteLine("protected internal and now we can print the area of the rectangle created");
            Console.WriteLine("earlier.");

            Console.WriteLine("\nThe area of the rectangle created earlier is " + rect.accessArea());

            // Clear console in between examples
            outRsrc.clrScreen();



            // Sealed Class
            Console.WriteLine("\nA sealed class or method will not allow derivatives.  This means");
            Console.WriteLine("a child cannot be created.  A sealed triangle class has been created.");
            Console.WriteLine("It would create an error if a derived equlateral triangle class is");
            Console.WriteLine("attempted to be created.  It has therefore been commented out.");

            triangle tri = new triangle(4.0, 5.1);
            Console.WriteLine("\n\nAn example triangle has the base of {0} and height of {1}.", tri.triBase, tri.triHeight);

            // Clear console in between examples
            outRsrc.clrScreen();
        }
    }



    // Rectangle Class
    public class rectangle
    {
        public double length { get; set; }
        public double width { get; set; }
        

        public rectangle(double lngth, double wdth)
        {
            length = lngth;
            width = wdth;
        }

        protected double rectArea()
        {
            return length * width;
        }

        protected internal double accessArea()
        {
            return length * width;
        }
    }


    sealed class triangle
    {
        public double triBase {get;set;}
        public double triHeight { get; set; }

        public triangle(double x, double y)
        {
            triBase = x;
            triHeight = y;
        }
    }

    // This would produce an error and is commented out to prevent the error:
    //class equilateralTriangle : triangle{ }


}
