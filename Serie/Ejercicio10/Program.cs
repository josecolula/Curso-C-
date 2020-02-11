using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Manejo de excepciones
            try
            {
                //Creación del objeto Persona
                Persona p = new Persona();
                Console.WriteLine("Datos Usuario");
                //Ingreso de datos desde consola
                Console.WriteLine("Ingresa tu nombre: ");
                p.Nombre = Console.ReadLine();
                Console.WriteLine("Ingresa tu edad: ");
                p.Edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa tu estatura(metros): ");
                p.Estatura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa tu peso(Kg):");
                p.Peso = Convert.ToDouble(Console.ReadLine());
                //Impresión de información del usuario
                Console.WriteLine(p.ToString());
                //Llamada a los métodos
                p.Envejecer();
                p.CambiarEstatura();
                p.CambiarPeso();
                //Impresión de información
                Console.WriteLine(p.ToString());

            }
            //Excepción de formato de ingreso no valido
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Ingresa un formato valido de entrada");
            }
            //Excepción de tamaño ingresado es mayor al formato de tipo de dato.
            catch(OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }

            Console.ReadKey();
        }
    }
}
