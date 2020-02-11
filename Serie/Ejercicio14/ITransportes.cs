using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio14
{
    //Interfaz de transportes
    interface ITransportes
    {
        //Atributos de la interfaz con métodos get y set, privados.
        string marca { set; get; }
        string modelo { set; get; }
        //Métodos de la intefaz, privados y abstractos.
        void Acelerar();
        void Frenar();
        void Girar();
    }
}
