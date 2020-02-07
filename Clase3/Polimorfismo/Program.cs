using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo c1 = new Circulo();
            c1.Radio = 5;
            c1.DatosCirculo();

            //Upcasting
            IFigura f1 = new Circulo { Radio = 5 };
            f1.CalcularArea();

            IFigura f2 = new Triangulo { Base = 10, Altura = 9 };
            //f2.CalcularArea();

            IFigura f3 = new Rectangulo { Base = 4, Altura = 8 };

            IFigura[] figuras = new IFigura[] { f1, f2, f3, c1};

            foreach( var figura in figuras )
            {
                Console.WriteLine("Area: " + figura.CalcularArea());
            }

            //DownCasting
            Circulo c = f1 as Circulo;
            //c.Radio = 5;
            Console.WriteLine("Datos del Circulo: ");
            c.DatosCirculo();
            Console.ReadKey();



        }
    }
}
