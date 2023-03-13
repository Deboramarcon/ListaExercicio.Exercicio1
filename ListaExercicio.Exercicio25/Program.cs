/*25. Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N. Mostre a
tabuada na forma:
 0 x N = 0,
 1 x N = 1N,
 2 x N = 2N,*/
namespace ListaExercicio.Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de 1 a 10: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10 ; i++) 
            {
            Console.WriteLine($"{i}*{numero}= {i * numero}");
            }
        }
    }
}