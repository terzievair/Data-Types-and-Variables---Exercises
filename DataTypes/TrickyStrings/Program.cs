using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimeter = (Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
                result += word + delimeter;

            }

            string removeLastChar = result.Remove(result.Length - delimeter.Length, delimeter.Length);
            Console.WriteLine($"{removeLastChar}");

        }
    }
}
