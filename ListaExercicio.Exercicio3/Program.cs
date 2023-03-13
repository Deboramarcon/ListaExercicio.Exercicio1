namespace ListaExercicio.Exercicio3
//Crie um programa para calcular o volume de um Cilindro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio do cilindro: ");
            double raio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite a altura do cilindro: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double volume = Math.PI * raio * raio * altura;
            Console.WriteLine("\n O volume do cilindro é: " + volume );
        }
    }
}