using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio17
{
    //Clase Musico
    abstract class Musico
    {
        //Atributos de la clase Musico
        string instrumento;
        string nombre;
        double peso;
        double altura;
        string genero;
        //Métodos get y set para los atributos.
        public double Peso
        {
            get { return peso; }
            set
            {
                //Validación que el valor sea mayor a 0
                if(value <= 0)
                {
                    Console.WriteLine("Peso Invalido");
                }
                else
                {
                    //Asignación del valor al atributo de la clase.
                    peso = value;
                }
            }
        }
        public double Altura
        {
            get { return altura; }
            set
            {
                //Validación que el valor sea mayor a 0
                if (value <= 0)
                {
                    Console.WriteLine("Altura Invalido");
                }
                else
                {
                    //Asignación del valor al atributo de la clase.
                    altura = value;
                }
            }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        //Atributo abstracto Instrumento 
        public abstract string Instrumento
        {
            get;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        //Método abstracto TocarInstrumento.
        public abstract void TocarInstrumento();
        //Método Constructor con sobrecarga.
        public Musico(string nombre, double peso, double altura, string genero)
        {
            //Asignacón de Lectura a los atributos.
            this.nombre = nombre;
            this.peso = peso;
            this.altura = altura;
            this.genero = genero;
        }

    }
}
