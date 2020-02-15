using System;
using System.IO;

namespace Tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            Comandos aa = new Comandos();
            string haux = "";
            string aux = "";
            string aux2 = "";
            //string[] linea3;
            int k;
            aa.Iniciar();
            aa.Prompt();
            string linea = Console.ReadLine();
            linea = linea.ToLower();
            string[] linea2 = linea.Split(" ");
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
            else
            {
                linea2 = linea.Split(" ");
            }
            int n = 0;
            for (int m = 0; m < linea2.Length; m++)
            {
                if (!(linea2[m] == "" || linea2[m] == " "))
                {
                    n++;
                }
            }
            string[] linea3 = new string[n];
            n = 0;
            for (int m = 0; m < linea2.Length; m++)
            {
                if (!(linea2[m] == "" || linea2[m] == " "))
                {
                    linea3[n] = linea2[m];
                    n++;
                }
            }
            //Console.WriteLine(linea3.Length);
            int i = 0;
            while (linea3[0] != "exit")
            {
                if(i==0) { i++; }
                else
                {
                    Console.WriteLine();
                    aa.Prompt();
                    linea = Console.ReadLine();
                    linea = linea.ToLower();
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
                    else
                    {
                        linea2 = linea.Split(" ");
                    }
                    int c = 0;
                    for (int m = 0; m < linea2.Length; m++)
                    {
                        if (!(linea2[m] == "" || linea2[m] == " "))
                        {
                            c++;
                        }
                    }
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
                    //Console.WriteLine(linea3.Length);
                }
                if (linea3[0] == "dir")
                {
                    if (linea3.Length == 1)
                    {
                        aa.Comando = "dir";
                        aa.Argumento = aa.Ruta;
                        aa.ListarContenido();
                        haux = haux + "\n" + linea;
                    }
                    else if(linea3.Length == 2)
                    {
                        aa.Comando = "dir";
                        aa.Argumento = linea3[1];
                        aa.ListarContenido();
                        haux = haux + "\n" + linea;
                    }
                    else
                    {
                        Console.WriteLine("Argumentos Invalidos");
                        haux = haux + "\n" + linea;
                    }
                }
                else if (linea3[0] == "cls")
                {
                    if (linea3.Length < 2)
                    {
                        aa.Limpiar();
                        haux = haux + "\n" + linea;
                    }
                    else
                    {
                        Console.WriteLine("Argumentos Invalidos");
                        haux = haux + "\n" + linea;
                    }
                }
                else if (linea3[0] == "history")
                {
                    if (linea3.Length < 2)
                    {
                        aa.Historial = haux;
                        aa.MostrarHistorial();
                        haux = haux + "\n" + linea;
                    }
                    else
                    {
                        Console.WriteLine("Argumentos Invalidos");
                        haux = haux + "\n" + linea;
                    }
                }
                else if (linea3[0] == "cd" || linea3[0] == "cd..")
                {
                    if (linea3.Length > 1)
                    {
                        aa.Comando = linea3[0];
                        aa.Argumento = linea3[1];
                        aa.CambiarDirectorio();
                        haux = haux + "\n" + linea;
                    }
                    else if(linea3.Length == 1 && linea3[0].Contains(".."))
                    {
                        aa.Comando = "cd";
                        aa.Argumento = "..";
                        aa.CambiarDirectorio();
                        haux = haux + "\n" + linea;
                    }
                    else if(linea3.Length > 2)
                    {
                        Console.WriteLine("Argumentos Invalidos");
                        haux = haux + "\n" + linea;
                    }
                    else
                    {
                        Console.WriteLine("Faltan Argumentos");
                        haux = haux + "\n" + linea;
                    }

                }
                else if (linea3[0] == "touch")
                {
                    if (linea3.Length == 2)
                    {
                        aa.Comando = linea3[0];
                        aa.Argumento = linea3[1];
                        aa.CrearArchivo();
                        haux = haux + "\n" + linea;
                    }
                    else if(linea3.Length > 2)
                    {
                        Console.WriteLine("Argumentos Invalidos");
                        haux = haux + "\n" + linea;
                    }
                    else
                    {
                        Console.WriteLine("Faltan Argumentos");
                        haux = haux + "\n" + linea;
                    }

                }
                else if (linea3[0] == "exit")
                {
                    if (linea3.Length < 2)
                    {
                        aa.Salir();
                        haux = haux + "\n" + linea;
                    }
                    else
                    {
                        Console.WriteLine("Argumentos Invalidos");
                        haux = haux + "\n" + linea;
                        Console.WriteLine();
                    }
                }
                else if (linea3[0] == "move")
                {
                    if (linea3.Length == 3)
                    {
                        aa.Comando = linea3[0];
                        aa.Argumento = linea3[1];
                        aa.Argumento2 = linea3[2];
                        haux = haux + "\n" + linea;
                        aa.MoverArchivo();
                    }
                    else if(linea3.Length < 3)
                    {
                        Console.WriteLine("Faltan Argumentos");
                        haux = haux + "\n" + linea;
                    }
                    else
                    {
                        Console.WriteLine("Argumentos Invalidos");
                        haux = haux + "\n" + linea;
                    }
                }
                else
                {
                    if(linea3[0].Contains("move ")) 
                    {
                        Console.WriteLine("Los argumentos deben llevar el mismo formato");
                        Console.WriteLine("Las dos rutas deben de llevar comillas(\") o sin comillas");
                    }
                    Console.WriteLine("No se reconoce: {0}", linea3[0]);
                    haux = haux + "\n" + linea;
                }
            }
        }
    }
}
