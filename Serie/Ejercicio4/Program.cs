using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excepción Formato de Ingreso
            try
            {
                //Lectura de número de elementos de la serie
                Console.WriteLine("Ingresa el número de elementos: ");
                int elementos = Convert.ToInt32(Console.ReadLine());
                //Llamada al método Fibonacci
                Fibonacci(elementos);
            }
            //Mensaje al saltar la Excepción de Formato
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Ingresa un número entero");
            }
            catch(OverflowException oe)
            {
                Console.WriteLine(oe.Message);
                Console.WriteLine("Ingresa un número más pequeño");
            }
            Console.ReadKey();
        }
        //Método de generación de numeros de la serie de Fibonacci
        static void Fibonacci(int elementos)
        {
            Console.WriteLine("Serie de Fibonacci");
            int k = 0;
            int l = 1;
            //Generación de numeros de la serie
            for (int i = 0; i < elementos; i ++)
            {
                if((i==0) || (i==1))
                {
                    k = 0;
                    l = 1;
                    //Impresión de los primeros 2 elementos
                    Console.Write(i+",");
                }
                else
                {
                    //Generación de elementos de la serie
                    l = k + l;
                    k = l - k;
                    if(i < elementos - 1)
                    {
                        //Impresión de elementos
                        Console.Write(l + ",");
                    }
                    else
                    {
                        //Impresión de elementos
                        Console.Write(l);
                    }
                    
                }
            }

        }
    }
}
