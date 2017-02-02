using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int overFlowed = n / 256;


            if (overFlowed == 0)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine(n % 256);
                Console.WriteLine("Overflowed {0} times", overFlowed);
            }
        }
    }
}
