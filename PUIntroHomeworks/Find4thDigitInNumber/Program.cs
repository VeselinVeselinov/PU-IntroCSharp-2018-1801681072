using System;

namespace Find4thDigitInNumber
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter a number with 7 digits:");
                int number = int.Parse(Console.ReadLine());

                if(number<1000000 || number>9999999)
            {

                Console.WriteLine("The number you have entered does not have 7 digits!");

            }
            else
            {
                int FourghtDigit = number % 1000000 % 100000 % 10000 / 1000;
                Console.WriteLine("The 4th digit of the number is: {0} ", FourghtDigit);
            }
        }
    }
}
