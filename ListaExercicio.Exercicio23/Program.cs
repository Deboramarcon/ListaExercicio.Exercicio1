/*23. Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.*/
namespace ListaExercicio.Exercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números ímpares entre 100 e 200: ");
            Console.WriteLine();

            for (int i = 101; i < 200; i +=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}