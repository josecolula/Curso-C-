using System;

namespace Excepciones2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrea un valor para calcular su raiz cuadrada: ");
                double dato = Convert.ToDouble(Console.ReadLine());
                double resultado = RaizCuadrada(dato);

                Console.WriteLine("La raiz cudrada de {0} es {1}\n", dato, resultado);

            }
            catch (FormatException fe)
            {
                Console.WriteLine("\n" + fe.Message);
                Console.WriteLine("Ingresa un número");
            }
            catch(NegativeNumberException NE)
            {
                Console.WriteLine("\n" + NE.Message);
                Console.WriteLine("Ingresa un número no negativo");
            }
            Console.ReadKey();
        
        }
        public static double RaizCuadrada(double dato)
        {
            if(dato < 0)
            {
                throw new NegativeNumberException("No pongas numeros negativos");
            }
            else
            {
                return Math.Sqrt(dato);
            }
            
        }
    }
}
