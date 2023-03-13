/*12. A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um
terreno e depois exibir a área do terreno.*/
namespace ListaExercicio.Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o comprimento do terreno: ");
            double comprimento = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura do terreno: ");
            double largura = double.Parse(Console.ReadLine());

            double area = comprimento * largura;
            Console.WriteLine();
            Console.WriteLine($"Área do terreno é: {area} metros quadrados.");

            Console.ReadLine(); 
        }
    }
}