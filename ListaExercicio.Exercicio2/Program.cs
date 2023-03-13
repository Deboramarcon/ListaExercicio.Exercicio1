namespace ListaExercicio.Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em graus Fahrenheit: ");
            Console.WriteLine();
            Double temperaturaFahrenheit = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            Double temperatura = 0;
            temperatura = (temperaturaFahrenheit - 32) / 1.8;

            Console.WriteLine("Temperatura em grau Celsius: " + temperatura);
            Console.ReadLine();

        }
    }
}