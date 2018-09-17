using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMathDLL;

namespace LotteriApp
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine(MyMath.Add(2, 4));

            Console.WriteLine(MyMath.Divide(5,8));

            Console.WriteLine(MyMath.Multiply(5, 2));
            Console.WriteLine(MyMath.Subtract(4, 6));

               
            

            

            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
