using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Autos");
            //Creación de objetos Auto
            Auto a1 = new Auto("Toyota", "Corola", "PXP-33-53", 500000.00, 30, 7);
            Auto a2 = new Auto("Ford", "F-Series", "TKY-28-73", 200000.00, 50, 12);
            Auto a3 = new Auto("Volkswagen", "Beetle", "UVU-017-60", 100000.00, 20, 5);
            //Llamado de los métodos del auto
            a1.Avanza();
            a2.Estaciona();
            a3.CargaPasajeros();
            //Asignación de valores a los atributos por medio del metodo set decada uno.
            a1.Placas = "WCV-89-60";
            a2.Marca = "Honda";
            a3.CapacidadPasajero = 6;

            Console.WriteLine();
            //Impresión de los valores cambiados por medio de método get de cada atributo
            Console.WriteLine("Nuevos valores: ");
            Console.WriteLine(a1.Placas);
            Console.WriteLine(a2.Marca);
            Console.WriteLine(a3.CapacidadPasajero);

            Console.ReadKey();

        }
    }
}
