using System;

namespace MyUniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the last 4 digits of your faculty number here:");
            int facNumber = int.Parse(Console.ReadLine());
            int ageAfter10Years = age + 10;
            double uniqueNumber = (ageAfter10Years * facNumber) / Math.PI;
            //Console.WriteLine(uniqueNumber);
            Console.WriteLine("After 10 years you will be {0}", ageAfter10Years + " and your unique number is " + uniqueNumber);
        }
    }
}
