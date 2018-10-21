using System;

namespace BusTicketLuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int luckyTickets = 0;
            int normalTickets = 0;
            for(int i=0;i<=999999;i++)
            {
                if (i/100000+(i/10000)%10+(i/1000)%10==(i/100)%10+(i/10)%10+i%10)
                {
                    Console.WriteLine(i);
                    luckyTickets++;
                }
                else
                {
                    normalTickets++;
                }
            }
            int totalTickets = luckyTickets + normalTickets;
            Console.WriteLine("The number of the lucky tickets is: {0} ", luckyTickets);
            Console.WriteLine("The number of the normal(not lucky) tickets is: {0} ", normalTickets);
            Console.WriteLine("Total tickets: {0} ", totalTickets);
        }
    }
}
