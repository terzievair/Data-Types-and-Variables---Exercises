using System;


namespace _14ASCIIString
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = 0; i < n; i++)
            {
                int asciiCode =int.Parse( Console.ReadLine());
                char character = (char)asciiCode;
                result += character;
               
            }
            Console.WriteLine(result);
        }
    }
}
