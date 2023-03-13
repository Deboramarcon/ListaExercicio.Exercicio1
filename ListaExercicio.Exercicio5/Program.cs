namespace ListaExercicio.Exercicio5
//5. Crie um programa para calcular o volume de uma esfera
//   V = 4/3 π .r³
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio da esfera: ");
            double raio = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            //double volume = (4.0 / 3.0) + Math.PI * Math.Pow(raio , 3);
            double volume = 4.0 * Math.PI * raio * raio * raio / 3;
            Console.WriteLine($"O volume da esfera é: {volume}");    

        }
    }
}