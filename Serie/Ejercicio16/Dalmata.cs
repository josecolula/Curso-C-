using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio16
{
    //Clase Dalmata que hereda de la clase Perro
    class Dalmata : Perro
    {
        //Método Ladra que sobrescribe el método Ladra de la clase Perro
        public override void Ladra()
        {
            //Mensaje con el nombre del perro, la raza y mencionando que esta ladrando.
            Console.WriteLine("El perro {0} de raza {1} esta ladrando",Nombre,raza);
        }
        //Método Corre que sobrescribe el método Corre de la clase Perro
        public override void Corre()
        {
            //Mensaje con el nombre del perro, la raza y la altura mencionando que esta corriendo.
            Console.WriteLine("El perro {0} de peso {1} y altura {2} esta corriendo", Nombre, Peso, Altura);
        }
        //Método Dormir que sobrescribe el método Dormir de la clase Perro
        public override void Dormir()
        {
            //Mensaje con el nombre del perro, la raza y el color mencionando que esta ladrando.
            Console.WriteLine("El perro {0} de raza {1} y color {2} esta durmiendo", Nombre, raza, Color);
        }
        //Método constructor
        public Dalmata() { raza = "Dalmata"; }
        //Método Constructor con sobrecargo.
        public Dalmata(string nombre, double peso, double altura, string color)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Color = color;
            raza = "Dalmata";

        }
    }
}
