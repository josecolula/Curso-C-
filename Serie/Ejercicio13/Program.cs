using System;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creación de objetos de las clase hijas
            CarroBWM c1 = new CarroBWM(1000.00,2.15);
            CarroVW c2 = new CarroVW(2000.00,1.95);
            Console.WriteLine("Carro 1");
            //Llamar a los métodos del objeto c1
            c1.Apagar();
            c1.Encender();
            c1.Estado();
            //c1.Peso = 1000.00;
            //c1.Altura = 2.15;
            //Upcast del objeto c1 de la clase CarroBWM a Carro
            Carro c3 = c1 as CarroBWM;
            //Llamar al método ToString de la clase Carro
            Console.WriteLine(c3.ToString());
            //Llamar al método ToString de la clase CarroBWM
            Console.WriteLine(c1.ToString());
            Console.WriteLine();
            Console.WriteLine("Carro 2");
            //Llamar a los métodos del objeto c1
            c2.Apagar();
            c2.Encender();
            c2.Estado();
            //c2.Peso = 2000.00;
            //c2.Altura = 1.95;
            //Upcast del objeto c2 de la clase CarroBWM a Carro
            Carro c4 = c2 as CarroVW;
            //Llamar al método ToString de la clase CarroBWM
            Console.WriteLine(c4.ToString());
            //Llamar a los métodos del objeto c1

            Console.WriteLine(c2.ToString());
            Console.ReadKey();


        }
    }
}
