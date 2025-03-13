using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.CodeCamp
{
    public class CreateAndRunSimpleCsharpConsoleApplications
    {
        public class CallMethodsFromTheDotNETClassLibraryUsingCsharp
        {
            public void ThirdPart()
            {
                Random dice = new Random();
                int roll = dice.Next(1, 7);
                Console.WriteLine(roll);
            }
            public void FifthPart()
            {
                int firstValue = 500;
                int secondValue = 600;
                int largerValue = Math.Max(firstValue, secondValue);



                Console.WriteLine(largerValue);
            }
        }
    }
}
