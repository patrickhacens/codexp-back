using System;

namespace ConsoleCadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Qual é a sua idade?");

            string usuarioEscreveu = Console.ReadLine();


            idade = int.Parse(usuarioEscreveu);

            Console.Write("Sua idade é:"); 

            Console.Write(idade);
        }
    }
}
