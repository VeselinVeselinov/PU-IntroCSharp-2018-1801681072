using System;

namespace DecartCoordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do some calculations!");
            Console.WriteLine("Enter Xa: ");
            double Xa = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Xb: ");
            double Xb = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ya: ");
            double Ya = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Yb ");
            double Yb = double.Parse(Console.ReadLine());
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine("These points have the current coordinates of:");
            Console.WriteLine("Point A: ({0}", Xa +", "+ Xb + ")");
            Console.WriteLine("Point B: ({0}", Ya + ", " + Yb + ")");
            Console.WriteLine("_____________________________________________________");
            double distance = Math.Sqrt((Ya-Xa)* (Ya - Xa) + (Yb - Xb) * (Yb - Xb));
            Console.WriteLine("The distance between the two points is: {0}", distance);

        }
    }
}
