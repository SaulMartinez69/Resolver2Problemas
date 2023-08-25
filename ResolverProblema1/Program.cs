using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverProblema1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double numero=0, numero2=0;
            Console.WriteLine("Introduce un número para obtener su raiz cuadrada");
            numero = int.Parse(Console.ReadLine());
            numero2 = numero;
            double raizCuadrada = Math.Sqrt(numero);

            Console.WriteLine($"La raíz cuadrada de {numero} es: {raizCuadrada}");

            
            double raizCuadrada2 = Math.Pow(numero2, 0.5);

            Console.WriteLine($"La raíz cuadrada de {numero2} es: {raizCuadrada2}");
            Console.ReadKey();
        }
    }
}
