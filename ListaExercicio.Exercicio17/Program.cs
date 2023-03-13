/*Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.*/
namespace ListaExercicio.Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor A: ");
            int valorA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor B: ");
            int valorB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor C: ");
            int valorC = int.Parse(Console.ReadLine()); 
            Console.WriteLine();

            if (valorA + valorB < valorC)
            {
                Console.WriteLine("A soma de A+B é menor que C");
            }
            else 
            {
                Console.WriteLine("A soma de A+B é igual ou maior que C");
            }
            Console.WriteLine();
        }
    }
}