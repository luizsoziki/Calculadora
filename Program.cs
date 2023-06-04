using System.Runtime.CompilerServices;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O Resultado Da Soma De 5+2 é:");
            var resultadoDaSoma = Calcular(2, 5);
            Console.WriteLine(resultadoDaSoma);
        }
        public static int Calcular(int numero1, int numero2) 
        { 
            return numero1+numero2; 
        }
    }
}