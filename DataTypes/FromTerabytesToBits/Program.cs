using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromTerabytesToBits
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            var bits = n * 8796093022208;
            
            Console.WriteLine(bits);
        }
    }
}
