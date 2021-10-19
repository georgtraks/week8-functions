using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma nimi");
            string username = Console.ReadLine();
            Console.WriteLine("sisesta oma vanus:");
            int userage = Convert.ToInt32(Console.ReadLine());
            sayhello(username, userage);
        }

    private static void sayhello(string somename, int somenumber)
        {
            Console.WriteLine($"hi there! {somename}!");
            Console.WriteLine($"oled sündinud aastal {2021 - somenumber}.");
        }
    }
}
