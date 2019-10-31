using System;
using PrimeNumbers;

namespace Open_Lab_03._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int number = Convert.ToInt32(Console.ReadLine());

            Numbers numbers = new Numbers();
            bool result = numbers.IsPrimeNumber(number);

            Console.WriteLine($"{result}");
        }
    }
}
