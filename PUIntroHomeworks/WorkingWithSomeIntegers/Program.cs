using System;

namespace WorkingWithSomeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] numbers = new int[100];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(132);
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("_________________________________________________________________________");
            Console.WriteLine("Hello. You have 100 random integers from 0 to 132.");
            Console.WriteLine("Choose an option by typing in the letter of the option you desire.");
            Console.WriteLine("a. Show only the numbers with even indexes");
            Console.WriteLine("b. Show only the odd numbers with odd indexes");
            Console.WriteLine("c. Show only the numbers that are divided by 3 without a reminder");
            Console.WriteLine("d. Show only the numbers that divided by 7 have 1 as a reminder");
            Console.WriteLine("e. Show only the numbers which are in the interval between 26 and 100");
            Console.WriteLine("f. Show only the numbers which are not in the interval between 26 and 100");
            Console.WriteLine("__________________________________________________________________________");
            char ans = char.Parse(Console.ReadLine());
            switch (ans)

            {
                case 'a':
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine($"{numbers[i]} has an even index - {i}");
                        }
                    }
                    break;

                case 'b':


                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] % 2 != 0 && i % 2 != 0)
                        {
                            Console.WriteLine($"{numbers[i]} is odd and has an odd index - {i}");
                        }
                    }
                    break;

                case 'c':

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] % 3 == 0)
                        {
                            Console.WriteLine($"{numbers[i]} is divided by 3 without a reminder");
                        }
                    }
                    break;
                case 'd':
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] % 7 == 1)
                        {
                            Console.WriteLine($"{numbers[i]} has a reminder 1 when divided by 7");
                        }
                    }
                    break;

                case 'e':
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] >= 26 && numbers[i] <= 100)
                        {
                            Console.WriteLine($"{numbers[i]} is in the interval between 26 and 100");
                        }
                    }
                    break;

                case 'f':
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] <= 26 || numbers[i] >= 100)
                        {
                            Console.WriteLine($"{numbers[i]} is not between 26 and 100");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("The value you have entered is not valid!");
                    break;
            }
        }

        }
    }

