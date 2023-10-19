using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //3 - Escreva um algoritmo para ler uma temperatura em graus Fahrenheit,
            //  calcular e escrever o valor correspondente em graus Celsius

            Console.Title = "Conversão para Fahrenheit";

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            double farem, celsius;

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

            Console.SetCursorPosition(33, 2);
            Console.WriteLine("╔════════════════════════╗");
            Console.SetCursorPosition(33, 3);
            Console.WriteLine("║                        ║");
            Console.SetCursorPosition(33, 4);
            Console.WriteLine("╠════════════════════════╣");
            Console.SetCursorPosition(33, 5);
            Console.WriteLine("║                        ║");
            Console.SetCursorPosition(33, 6);
            Console.WriteLine("║                        ║");
            Console.SetCursorPosition(33, 7);
            Console.WriteLine("║                        ║");
            Console.SetCursorPosition(33, 8);
            Console.WriteLine("║                        ║");
            Console.SetCursorPosition(33, 9);
            Console.WriteLine("║                        ║");
            Console.SetCursorPosition(33, 10);
            Console.WriteLine("╚════════════════════════╝");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(6, 3);
            Console.WriteLine("Temperatura em Fahrenheit:");

            Console.SetCursorPosition(35, 3);
            Console.WriteLine("Temperatura em Celsius:");

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.SetCursorPosition(6, 5);
            Console.WriteLine("°F");

            Console.SetCursorPosition(8, 5);
            farem = Convert.ToDouble(Console.ReadLine());
            

            celsius = (farem - 32) / (1.8);

            Console.SetCursorPosition(36, 5);
            Console.WriteLine("C°" + Math.Round(celsius,2));
            Console.ReadKey();
        }
    }
}
