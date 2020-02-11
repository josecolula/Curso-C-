using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio7
{
    //Clase NumerosComplejos
    class NumeroComplejo
    {
        //Atributos de la clase NumerosComplejos
        //Parte Real
        double p_r = 0.0;
        //Parte Imaginaria
        double p_i = 0.0;
        //Método para get y set del atributo p_r
        public double parteReal
        {
            get { return p_r; }
            set { p_r = value; }
        }
        //Método para get y set del atributo p_i
        public double parteImaginaria
        {
            get { return p_i; }
            set { p_i = value; }
        }
        //Método para imprimir en formato el número complejo
        public void Imprimir()
        {
            
            if(p_i > 0)
            {
                //Formato si la parte imaginaria es positiva
                Console.WriteLine("{0}+{1}i",p_r,p_i);
            }
            else
            {
                //Formato si la parte imaginaria es negativa
                Console.WriteLine("{0}{1}i",p_r,p_i);
            }
            
        }
        //Método Constructor con Sobrecargo
        public NumeroComplejo(double p_r, double p_i)
        {
            this.p_r = p_r;
            this.p_i = p_i;
        }
        //Método constructor
        public NumeroComplejo() { }
    }
}
