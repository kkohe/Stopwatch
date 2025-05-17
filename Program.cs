using System;
using System.Threading;

namespace Stopwatch {
    internal class Program {
        static void Main(string[] args) {

            Menu();
        }

        static void Menu() {

            Console.WriteLine("Use like this -> 10s, 10m");
            Console.WriteLine("-------------------");
            Console.WriteLine("S - Second");
            Console.WriteLine("M  - Minute");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("-------------------");
            Console.WriteLine("Set the time: ");

            string data = Console.ReadLine().ToLower(); // Converte para minusculo.
            char type = char.Parse(data.Substring(data.Length - 1, 1)); 
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }

        static void PreStart(int time) {

            Console.WriteLine("Ready...");
            Thread.Sleep(500);
            Console.WriteLine("Set...");
            Thread.Sleep(500);
            Console.WriteLine("Go!");
            Thread.Sleep(600);

            Start(time);

        }
        static void Start(int time) {

            int currentTime = 0;

            while (currentTime != time) {

                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(600);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch has finalized.");
            Thread.Sleep(2000);
            Console.Clear();
            Menu();
        }
    }
}
