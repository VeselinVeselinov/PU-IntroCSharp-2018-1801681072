using System;

namespace TravelingToTheSunWithSoundSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            const double SoundSpeed = 1235;
            const double DistanceEarthSun= 149600000;
            double TimeInHours = Math.Round(DistanceEarthSun / SoundSpeed);
            double TimeInYears = Math.Floor(TimeInHours / 8770);
            double Days = Math.Floor(((TimeInHours / 8770) - TimeInYears) * 365);
            Console.WriteLine("The time it takes to go from the Earth to the Sun with the speed of sound is: {0} "
               , Math.Floor(TimeInHours) + " hours or " + TimeInYears + " years and " + Days + " days. " ); 
        }
    }
}
