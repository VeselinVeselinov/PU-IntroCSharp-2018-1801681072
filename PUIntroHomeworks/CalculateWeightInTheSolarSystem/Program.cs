using System;

namespace CalculateWeightInTheSolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you weight in kilograms:");
            int Weight = int.Parse(Console.ReadLine());
            Console.WriteLine("___________________________________________");
            Console.WriteLine("Pick the number of the planet you desire:");
            Console.WriteLine("1.Mercury");
            Console.WriteLine("2.Venus");
            Console.WriteLine("3.Earth");
            Console.WriteLine("4.Mars");
            Console.WriteLine("5.Jupiter");
            Console.WriteLine("6.Saturn");
            Console.WriteLine("7.Uranus");
            Console.WriteLine("8.Neptune");
            Console.WriteLine("___________________________________________");
            int Numb = int.Parse(Console.ReadLine());
            double WeightMercury = Weight * 0.38;
            double WeightVenus =Weight*0.91;
            double WeightEarth = Weight*1.00;
            double WeightMars = Weight*0.38;
            double WeightJupiter = Weight*2.34;
            double WeightSaturn = Weight*1.06;
            double WeightUranus = Weight*0.92;
            double WeightNeptune = Weight*1.19;
            if (Numb==1)
            {
                Console.WriteLine("You weigh approximately {0}", WeightMercury+ " kilos on Mercury.");
            }
            if (Numb == 2)
            {
                Console.WriteLine("You weigh approximately {0}", WeightVenus + " kilos on Venus.");
            }
            if (Numb == 3)
            {
                Console.WriteLine("You weigh approximately {0}", WeightEarth + " kilos on Earth.");
            }
            if (Numb == 4)
            {
                Console.WriteLine("You weigh approximately {0}", WeightMars + " kilos on Mars.");
            }
            if (Numb == 5)
            {
                Console.WriteLine("You weigh approximately {0}", WeightJupiter + " kilos on Jupiter.");
            }
            if (Numb == 6)
            {
                Console.WriteLine("You weigh approximately {0}", WeightSaturn + " kilos on Saturn.");
            }
            if (Numb == 7)
            {
                Console.WriteLine("You weigh approximately {0}", WeightUranus + " kilos on Uranus.");
            }
            if (Numb == 8)
            {
                Console.WriteLine("You weigh approximately {0}", WeightNeptune + " kilos on Neptune.");
            }

        }
    }
}
