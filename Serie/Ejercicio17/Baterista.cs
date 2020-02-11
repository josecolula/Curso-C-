using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio17
{
    //Clase Baterista que hereda de la clase Músico
    class Baterista : Musico
    {
        //Método get que retorna el instrumento
        public override string Instrumento
        {
            get { return "bateria"; }
        }
        //Método que sobrescribe el  método de TocarInstrumento  de la clase Musico
        public override void TocarInstrumento()
        {
            //Impresión del nombre del musico y el instrumento que toca.
            Console.WriteLine("{0} esta tocando la {1}", Nombre, Instrumento);
        }
        //Método Constructor con sobrecarga, lee los atributos y tiene su base en los atributos de la clase Musico.
        public Baterista(string nombre, double peso, double altura, string genero) : base(nombre, peso, altura, genero) { }
        //Método de Redoblar.
        public void Redoblar()
        {
            //Método que imprime el nombre con la accion que esta realizando.
            Console.WriteLine("El baterista {0} esta redoblando", Nombre);
        }
        //Método de AjustarPlatillos
        public void AjustarPlatillos()
        {
            //Método que imprime el nombre con la accion que esta realizando.
            Console.WriteLine("El baterista {0} esta ajustando sus platillos", Nombre);
        } 
        //Método de información ToString, que retorna una cadena.
        public override string ToString()
        {
            //Retorno de cadena con nombre genero instumento ,peso y altura.
            return string.Format("{0} {1} toca la {2}, pesa {3} Kg y mide {4}",Nombre,Genero, Instrumento, Peso,Altura);
        }
    }
}
