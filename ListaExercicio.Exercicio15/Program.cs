/*16. Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
impostos. Imprima o salário inicial, o salário com o aumento e o salário final.*/
namespace ListaExercicio.Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salário: ");
            double salarioInicial = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            double aumento = salarioInicial * 0.15;
            double aumentoFinal = salarioInicial + aumento;

            double imposto = aumentoFinal * 0.08;
            double salarioFinal = aumentoFinal - imposto;
            Console.WriteLine();

            Console.WriteLine($"Salário inicial: R$ {salarioInicial:F2}");
            Console.WriteLine($"Salário com aumento de 15%: R$ {aumentoFinal:F2}");
            Console.WriteLine($"Salário com aumento com desconto de 8%: R$ {salarioFinal:F2}");
            Console.WriteLine();
        }
    }
}