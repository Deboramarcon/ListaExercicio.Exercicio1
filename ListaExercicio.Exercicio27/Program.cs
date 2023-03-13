/*27. Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.*/
namespace ListaExercicio.Exercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int atual = 1, anterior =0, proximo;
            Console.WriteLine("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Sequência de Fibonacci até o número {numero}");

            while (atual <= numero)
            {
            Console.WriteLine($"{atual}") ;
                proximo = atual + anterior;
                anterior = atual;
                atual = proximo;
            }
        }       
    }
}