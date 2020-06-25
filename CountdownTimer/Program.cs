using System;
using System.Threading;

namespace CountdownTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Countdown timer");
            Console.WriteLine("---------------");

            Console.Write("How many seconds do you want to wait? ");
            string inputString = Console.ReadLine();

            Console.CursorVisible = false;

            for (int i = Int32.Parse(inputString); i > 0; i--)
            {
                Console.Write($"\r{i} seconds left      ");
                Thread.Sleep(1000);
            }

            Console.Write($"\rTime's up!       ");
            Thread.Sleep(1000);
        }
    }
}
