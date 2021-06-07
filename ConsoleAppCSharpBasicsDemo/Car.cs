using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharpBasicsDemo
{
    internal class Car
    {
        //Note the use of encapsulation here
        public string Color { get; set; }
        public string DontDoThis;

        public void Honk()
        {
            Console.WriteLine("Beep! Beep!");
        }      

    }
}
