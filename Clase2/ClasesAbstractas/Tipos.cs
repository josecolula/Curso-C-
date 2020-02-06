using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractas
{
    class Carnivoro : Animal
    {
        public Carnivoro(string nombre) : base(nombre) { }
        public override string Come
        {
            get { return "Come otros animales";  }
        }
        public virtual void Cazar()
        {
            Console.WriteLine("El animal esta cazando");
        }

    }
    class Herbivoro : Animal
    {
        public Herbivoro(string nombre) : base (nombre) { }

        public override string Come
        {
            get { return "Come plantas"; }
        }
        public void Recolectar()
        {
            Console.WriteLine("El animal esta recolectando su comida");
        }
    }
}
