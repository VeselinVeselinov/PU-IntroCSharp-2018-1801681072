using System;

namespace MiserPiggy
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumPiggieName1 = 0;
            int sumPiggieName2 = 0;
            int sumPiggieName3 = 0;
            Console.WriteLine("Hello, piggies.");
            Console.WriteLine("Please enter your names.");
            Console.WriteLine("Piggie 1:");
            string pigName1 = Console.ReadLine();
            Console.WriteLine("Piggie 2:");
            string pigName2 = Console.ReadLine();
            Console.WriteLine("Piggie3:");
            string pigName3 = Console.ReadLine();
            foreach (var ch in pigName1)
            {
                sumPiggieName1 += (int)ch;
            }
            foreach (var ch in pigName2)
            {
                sumPiggieName2 += (int)ch;
            }
            foreach (var ch in pigName3)
            {
                sumPiggieName3 += (int)ch;
            }
            if (sumPiggieName1>sumPiggieName2&&sumPiggieName1>sumPiggieName3)
            {
                if (sumPiggieName2>sumPiggieName3)
                {
                    Console.WriteLine("The pig with the wealthiest name is {0} ", pigName1 +" followed by "+pigName2+" and "+pigName3);
                }
                else
                {
                    Console.WriteLine("The pig with the wealthiest name is {0} ", pigName1 + " followed by " + pigName3 + " and " + pigName2);
                }

            }
            else if (sumPiggieName2>sumPiggieName3&&sumPiggieName2>sumPiggieName1)
            {
                if (sumPiggieName1>sumPiggieName3)
                {
                    Console.WriteLine("The pig with the wealthiest name is {0} ", pigName2 + " followed by " + pigName1 + " and " + pigName3);
                }
                else
                {
                    Console.WriteLine("The pig with the wealthiest name is {0} ", pigName2 + " followed by " + pigName3 + " and " + pigName1);
                }

            }
            else if (sumPiggieName3>sumPiggieName2&&sumPiggieName3>sumPiggieName1)
            {
                if (sumPiggieName1>sumPiggieName2)
                {
                    Console.WriteLine("The pig with the wealthiest name is {0} ", pigName3 + " followed by " + pigName1 + " and " + pigName2);
                }
                else
                {
                    Console.WriteLine("The pig with the wealthiest name is {0} ", pigName3 + " followed by " + pigName2 + " and " + pigName1);
                }
            }
        }
    }
}
