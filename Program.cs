using System;

namespace ConsoleCadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual capsula você quer?");

            string capsula = Console.ReadLine();

            string xicara = FazerCafe(capsula);

            Console.WriteLine("tomei: " + xicara);
        }

        static string FazerCafe(string capsula)
        {
            Console.WriteLine("Esquentar agua");
            Console.WriteLine("Colocar pó de magia(café)");
            Console.WriteLine("Colocar " + capsula);
            return "cafe de " + capsula;
        }
    }
}