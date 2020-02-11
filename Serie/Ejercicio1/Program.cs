using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escpción de Formato de ingreso no valido
            try
            {
                //Lectura de número natural 
                Console.WriteLine("Ingresa el número de natural");
                int natural = Convert.ToInt32(Console.ReadLine());
                CalculaSuma(natural);

            }
            //Mensaje de Excepción de Formato Ingresado
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Debes ingresar un número natural");
            }
            //Mensaje de Excepción de Desbordamiento de variable
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
                Console.WriteLine("Numero que escede el tamaño del tipo");
            }
            Console.ReadKey();

        }
        //Método de calculo de la suma 
        static void CalculaSuma(int valor)
        {
            //Variable contenedora de la suma
            int sum=0;
            //Ciclo de generación de los números anterioes al dado
            for (int i = 0; i < valor; i++)
            {
                //Suma de los números generas
                sum = sum + i;
            }
            //Impresón de la suma
            Console.WriteLine("Suma: " + sum);
        }
    }
}
