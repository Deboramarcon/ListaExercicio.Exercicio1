using System.Formats.Asn1;

namespace ListaExercicio.Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o comprimento da caixa: ");
            decimal comprimentodacaixa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite a largura da caixa: ");
            decimal larguradacaixa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite a altura da caixa: ");
            decimal alturadacaixa = Convert.ToInt32(Console.ReadLine());

            decimal area = comprimentodacaixa * larguradacaixa * alturadacaixa;
            Console.WriteLine("area: " + area);
            Console.ReadLine();
        }
    }
}