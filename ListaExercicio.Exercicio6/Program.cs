namespace ListaExercicio.Exercicio6
//6. Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperaruta Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double fahrenheit = (celsius * 9/5) + 32;
            Console.WriteLine($"Temperatura em grau Fahreneit: {fahrenheit}" );
        }
    }
}