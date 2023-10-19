using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peso
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //4 – Criar um programa que permita que o usuário digite seu peso em kg, calcular e mostrar:
            // Peso em gramas.
            // O peso com um acréscimo de 10 %

            Console.Title = "Conversão kilos";

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();

            double kilos, gramas, kilo10;

            Console.ForegroundColor = ConsoleColor.Red;

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

            Console.SetCursorPosition(20, 11);
            Console.WriteLine("╔════════════════════════╗");
            Console.SetCursorPosition(20, 12);
            Console.WriteLine("║                        ║");
            Console.SetCursorPosition(20, 13);
            Console.WriteLine("╠════════════════════════╣");
            Console.SetCursorPosition(20, 14);
            Console.WriteLine("║                        ║");
            Console.SetCursorPosition(20, 15);
            Console.WriteLine("║                        ║");
            Console.SetCursorPosition(20, 16);
            Console.WriteLine("║                        ║");
            Console.SetCursorPosition(20, 17);
            Console.WriteLine("║                        ║");
            Console.SetCursorPosition(20, 18);
            Console.WriteLine("║                        ║");
            Console.SetCursorPosition(20, 19);
            Console.WriteLine("╚════════════════════════╝");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.SetCursorPosition(6, 3);
            Console.WriteLine("Seu peso em kilogramas:");

            Console.SetCursorPosition(35, 3);
            Console.WriteLine("Seu peso em gramas:");

            Console.SetCursorPosition(21, 12);
            Console.WriteLine("Seu peso + 10%:");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
           
            Console.SetCursorPosition(6, 5);
            kilos = Convert.ToDouble(Console.ReadLine());

            kilo10 = kilos + (kilos) * 10 / 100;

            Console.SetCursorPosition(21, 14);
            Console.WriteLine(kilo10 + "kg");

            gramas = kilos * 1000;           

            Console.SetCursorPosition(34, 5);
            Console.WriteLine(gramas + "g");
            Console.ReadKey();
        }
    }
}
