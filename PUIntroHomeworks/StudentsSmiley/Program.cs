using System;
using System.IO;
using System.Threading;

namespace StudentsSmiley
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int totalsmileys = 0;
            string[] students = File.ReadAllLines(@"C:\Users\Acer\Desktop\WorkTime\PU-IntroCSharp-2018-1801681072\PUIntroHomeworks\StudentsSmiley\Files\students.txt");
            foreach (string line in students)
            {
                string[] elements = line.Split(' ');
                string FirstName = elements[1];
                int SumFirstName=SumUp(FirstName);
                string SurName = elements[2];
                int SumSurName = SumUp(SurName);
                string LastName = elements[3];
                int SumLastName = SumUp(LastName);
                string name = $"{elements[1]+" "+ elements[2]+ " " +elements[3] }";
                if (SumFirstName+SumSurName+SumLastName>15000)
                {

                    totalsmileys++;
                    //Console.Write(SumFirstName + SumSurName + SumLastName);
                    Console.WriteLine("-------->"+" _|"+FirstName+" "+SurName+" "+LastName+"|_ "+(char)9786);
                    
                }
                else
                {

                    Console.WriteLine("-------->" + " _|" + FirstName + " " + SurName + " " + LastName + "|_"+"не получава усмивка. :(");
                    
                }
                
            }

            Console.WriteLine(" ");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("Върху конзолата се принтират имената на колегите от СТД и тези чиято сума е по-голяма от 15000 получават усмивка.");
            Console.WriteLine("Общият брой на хората, които получават усмивка:"+" "+totalsmileys);
            Console.WriteLine("-----------------------------------------------------------------------------------------");
        }
        static int SumUp(string name)
            {
            
            int sum = 0;
            Console.Write("Зарежда");
            for (int i = 0; i < name.Length; i++)
            {
                sum += (int)name[i];
                Thread.Sleep(6);
                Console.Write(".");
                
            }
            return sum;

            }
    }
}
