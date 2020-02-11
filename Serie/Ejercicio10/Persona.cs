using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio10
{
    //Clase Persona
    class Persona
    {
        //Atributos de la clase Persona
        string nombre;
        int edad;
        double estatura;
        double peso;
        //Métodos get y set para cada uno de los atributos
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set
            {
                //Validación que la edad no se menor o igual que 0
                if(value <= 0)
                {
                    Console.WriteLine("Edad no valida");
                }
                else
                {
                    //Asiganción del valor ingresado a el atrbuto de la clase
                    edad = value;
                }
            }
        }
        public double Estatura
        {
            get { return estatura; }
            set
            {
                //Validación que la edad no se menor o igual que 0
                if (value <= 0)
                {
                    Console.WriteLine("Estatura no valida");
                }
                else
                {
                    //Asignación del valor ingresado a el atrbuto de la clase
                    estatura = value;
                }
            }
        }
        public double Peso
        {
            get { return peso; }
            set
            {
                //Validación que la edad no se menor o igual que 0
                if (value <= 0)
                {
                    Console.WriteLine("Peso no valido");
                }
                else
                {
                    //Asignación del valor ingresado a el atrbuto de la clase
                    peso = value;
                }
            }
        }
        //Método para mostrar información de la persona
        public override string ToString()
        {
            return string.Format("{0} tiene {1} años, mide {2} metros y pesa {3} Kg", nombre, edad, estatura, peso);
        }
        //Métdo que calcula los años que tiene
        public void Envejecer()
        {
            Console.WriteLine("Ingresa los años que has crecido: ");
            int años = Convert.ToInt32(Console.ReadLine());
            //Operacón que calcula tu edad dependiendo de los años que ha pasado
            edad = edad + años;
            Console.WriteLine("Edad Actual: " + edad);

        }
        //Método que calcula tu estatura dependiendo que cuanto has crecido
        public void CambiarEstatura()
        {
            Console.WriteLine("Ingresa los estatura que has crecido: ");
            Console.WriteLine("Si ha disminuido de estatura enteponga un signo de - a la cantidad que pondra");
            //Operación de suma de estatura
            double cambia_est = Convert.ToDouble(Console.ReadLine());
            estatura = estatura + cambia_est;
            Console.WriteLine("Estatura Actual: " + estatura);
        }
        //Método para calcular el peso actual
        public void CambiarPeso()
        {
            Console.WriteLine("Ingresa el peso que has aumentado: ");
            Console.WriteLine("Si ha disminuido de peso enteponga un signo de - a la cantidad que pondra");
            //Operación que suma el peso.
            double cambia_peso = Convert.ToDouble(Console.ReadLine());
            peso = peso + cambia_peso;
            Console.WriteLine("Estatura Actual: " + peso);
        }
    }
}
