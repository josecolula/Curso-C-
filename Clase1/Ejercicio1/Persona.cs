using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
        //Persona1.Equals(Persona2)
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Persona p = obj as Persona;
            return (Nombre == p.Nombre) && (Edad == p.Edad);
        }
    }
}
