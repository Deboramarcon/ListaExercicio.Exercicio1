/*11. Crie um programa para verificar se um número é primo.*/
namespace ListaExercicio.Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número positivo: ");
            int numero = int.Parse(Console.ReadLine());

            bool ehPrimo = true;
            if (numero <= 1)
            {
                ehPrimo = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        ehPrimo = false;
                        break;
                    }
                }
            }
            if (ehPrimo)
            {
                Console.WriteLine($"É primo {numero}");
            }
            else
            {
                Console.WriteLine($"Não é primo {numero}");
            }
            Console.ReadLine (); 
        }
    }
}