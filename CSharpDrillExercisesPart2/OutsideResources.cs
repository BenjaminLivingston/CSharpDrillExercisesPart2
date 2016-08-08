using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDrillExercisesPart2
{
    public class OutsideResources
    {
        // Code being reused for utility purposes
        public void clrScreen()
        {
            Console.WriteLine("\n\nPress any key to continue . . .");
            Console.ReadLine();
            Console.Clear();
            return;
        }


        public string publicExample()
        {
            string rtrnText = "This is an example string that is returned from a public resource.";
            return rtrnText;
        }


    }
}
