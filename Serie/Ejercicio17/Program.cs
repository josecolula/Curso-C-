/*Abstracción: Es la capacidad de obtener y aislar toda la información 
 * y cualidades de un objeto que no nos parezcan relevantes, para poder encapsularlos.
 * Encapsulamiento: Es la capacidad de ocultar los datos abstraidos o protegerlos de quien 
 * no desees que tenga acceso a ellos.
 * Herencia: Puede crearse una clase a partie de otra clase ya existente, heredando
 * todas las cualidades de la clase de la que deriva y ademas pudiendo añadir nuevas
 * funcionalidades o modificar las ya existente.
 * Polimorfismo: Es la capacidad para que varias clases u objetos derivados de otros, reaccionen
 * de manera diferente ante los mismos métodos.
 * 
 */

using System;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creación de objetos de cada una de las clases.
            Console.WriteLine("Pilares de la programación");
            Baterista m1 = new Baterista("Noe",75.50,1.74,"Hombre");
            Pianista m2 = new Pianista("Beto",65.20,1.75,"Hombre");
            Guitarrista m3 = new Guitarrista("Fausto",78.79,1.60,"Hombre");
            //Llamada de métodos del objeto m1
            Console.WriteLine(m1.ToString());
            m1.TocarInstrumento();
            m1.Redoblar();
            m1.AjustarPlatillos();
            Console.WriteLine();
            //Llamada de métodos del objeto m2
            Console.WriteLine(m2.ToString());
            m2.TocarInstrumento();
            m2.Afinar();
            Console.WriteLine();
            //Llamada de métodos del objeto m3
            Console.WriteLine(m3.ToString());
            m3.TocarInstrumento();
            m3.Requintear();
            m3.Afinar();
            Console.ReadKey();

        }
    }
}
