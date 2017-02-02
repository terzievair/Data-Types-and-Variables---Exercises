using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            int operand = int.Parse(Console.ReadLine());
            char Operator = char.Parse(Console.ReadLine());
            int secOperand = int.Parse(Console.ReadLine());
           
            switch (Operator)
            {
                case '+':
                    Console.WriteLine("{0} {1} {2} = {3}", operand,Operator, secOperand, (operand+secOperand));
                    break;
                case '-':
                    Console.WriteLine("{0} {1} {2} = {3}", operand, Operator, secOperand, (operand - secOperand));
                    break;
                case '*':
                    Console.WriteLine("{0} {1} {2} = {3}", operand, Operator, secOperand, (operand * secOperand));
                    break;
                default:
                    Console.WriteLine("{0} {1} {2} = {3}", operand, Operator, secOperand, (operand / secOperand));
                    break;
            }
        }
    }
}
