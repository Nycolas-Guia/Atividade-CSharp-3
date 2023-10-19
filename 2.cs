using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kelvin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2 – Elaborar um programa que permita que o usuário digite uma temperatura em graus Celsius e o programa converta para Kelvin.

            Console.Title = "Conversão em Kelvin";

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            double celsius, kelvin;

            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(5, 2);
            Console.WriteLine("╔══════════════════════════╗");
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("║                          ║");
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("╠══════════════════════════╣");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("║                          ║");
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("║                          ║");
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("║                          ║");
            Console.SetCursorPosition(5, 8);
            Console.WriteLine("║                          ║");
            Console.SetCursorPosition(5, 9);
            Console.WriteLine("║                          ║");
            Console.SetCursorPosition(5, 10);
            Console.WriteLine("╚══════════════════════════╝");

            Console.SetCursorPosition(35, 2);
            Console.WriteLine("╔══════════════════════════╗");
            Console.SetCursorPosition(35, 3);
            Console.WriteLine("║                          ║");
            Console.SetCursorPosition(35, 4);
            Console.WriteLine("╠══════════════════════════╣");
            Console.SetCursorPosition(35, 5);
            Console.WriteLine("║                          ║");
            Console.SetCursorPosition(35, 6);
            Console.WriteLine("║                          ║");
            Console.SetCursorPosition(35, 7);
            Console.WriteLine("║                          ║");
            Console.SetCursorPosition(35, 8);
            Console.WriteLine("║                          ║");
            Console.SetCursorPosition(35, 9);
            Console.WriteLine("║                          ║");
            Console.SetCursorPosition(35, 10);
            Console.WriteLine("╚══════════════════════════╝");

            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.SetCursorPosition(7, 3);
            Console.WriteLine("Temperatura em Celsius:");

            Console.SetCursorPosition(37, 3);
            Console.WriteLine("Temperatura em Kelvin:");

            Console.SetCursorPosition(6, 5);
            Console.WriteLine("C°");

            Console.SetCursorPosition(8, 5);
            celsius = Convert.ToDouble(Console.ReadLine());            
            
            kelvin = celsius + 273.15;

            Console.SetCursorPosition(36,5);
            Console.WriteLine("K°"+kelvin);
            Console.ReadKey();
        }
    }
}
