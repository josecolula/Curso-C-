using System;
using System.IO;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //crear una instancia de StreamReader para leer un archivo         
                StreamReader fichero = new StreamReader(@"prueba.txt"); 
                StreamWriter fichero2; //Clase que representa un fichero
                //Creación del fichero de modificación
                fichero2 = File.CreateText("modificacion.txt");
                string linea;
                //Ciclo de lectura de lineas, linea por linea
                do
                {
                    //Asignacion de cadena de una linea, del fichero
                    linea = fichero.ReadLine();
                    //Convertir el número leido del archivo, en entero
                    int cambio = Convert.ToInt32(linea);
                    //Si es multiplo de 3 y multiplo de 5, escribir FizzBuzz
                    if (((cambio % 3) == 0) && ((cambio % 5) == 0))
                    {
                        //Escribe en el archivo "modificación.txt" FizzBuzz
                        fichero2.WriteLine("{0} - FizzBuzz", cambio);
                    }
                    //Si es múltiplo de 3, escribir Fizz
                    else if ((cambio % 3) == 0)
                    {
                        //Escribe en el archivo "modificación.txt" Fizz
                        fichero2.WriteLine("{0} - Fizz", cambio);
                    }
                    //Si es múltiplo de 5, escribir Buzz
                    else if ((cambio % 5) == 0)
                    {
                        //Escribe en el archivo "modificación.txt" Buzz
                        fichero2.WriteLine("{0} - Buzz", cambio);
                    }
                    else
                    {
                        //Escribe en el archivo el número
                        fichero2.WriteLine("{0}", cambio);
                    }
                //Mientras la linea no sea nula
                } while (linea != null);
                //Cerrar los archivos
                fichero2.Close();
                fichero.Close();
                Console.WriteLine("Ejercicio FizzBuzz\nLectura de numeros del archivo: prueba.txt\nResultado guardado en archivo: modificacion.txt");
            }
            //Excepxción si el aruta del archivo es muy larga
            catch (PathTooLongException exp)
            {
                Console.WriteLine("Ruta demasiado larga.\n" + exp.Message);
                return;
            }
            //Excepción sino se pudo escribir en el archivo.
            catch (IOException exp)
            {
                Console.WriteLine("No se pudo escribir.\n" + exp.Message);
                return;
            }
            //Otras excepciones.
            catch (Exception exp)
            {
                
                Console.WriteLine(exp.Message);
                return;
            }


            Console.ReadLine();

        }
        
    }
}
