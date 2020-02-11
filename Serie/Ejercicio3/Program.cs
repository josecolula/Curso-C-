using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excepción de Formato de ingreso
            try
            {
                //Lectura de la cadena  
                Console.WriteLine("Ingresa un texto: ");
                string cadena = Console.ReadLine();
                //Método de Modificación de cadena ingresada
                ModificacionCadena(cadena);
            }
            //Mensajes de Excepción de Formato Ingresado
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Ingresa una cadena de texto");
            }
            Console.ReadKey();

        }
        
        static void ModificacionCadena(string cadena)
        {
            //Replaza cada una de la vocales con una f y la vocal
            cadena = cadena.Replace("a", "fa");            
            cadena = cadena.Replace("e", "fe");
            cadena = cadena.Replace("i", "fi");
            cadena = cadena.Replace("o", "fo");
            cadena = cadena.Replace("u", "fu");
            cadena = cadena.Replace("A", "fA");
            cadena = cadena.Replace("E", "fE");
            cadena = cadena.Replace("I", "fI");
            cadena = cadena.Replace("O", "fO");
            cadena = cadena.Replace("U", "fU");
            //Impresión de cadena modificada   
            Console.WriteLine();
            Console.WriteLine("Cadena Modificada: ");
            Console.WriteLine(cadena);
        }
        

    }
}
