/*Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno*/
using System.Runtime.CompilerServices;

namespace ListaExercicio.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digitie a nota da prova 1: ");
            Decimal prova1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite o peso da prova 1: ");
            Decimal peso1 = decimal.Parse(Console.ReadLine());  
            Console.WriteLine();
            Console.WriteLine("Digitie a nota da prova 2: ");
            Decimal prova2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite o peso da prova 2: ");
            Decimal peso2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            decimal media = ((prova1 + peso1) + (prova2 + peso2)) / (peso1 + peso2);
            Console.WriteLine($"Media ponderada: {media}");



        }
    }
}