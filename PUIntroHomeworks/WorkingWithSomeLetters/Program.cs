using System;

namespace WorkingWithSomeLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random r = new Random();
            string[] letters = new string[100];
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = ((char)r.Next(1072, 1104)).ToString();
                Console.WriteLine(letters[i]);
            }
            Console.WriteLine("_________________________________________________________________________");
            Console.WriteLine("Здравейте. Имате редица от 100 случайни букви на кирилица.");
            Console.WriteLine("Въведете буквата на съответната опция която желаете да бъде изпълнена.");
            Console.WriteLine("Конзолата ще разчете въведения отговор единствено ако той е на кирилица!");
            Console.WriteLine("_________________________________________________________________________");
            Console.WriteLine("a. Да се отпечатат само широките гласни - а, е, о");
            Console.WriteLine("б. Да се отпечатат само тесните гласни - ъ, и, у");
            Console.WriteLine("в. Да се отпечатат само съставните гласни - я, ю");
            Console.WriteLine("г. Да се отпечатат само беззвучните съгласни - п, ф, к, т, ш, с, х, ц");
            Console.WriteLine("д. Да се отпечатат само сонорните съгласни - л, м, н, р");
            Console.WriteLine("е. Да се отпечатат само звучните съгласни - б, в, г, д, ж, з, ч");
            Console.WriteLine("_________________________________________________________________________");
            string ans = Console.ReadLine();
            Console.WriteLine("_________________________________________________________________________");
            if (ans=="а")
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i]=="а"||letters[i]=="е"||letters[i]=="о")
                    {
                        Console.WriteLine($"{letters[i]} е широка гласна и има индекс - {i}");
                    }
                }
            }
            if (ans=="б")
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == "ъ" || letters[i] == "и" || letters[i] == "у")
                    {
                        Console.WriteLine($"{letters[i]} е тясна гласна и има индекс - {i}");
                    }
                }
            }
            if (ans=="в")
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == "я" || letters[i] == "ю")
                    {
                        Console.WriteLine($"{letters[i]} е съставна гласна и има индекс - {i}");
                    }
                }
            }

            if (ans=="г")
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == "п" || letters[i] == "ф" || letters[i] == "к" || letters[i] == "с" || letters[i] == "т" || letters[i] == "ш" || letters[i] == "х" || letters[i] == "ц")
                    {
                        Console.WriteLine($"{letters[i]} е беззвучна съгласна и има индекс - {i}");
                    }
                }
            }

            if (ans=="д")
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == "п" || letters[i] == "л" || letters[i] == "м" || letters[i] == "н" || letters[i] == "р")
                    {
                        Console.WriteLine($"{letters[i]} е сонорна съгласна и има индекс - {i}");
                    }
                }
            }

            if (ans=="е")
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == "б" || letters[i] == "в" || letters[i] == "г" || letters[i] == "д" || letters[i] == "ж" || letters[i] == "з" || letters[i] == "ч")
                    {
                        Console.WriteLine($"{letters[i]} е звучна съгласна и има индекс - {i}");
                    }
                }
            }
            
        }
    }
}
