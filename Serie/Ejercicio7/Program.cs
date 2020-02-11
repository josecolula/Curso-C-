using System;

namespace Ejercicio7
{
    class Program
    {
        //Método Main
        static void Main(string[] args)
        {
            //Creación de objeto de la clase NumerosComplejos (nc1,nc2)
            NumeroComplejo nc1 = new NumeroComplejo(-3.0,9.0);
            NumeroComplejo nc2 = new NumeroComplejo(7.0,-6.0);
            //Llama al método numeros complejos que se muestra en formto.
            nc1.Imprimir();
            nc2.Imprimir();
            //Impresioón del resultado
            Console.WriteLine("La suma es: ");
            //Llamar al metodo Suma que devuelve que retorna un objeto de la Clase NumeroComplejo
            Suma(nc1, nc2).Imprimir();
            Console.ReadKey();
        }
        //Método que suma dos numeros complejos
        static NumeroComplejo Suma(NumeroComplejo c1,NumeroComplejo c2)
        {
            //Creación de número complejo, de almacenamiento de resultado
            NumeroComplejo nc3 = new NumeroComplejo();
            //Suma de la parte real de los numeros complejos
            nc3.parteReal = c1.parteReal + c2.parteReal;
            //Suma de la parte imaginaria de los numeros complejos
            nc3.parteImaginaria = c1.parteImaginaria + c2.parteImaginaria;
            //Retorno del objeto resultante de la suma
            return nc3;
        }
    }
}
