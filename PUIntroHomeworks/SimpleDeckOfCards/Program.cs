using System;

namespace SimpleDeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            char club = '\u2663';
            char diamond = '\u2666';
            char spade = '\u2660';
            char heart = '\u2665';
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hello!");
            Console.WriteLine("Do you want to see a full deck of cards ?");
            Console.WriteLine("Answer with yes or no.");
            string ans = Console.ReadLine();
            while (ans!="yes")
            {
                Console.WriteLine("Hello!");
                Console.WriteLine("Do you want to see a full deck of cards ?");
                Console.WriteLine("Answer with yes or no.");
                ans = Console.ReadLine();
            }
            Console.WriteLine("A" + " " + heart + " " + "A" + " " + spade + " " + " " + "A" + " " + diamond + " " + " " + "A" + " " + club);
            Console.WriteLine("2" + " " + heart + " " + "2" + " " + spade + " " + " " + "2" + " " + diamond + " " + " " + "2" + " " + club);
            Console.WriteLine("3" + " " + heart + " " + "3" + " " + spade + " " + " " + "3" + " " + diamond + " " + " " + "3" + " " + club);
            Console.WriteLine("4" + " " + heart + " " + "4" + " " + spade + " " + " " + "4" + " " + diamond + " " + " " + "4" + " " + club);
            Console.WriteLine("5" + " " + heart + " " + "5" + " " + spade + " " + " " + "5" + " " + diamond + " " + " " + "5" + " " + club);
            Console.WriteLine("6" + " " + heart + " " + "6" + " " + spade + " " + " " + "6" + " " + diamond + " " + " " + "6" + " " + club);
            Console.WriteLine("7" + " " + heart + " " + "7" + " " + spade + " " + " " + "7" + " " + diamond + " " + " " + "7" + " " + club);
            Console.WriteLine("8" + " " + heart + " " + "8" + " " + spade + " " + " " + "8" + " " + diamond + " " + " " + "8" + " " + club);
            Console.WriteLine("9" + " " + heart + " " + "9" + " " + spade + " " + " " + "9" + " " + diamond + " " + " " + "9" + " " + club);
            Console.WriteLine("10" + " " + heart + " " + "10" + " " + spade + " " + " " + "10" + " " + diamond + " " + " " + "10" + " " + club);
            Console.WriteLine("J" + " " + heart + " " + "J" + " " + spade + " " + " " + "J" + " " + diamond + " " + " " + "J" + " " + club);
            Console.WriteLine("Q" + " " + heart + " " + "Q" + " " + spade + " " + " " + "Q" + " " + diamond + " " + " " + "Q" + " " + club);
            Console.WriteLine("K" + " " + heart + " " + "K" + " " + spade + " " + " " + "K" + " " + diamond + " " + " " + "K" + " " + club);
        }
    }
    }

