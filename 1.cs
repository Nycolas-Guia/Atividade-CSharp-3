using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace salario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1 – Criar um programa que permita a digitação do salário mínimo e do salário do usuário,
            //  calcular quantos salários mínimos a pessoa ganha.


            Console.Title = "Salario";
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();

            double salario, recebe, quantidade;

            Console.ForegroundColor = ConsoleColor.Black;

           
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

            Console.SetCursorPosition(16, 11);
            Console.WriteLine("╔════════════════════════════════╗");
            Console.SetCursorPosition(16, 12);
            Console.WriteLine("║                                ║");
            Console.SetCursorPosition(16, 13);
            Console.WriteLine("╠════════════════════════════════╣");
            Console.SetCursorPosition(16, 14);
            Console.WriteLine("║                                ║");
            Console.SetCursorPosition(16, 15);
            Console.WriteLine("║                                ║");
            Console.SetCursorPosition(16, 16);
            Console.WriteLine("║                                ║");
            Console.SetCursorPosition(16, 17);
            Console.WriteLine("║                                ║");
            Console.SetCursorPosition(16, 18);
            Console.WriteLine("║                                ║");
            Console.SetCursorPosition(16, 19);
            Console.WriteLine("╚════════════════════════════════╝");

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.SetCursorPosition(6, 3);
            Console.WriteLine("Salario minimo atual: ");

            Console.SetCursorPosition(37, 3);
            Console.WriteLine("Seu salario: ");


            Console.SetCursorPosition(6, 5);
            Console.WriteLine("R$");
            Console.SetCursorPosition(17, 12);
            Console.WriteLine("Quantidade de salários minimos: ");

            Console.SetCursorPosition(8, 5);
            salario = Convert.ToDouble(Console.ReadLine());

            Console.SetCursorPosition(36, 5);
            Console.WriteLine("R$");
            Console.SetCursorPosition(38, 5);
            recebe = Convert.ToDouble(Console.ReadLine());
           
            quantidade = recebe / salario;
            Console.SetCursorPosition(17, 14);

            Console.WriteLine(Math.Round(quantidade,2));


            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ReadKey();
        }
    }
}
