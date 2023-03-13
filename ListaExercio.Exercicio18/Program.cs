/*18. Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.*/
namespace ListaExercio.Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1º número: ");
            int primeiroNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número: ");
            int segundoNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 3º número: ");
            int terceiroNumero = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (primeiroNumero > segundoNumero && primeiroNumero > terceiroNumero)
            {
                if (segundoNumero > terceiroNumero)
                {
                    Console.WriteLine($"\n {primeiroNumero},{segundoNumero},{terceiroNumero}");
                }
                else
                {
                    Console.WriteLine($"\n {primeiroNumero},{terceiroNumero},{segundoNumero}");
                }
            }
            else if (segundoNumero > primeiroNumero && segundoNumero > terceiroNumero)
            {
                if (primeiroNumero > terceiroNumero)
                {
                    Console.WriteLine($"\n {segundoNumero},{primeiroNumero},{terceiroNumero}");
                }
                else
                {
                    Console.WriteLine($"\n {segundoNumero},{terceiroNumero},{primeiroNumero}");
                }
            }
            else
            {
                if (primeiroNumero > segundoNumero)
                {
                    Console.WriteLine($"\n {terceiroNumero},{primeiroNumero},{segundoNumero}");
                }
                else
                {
                    Console.WriteLine($"\n{terceiroNumero},{segundoNumero},{primeiroNumero}");
                }
            }
            Console.WriteLine();

        }
    }
}