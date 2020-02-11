using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio16
{
    //Clase Perro
    class Perro
    {
        //Atributos de la clase Perro
        string color;
        public string raza;
        double peso;
        double altura;
        string nombre;
        //Métodos get y set para cada uno de los atributos
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public double Peso
        {
            get { return peso; }
            set
            {
                //Validación del atributo sea mayor a 0
                if(value <= 0)
                {
                    Console.WriteLine("Altura invalida");
                }
                else
                {
                    //Asignación del valor 
                    peso = value;
                }
            }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double Altura
        {
            get { return altura; }
            set
            {
                //Validación del atributo sea mayor a 0
                if (value <= 0)
                {
                    Console.WriteLine("Altura invalida");
                }
                else
                {
                    //Asignación del valor 
                    altura = value;
                }
            }
        }
        //Métodos de la clase que se pueden sobrescribir por otras clases.
        public virtual void Ladra() { }
        public virtual void Corre() { }
        public virtual void Dormir() { }
    }
}
