/*Abaixo de 18,5
 Abaixo do peso
 Entre 18,5 e 25 Peso normal
 Entre 25 e 30
 Acima do peso
 Acima de 30 obeso
IMC = peso / (altura) ².*/
namespace ListaExercicio.Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine();
            //usar virgula 

            double imc = peso / (altura * altura);
            Console.WriteLine($"Valor do IMC: {imc}");

            if (imc < 18.5)
            {
                Console.WriteLine("Condição abaixo do peso.");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Condição de peso normal.");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Condição acima do peso.");
            }
            else
            {
                Console.WriteLine("Condição obeso.");
            }
            Console.WriteLine();    
        }
    }
}