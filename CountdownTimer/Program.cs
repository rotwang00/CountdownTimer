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

            int seconds = Int32.Parse(inputString);
           
            for (int i = seconds; i > 0; i--)
            {
                var remaining = TimeSpan.FromSeconds(i);
                
                Console.Write("\r" + remaining.ToString(@"mm\:ss") + " left      ");
                Thread.Sleep(1000);
            }

            Console.Write("\rTime's up!       ");
            Thread.Sleep(1000);
        }
    }
}
