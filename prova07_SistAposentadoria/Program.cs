using System;

namespace prova07_SistAposentadoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Pensao vence = new Pensao();

            Console.WriteLine("Informe o Nome:");
            vence.Nome = Console.ReadLine();

            Console.WriteLine("Informe a Idade:");
            vence.Idade = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Sexo:");
            vence.Sexo = Console.ReadLine().ToLower();

            vence.Aposenta();
        }
    }
}
