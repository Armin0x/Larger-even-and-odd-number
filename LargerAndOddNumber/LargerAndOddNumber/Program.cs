using System;

namespace LargerAndOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first number and press Enter: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number and press Enter: ");
            int num2 = int.Parse(Console.ReadLine());

            int largerNumber;
            if (num1 > num2)
            {
                largerNumber = num1;
                Console.WriteLine("The first number is larger");
            }
            else if (num2 > num1)
            {
                largerNumber = num2;
                Console.WriteLine("The second number is larger");
            }
            else
            {
                largerNumber = num1;
                Console.WriteLine("The numbers are equal");
            }

     
            if (largerNumber != 0)
            {
                if (largerNumber % 2 == 0)
                {
                    Console.WriteLine("The Number is Even");
                }
                else if (largerNumber % 2 != 0)
                {
                    Console.WriteLine("The Number is Odd");
                }
            }
                       Console.ReadLine();

        }
    }
}
