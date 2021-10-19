using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta eimene number");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta teine number");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("valitehe ('+', '-', '*', '/')");
            char useroperation = Convert.ToChar(Console.ReadLine());

            switch (useroperation)
            {
                case '+':
                    AddTwoNumbers(firstnumber, secondnumber);
                    break;
                case '/':
                    DivideTwoNumbers(firstnumber, secondnumber);
                    break;
                case '-':
                    SubtractTwoNumbers(firstnumber, secondnumber);
                    break;
                case '*':
                    MultiplyTwoNumbers(firstnumber, secondnumber);
                    break;
                default:
                    Console.WriteLine("vale tehe");
                    break;
            }
        }

        private static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
        }

        private static void DivideTwoNumbers(int x, int y)
        {
            int result = x / y;
            Console.WriteLine($"{x} / {y} = {result}");
        }
        private static void SubtractTwoNumbers(int x, int y)
        {
            int result = x - y;
            Console.WriteLine($"{x} - {y} = {result}");
        }
        private static void MultiplyTwoNumbers(int x, int y)
        {
            int result = x * y;
            Console.WriteLine($"{x} * {y} = {result}");
        }
    }
}
