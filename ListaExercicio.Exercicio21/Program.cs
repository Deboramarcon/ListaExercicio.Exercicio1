/*21. Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso
contrário multiplique A por B.*/
namespace ListaExercicio.Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;
            Console.WriteLine("Digite o número A: ");
            int numeroA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número B: ");
            int numeroB = int.Parse(Console.ReadLine());

            if (numeroA == numeroB)
            {
                c = numeroA + numeroB;
                Console.WriteLine($"Os valores são iguais,a soma dos dois números é: {c}");
            }
            else
            {
                c = numeroA * numeroB;
                Console.WriteLine($"Os números são diferentes, a mutiplicação dos números é: {c}");
            }
            Console.WriteLine();

        }
    }
}