/*A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a
venda dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado).*/
namespace ListaExercicio.Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantos pães foram vendidos: ");
            int paes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantas broas foram vendidas: ");
            int broas = int.Parse(Console.ReadLine());
            Console.WriteLine();

            double valorPao = 0.12;
            double valorBroa = 1.50;

            double totalPao = paes * valorPao;
            double totalBroa = broas * valorBroa;

            double totalVendido = totalPao + totalBroa;

            double poupança = totalVendido * 0.1;

            Console.WriteLine("Valor total de pães: " + String.Format("{0:C}", totalPao));
            Console.WriteLine("Valor total de broas: " + String.Format("{0:C}", totalBroa));
            Console.WriteLine("Valor total vendido: " + String.Format("{0:C}", totalVendido));
            Console.WriteLine("Valor poupança: " + String.Format("{0:C}", poupança));

            Console.WriteLine();
        }
    }
}