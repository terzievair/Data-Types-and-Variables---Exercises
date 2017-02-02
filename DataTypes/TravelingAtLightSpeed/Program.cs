using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingAtLightSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lightYears = decimal.Parse(Console.ReadLine());
            decimal kilometers = lightYears * 9450000000000;
            decimal speedOfLight = 300000;
            decimal timeInSeconds = kilometers / speedOfLight;
            decimal timeInMinutes = timeInSeconds / 60;
            timeInSeconds %= 60;
            decimal timeInHours = timeInMinutes / 60;
            timeInMinutes %= 60;
            decimal timeInDays = timeInHours / 24;
            timeInHours %= 24;
            decimal timeInWeeks = timeInDays / 7;
            timeInDays %= 7;

            Console.WriteLine("{0} weeks", (int)timeInWeeks);
            Console.WriteLine("{0} days", (int)timeInDays);
            Console.WriteLine("{0} hours", (int)timeInHours);
            Console.WriteLine("{0} minutes", (int)timeInMinutes);
            Console.WriteLine("{0} seconds", (int)timeInSeconds);


        }
    }
}
