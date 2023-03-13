namespace ListaExercicio.Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o km inicial: ");
            double kminicial = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();    
            Console.WriteLine("Digite o km final: ");
            double kmfinal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite o valor do combustivel: ") ;
            double valorcombustivel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine() ;   

            double distancia = kmfinal - kminicial;
            double consumocombustivel = distancia / valorcombustivel;
            Console.WriteLine("\n A distancia percorrida foi de " + distancia + " o consumo de combustivel foi de: " + consumocombustivel);
            Console.ReadLine(); 
        }
    }
}