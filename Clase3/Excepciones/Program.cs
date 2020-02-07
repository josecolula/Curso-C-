using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Convert.ToInt32 genera FormatException
                Console.WriteLine("Ingresa el numerador: ");
                int numerador = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa el denominador: ");
                int denominador = Convert.ToInt32(Console.ReadLine());

                //División entre 0 genera una excepción DivideByZeroException
                double resultado = numerador / denominador;

                Console.WriteLine("\nResultado: {0} / {1} = {2}", numerador, denominador, resultado);
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("\n" + formatException.Message);
                Console.WriteLine("Debes de ingrear dos enteros");
            }
            catch (DivideByZeroException divideByZeroException)
            {
                Console.WriteLine("\n" + divideByZeroException.Message);
                Console.WriteLine("Cero es un denominador invalido");
            }
            finally
            {
                Console.WriteLine("Fin del programa");
            }
            Console.ReadKey();

        }
    }
}
