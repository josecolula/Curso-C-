using System;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polimorfismo");
            //Creación de objetos de cada una de las clases hijas
            Chihuahua p1 = new Chihuahua("Perla",89,0.50,"Gris");
            Dalmata p2 = new Dalmata("Popi",95,1.15,"Blanco con negro");
            Bulldog p3 = new Bulldog("Cazador",67,90,"Cafe");
            Doberman p4 = new Doberman("Gallleta",100.70,1.25,"Negro");
            //Asignación de los objetos de la clases hijas a las un arreglo de la clase padre.
            Perro[] perrera = new Perro[] { p1, p2, p3, p4 };
            //Recorrido de cada uno de los objeto de los arreglo
            foreach(Perro perro in perrera)
            {
                //Llamado a los métodos que todos comparten.
                perro.Ladra();
                perro.Corre();
                perro.Dormir();
            }
            Console.ReadLine();



        }
    }
}
