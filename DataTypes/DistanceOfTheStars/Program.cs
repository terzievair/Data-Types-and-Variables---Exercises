using System;
////•	The distance to the center of our galaxy – the Milky Way: ~26 000 ly
//•	The diameter of the Milky Way: ~100 000 ly
//•	The distance from Earth to the edge of the observable universe: ~46 500 000 000 ly
//Write a program to calculate the aforementioned distances in kilometers.
//Print the result using scientific notation with 2 points decimal precision
//Assume that 1 light year == 9 450 000 000 000 km.
//Examples
//Input   Output
//(no input)  3.99e+013
//2.46e+017
//9.45e+017
//4.40e+023
//Hints
//•	Use the decimal data type for the calculations

namespace DistanceOfTheStars
{
    class Program
    {
        static void Main()
        {
           double earthToTheNearestStar = 4.22;
           ushort distanceMilkyWay= 26000;
            int diameterMilkyWay = 100000;
           decimal distanceEarthUniverse = 46500000000;
            var lightYearInKM = 9450000000000;
            Console.WriteLine("{0:e2}", earthToTheNearestStar*lightYearInKM);
            Console.WriteLine("{0:e2}", distanceMilkyWay*lightYearInKM);
            Console.WriteLine("{0:e2}", diameterMilkyWay*lightYearInKM);
            Console.WriteLine("{0:e2}", distanceEarthUniverse *(decimal) lightYearInKM);
        }
    }
}
