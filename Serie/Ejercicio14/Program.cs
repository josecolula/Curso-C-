/*
 * El objetivo de un interface es poder incluir los atributos 
 * y metodos comunes de multiples clases, en un sola, esa capacidad es importante
 * ya que el lenguje C# no admite la herencia múltiple de clase.
 * Una interfaz nos permite simular la herencia de estructuras.
 */

using System;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfaces");
            //Creación de objetos de la Interfaz con las clases hijas
            ITransportes t1 = new Automoviles("BMW","2000");
            ITransportes t2 = new Aviones("Boeing","747");
            ITransportes t3 = new Trenes("Lionel","027");
            //Poniendo los objetos en un agrego de interfaces.
            ITransportes[] transportes = new ITransportes[] { t1, t2, t3 };
            //Recorrido del arreglo
            foreach(ITransportes transporte in transportes)
            {
                //Llamar a los métodos compartidos por la Interfaz
                transporte.Acelerar();
                transporte.Frenar();
                transporte.Girar();
            }
            Console.ReadKey();
        }
    }
}
