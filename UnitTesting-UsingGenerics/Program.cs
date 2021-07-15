using System;

namespace UnitTesting_UsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            GreatestNumber obj = new GreatestNumber();
            //Check greatest number among three number
            Console.WriteLine("Welcome to generics program!");
            int number1, number2, number3;
            Console.WriteLine("Enter number 1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Greatest number is {0} ", obj.LargestNumber(number1, number2, number3));

        }
    }
}
