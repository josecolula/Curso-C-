using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio17
{
    //Clase Pianista que hereda de la clase Músico
    class Pianista : Musico
    {
        //Método get que retorna el instrumento
        public override string Instrumento
        {
            get { return "piano"; }
        }
        //Método que sobrescribe el  método de TocarInstrumento  de la clase Musico
        public override void TocarInstrumento()
        {
            //Impresión del nombre del musico y el instrumento que toca.
            Console.WriteLine("{0} esta tocando la {1}", Nombre, Instrumento);
        }
        //Método Constructor con sobrecarga, lee los atributos y tiene su base en los atributos de la clase Musico.
        public Pianista(string nombre,double peso,double altura,string genero) : base(nombre,peso,altura,genero) { }
        //Método de Afinar.
        public void Afinar()
        {
            //Método que imprime el nombre con la accion que esta realizando.
            Console.WriteLine("El pianista {0} esta afinando el piano", Nombre);
        }
        //Método de información ToString, que retorna una cadena.
        public override string ToString()
        {
            //Retorno de cadena con nombre genero instumento ,peso y altura.
            return string.Format("{0} {1} toca el {2}, pesa {3} Kg y mide {4}", Nombre, Genero,Instrumento, Peso, Altura);
        }
    }
}
