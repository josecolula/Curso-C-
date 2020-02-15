using System;
using System.IO;

namespace Tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creación de objeto de la Clase Comandos
            Comandos aa = new Comandos();
            //Variables auxiliares de filtrado.
            string haux = "";
            string aux = "";
            string aux2 = "";
            int k;
            //Llama a  los métodos para inciar el programa en la ruta;
            aa.Iniciar();
            aa.Prompt();
            //lectura de línea de comando con argumentos.
            string linea = Console.ReadLine();
            //convertir la línea a mínusculas.
            linea = linea.ToLower();
            //inicializar arreglo.
            string[] linea2 = linea.Split(" ");
            //Ciclos para filtrado y separación de comando y argumentos.
            //Validación si contiene comillas ("), posibilidad para la ruta.
            if (linea.Contains("\""))
            {
                //Separación de línea, por \
                linea2 = linea.Split("\"");
                //Obtiene el índice del último caracter, del comando
                k = linea2[0].Length;
                //Guarda el 'comando' en una variable auxiliar
                aux = linea2[0];
                //validación si el comando tiene un espacio al final
                if (aux[k - 1] == ' ')
                {
                    //Subcadena de quitando el último caracter
                    aux2 = aux.Substring(0, k - 1);
                    linea2[0] = aux2;
                }
            }
            //Si no contiene comillas (")
            else
            {
                //Separación de cadena por espacios
                linea2 = linea.Split(" ");
            }
            //Filtrado de cadena si contiene muchos espacios.
            int n = 0;
            for (int m = 0; m < linea2.Length; m++)
            {
                //Contador de cadenas vacias o espacios.
                if (!(linea2[m] == "" || linea2[m] == " "))
                {
                    n++;
                }
            }
            //Filtrado solo cuando no sea espacios ni cadenas vacias se guarda en otro arreglo.
            string[] linea3 = new string[n];
            n = 0;
            for (int m = 0; m < linea2.Length; m++)
            {
                if (!(linea2[m] == "" || linea2[m] == " "))
                {
                    //Arreglo contenedor de cadenas comndos y argumentos.
                    linea3[n] = linea2[m];
                    n++;
                }
            }            
            int i = 0;
            //Ciclo si 'comando' es diferente a 'exit'
            while (linea3[0] != "exit")
            {
                if(i==0) { i++; }
                else
                {
                    //Lectura de la línea, comandos y argumentos.
                    Console.WriteLine();
                    aa.Prompt();
                    linea = Console.ReadLine();
                    linea = linea.ToLower();
                    //Ciclos para filtrado y separación de comando y argumentos.
                    //Validación si contiene comillas ("), posibilidad para la ruta.
                    if (linea.Contains("\""))
                    {
                        linea2 = linea.Split("\"");
                        k = linea2[0].Length;
                        aux = linea2[0];
                        if (aux[k - 1] == ' ')
                        {
                            aux2 = aux.Substring(0, k - 1);
                            linea2[0] = aux2;
                        }
                    }
                    //Si no contiene comillas (").
                    else
                    {
                        linea2 = linea.Split(" ");
                    }
                    //Filtrado de cadena si contiene muchos espacios.
                    int c = 0;
                    for (int m = 0; m < linea2.Length; m++)
                    {
                        if (!(linea2[m] == "" || linea2[m] == " "))
                        {
                            c++;
                        }
                    }
                    //Filtrado solo cuando no sea espacios ni cadenas vacias se guarda en otro arreglo.
                    linea3 = new string[c];
                    c = 0;
                    for (int m = 0; m < linea2.Length; m++)
                    {
                        if (!(linea2[m] == "" || linea2[m] == " "))
                        {
                            linea3[c] = linea2[m];
                            c++;
                        }
                    }
                }
                //Validaciones para cada uno de los comandos.
                //Si el primer elemento del arreglo es igual a dir.
                if (linea3[0] == "dir")
                {
                    //Si no contiene argumentos.
                    if (linea3.Length == 1)
                    {
                        //Pasar elementos del arreglo, a los atributos de la clase.
                        aa.Comando = linea3[0];
                        aa.Argumento = aa.Ruta;
                        //Lama al método ListarContenido de la Clase Comandos.
                        aa.ListarContenido();
                        //Guardar línea en el arreglo
                        haux = haux + "\n" + linea;
                    }
                    //Si contiene argumentos.
                    else if(linea3.Length == 2)
                    {
                        //Pasar elementos del arreglo, a los atributos de la clase.
                        aa.Comando = linea3[0];
                        aa.Argumento = linea3[1];
                        //Lama al método ListarContenido de la Clase Comandos.
                        aa.ListarContenido();
                        //Guardar línea en el arreglo
                        haux = haux + "\n" + linea;
                    }
                    //Si no tiene los argumentos elementos validos.
                    else
                    {
                        Console.WriteLine("Argumentos Invalidos");
                        haux = haux + "\n" + linea;
                    }
                }
                //Si el primer elemento es igual a "cls".
                else if (linea3[0] == "cls")
                {
                    //Si el número de elementos es menor a 2
                    if (linea3.Length < 2)
                    {
                        //Llama al método limpiar.
                        aa.Limpiar();
                        haux = haux + "\n" + linea;
                    }
                    //Si el número de elementos no es menor a 2
                    else
                    {
                        Console.WriteLine("Argumentos Invalidos");
                        haux = haux + "\n" + linea;
                    }
                }
                //Si el primer elemento es igual a "history".
                else if (linea3[0] == "history")
                {
                    //Si no contiene argumentos.
                    if (linea3.Length < 2)
                    {
                        aa.Historial = haux;
                        //Llama al método MostrarHistorial.
                        aa.MostrarHistorial();
                        haux = haux + "\n" + linea;
                    }
                    //Si el número de elementos no es menor a 2
                    else
                    {
                        Console.WriteLine("Argumentos Invalidos");
                        haux = haux + "\n" + linea;
                    }
                }
                //Si el primer elemento es igual a "cd" o "cd.."(comando).
                else if (linea3[0] == "cd" || linea3[0] == "cd..")
                {
                    //Si contiene argumentos
                    if (linea3.Length > 1)
                    {
                        aa.Comando = linea3[0];
                        aa.Argumento = linea3[1];
                        //Llama al método CambiarDirectorio.
                        aa.CambiarDirectorio();
                        haux = haux + "\n" + linea;
                    }
                    //Si es igual a "cd.."
                    else if(linea3.Length == 1 && linea3[0].Contains(".."))
                    {
                        aa.Comando = "cd";
                        aa.Argumento = "..";
                        aa.CambiarDirectorio();
                        haux = haux + "\n" + linea;
                    }
                    //Si tiene demasiados argumentos.
                    else if(linea3.Length > 2)
                    {
                        Console.WriteLine("Argumentos Invalidos");
                        haux = haux + "\n" + linea;
                    }
                    //Si falta argumento.
                    else
                    {
                        Console.WriteLine("Faltan Argumentos");
                        haux = haux + "\n" + linea;
                    }

                }
                //Si el primer elemento es igual a "touch".
                else if (linea3[0] == "touch")
                {
                    //Si contiene argumento.
                    if (linea3.Length == 2)
                    {
                        aa.Comando = linea3[0];
                        aa.Argumento = linea3[1];
                        aa.CrearArchivo();
                        haux = haux + "\n" + linea;
                    }
                    //Si contiene demasiados arfumentos.
                    else if(linea3.Length > 2)
                    {
                        Console.WriteLine("Argumentos Invalidos");
                        haux = haux + "\n" + linea;
                    }
                    //Si falta argumento.
                    else
                    {
                        Console.WriteLine("Faltan Argumentos");
                        haux = haux + "\n" + linea;
                    }

                }
                //Si el primer elemento es igual a "salir" (comando).
                else if (linea3[0] == "exit")
                {
                    //Si no contiene argumentos.
                    if (linea3.Length < 2)
                    {
                        aa.Salir();
                        haux = haux + "\n" + linea;
                    }
                    //Si contiene algún argumento.
                    else
                    {
                        Console.WriteLine("Argumentos Invalidos");
                        haux = haux + "\n" + linea;
                        Console.WriteLine();
                    }
                }
                //Si el primer elemento es igual a "move" (comando).
                else if (linea3[0] == "move")
                {
                    //Si contiene dos argumentos.
                    if (linea3.Length == 3)
                    {
                        aa.Comando = linea3[0];
                        aa.Argumento = linea3[1];
                        aa.Argumento2 = linea3[2];
                        haux = haux + "\n" + linea;
                        aa.MoverArchivo();
                    }
                    //Si contiene menos de 2 argumentos.
                    else if(linea3.Length < 3)
                    {
                        Console.WriteLine("Faltan Argumentos");
                        haux = haux + "\n" + linea;
                    }
                    //Si contiene más de 2 argumentos.
                    else
                    {
                        Console.WriteLine("Argumentos Invalidos");
                        haux = haux + "\n" + linea;
                    }
                }
                //Si no es igual a ninguno de las cadenas validadas(comandos).
                else
                {
                    //Si el elemento contiene "move "
                    //caso cuando nose agregan comillas a los dos argumentos.
                    if(linea3[0].Contains("move ")) 
                    {
                        Console.WriteLine("Los argumentos deben llevar el mismo formato");
                        Console.WriteLine("Las dos rutas deben de llevar comillas(\") o sin comillas");
                    }
                    //Si el primer elemento no es igual a ninguna validación anterior.
                    else
                    {
                        Console.WriteLine("No se reconoce: {0}", linea3[0]);
                        haux = haux + "\n" + linea;
                    }

                }
            }
        }
    }
}
