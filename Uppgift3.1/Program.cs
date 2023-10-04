using System;

namespace Uppgift3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder > 19)
            {
                Console.WriteLine("Du är för gammal!");
                Console.ReadKey();
            }
            else if (ålder < 16)
            {
                Console.WriteLine("Du är för ung!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Du får vara med!");
                Console.ReadKey();
            }
        }
    }
}