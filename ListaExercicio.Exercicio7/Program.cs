/*7. Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
vendas. A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.*/
namespace ListaExercicio.Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu salario: ");
            decimal salariobase = decimal.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite o total de vendas: ");
            decimal vendas = decimal.Parse(Console.ReadLine());
            Console.WriteLine() ;

            Console.WriteLine("Digite o percuntal de comissão: ");
            decimal percentual = decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            decimal comissao = (vendas * percentual) + salariobase;
            Console.WriteLine($"Salario total: {comissao}");


        }
    }
}