using Helper;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 5;
            int secondNumner = 3;
            Console.WriteLine("My First Calculator!");
            Console.WriteLine($"Sum {Calculate.Sum(firstNumber, secondNumner)}");
        }
    }
}
