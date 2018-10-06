using System;

namespace AgeAfter10Years
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            int ageAfter10Years = age + 10;
            Console.WriteLine("After 10 years you will be:{0}",ageAfter10Years);
        }
    }
}
