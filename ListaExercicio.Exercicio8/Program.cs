/*Crie um programa para calcular o volume de uma lata de óleo*/
namespace ListaExercicio.Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio da lata de óleo : ");
            double raio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite a altura da lata de óleo: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double volume = Math.PI * raio * raio * altura;
            Console.WriteLine("\n O volume da lata de óleo é: " + volume);
        }
    }
}