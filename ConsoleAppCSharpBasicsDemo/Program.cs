using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharpBasicsDemo
{
    class Program
    {
        /// <summary>
        /// This is an XML method header
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Comment
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            //Data Types Demos
            int myNum = 100000;
            Console.WriteLine(myNum);

            long myNum2 = 15000000000L;
            Console.WriteLine(myNum2);

            float myNum3 = 5.75F;
            Console.WriteLine(myNum3);

            double myNum4 = 19.99D;
            Console.WriteLine(myNum4);

            bool isCSharpFun = true;
            bool isGuacamoleGood = false;
            Console.WriteLine(isCSharpFun);   
            Console.WriteLine(isGuacamoleGood);

            char myGrade = 'A';
            Console.WriteLine(myGrade);

            string greeting = "Hello there!";
            Console.WriteLine(greeting);

            //Instantiate the Car class
            Car hondaCivic = new Car();
            hondaCivic.Color = "grey";
            hondaCivic.Honk();
            Console.ReadKey();

            Console.WriteLine($"WeirdReturn returns the following value for x.MyValue: {WeirdReturn().ToString()}.");
            Console.ReadKey();
        }

        //Method to demo pointing to the same space in memory
        private static int WeirdReturn()
        {
            //This will return "4" for x.MyValue even though we set it to "3", since x and y reference the same memory location
            MyInt x = new MyInt();
            x.MyValue = 3;          //Set x's MyValue to 3
            MyInt y = new MyInt();
            y = x;
            y.MyValue = 4;          //Set y's MyValue to 4
            return x.MyValue;
        }

        
    }
}
