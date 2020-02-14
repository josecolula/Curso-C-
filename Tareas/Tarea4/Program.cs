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
            string[] linea3;
            int k;
            aa.Iniciar();
            aa.Prompt();
            string linea = Console.ReadLine();
            linea.ToLower();
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
            linea3 = linea.Split(" ");
            //Console.WriteLine(linea2[0]);
            //Console.WriteLine(linea2[1]);
            int n = 0;
            for (int m = 0; m < linea2.Length; m++)
            {
                if (!(linea2[m] == ""))
                {
                    linea3[n] = linea2[m];
                    n++;
                }
            }
            int i = 0;
            while (linea3[0] != "exit")
            {
                if(i==0) { i++; }
                else
                {
                    Console.WriteLine();
                    aa.Prompt();
                    linea = Console.ReadLine();
                    linea.ToLower();
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
                        if (!(linea2[m] == ""))
                        {
                            linea3[c] = linea2[m];
                            c++;
                        }
                    }
                }
                if (linea2.Length < 3 || ((linea2.Length == 3) && (linea2[2] == "")))
                {
                    if(linea2[0] == "dir")
                    {
                        if(linea2.Length < 2 || linea2[1] == "")
                        {
                            aa.Comando = "dir";
                            aa.Argumento = aa.Ruta;
                            aa.ListarContenido();
                            haux = haux + "\n" + linea;
                        }
                        else
                        {
                            aa.Comando = "dir";
                            aa.Argumento = linea2[1];
                            aa.ListarContenido();
                            haux = haux + "\n" + linea;
                        }
                    }
                    else if(linea2[0] == "cls")
                    {
                        if(linea2.Length < 2)
                        {
                            aa.Limpiar();
                            haux = haux + "\n" + linea;
                        }
                        else
                        {
                            Console.WriteLine("Argumentos Invalidos");
                        }
                    }
                    else if (linea2[0] == "history")
                    {
                        if (linea2.Length < 2)
                        {
                            aa.Historial = haux;
                            aa.MostrarHistorial();
                            haux = haux + "\n" + linea;
                        }
                        else
                        {
                            Console.WriteLine("Argumentos Invalidos");
                        }
                    }
                    else if(linea2[0] == "cd")
                    {
                        if(linea2.Length > 1)
                        {
                            aa.Comando = linea2[0];
                            aa.Argumento = linea2[1];
                            aa.CambiarDirectorio();
                            haux = haux + "\n" + linea;
                        }
                        else
                        {
                            Console.WriteLine("Faltan argumentos");
                        }

                    }
                    else if(linea2[0] == "touch")
                    {
                        if (linea2.Length > 1)
                        {
                            aa.Comando = linea2[0];
                            aa.Argumento = linea2[1];
                            aa.CrearArchivo();
                            haux = haux + "\n" + linea;
                        }
                        else
                        {
                            Console.WriteLine("Faltan argumentos");
                        }

                    }
                    else if (linea2[0] == "exit")
                    {
                        if (linea2.Length < 2)
                        {
                            aa.Salir();
                        }
                        else
                        {
                            Console.WriteLine("Argumentos Invalidos");
                            Console.WriteLine();
                        }
                    }
                    else if(linea2[0] == "move")
                    {
                        Console.WriteLine("Faltan Argumentos");
                    }
                    else
                    {
                        Console.WriteLine("No se reconoce: {0}", linea2[0]);
                    }
                }
                else if(linea2.Length == 3)
                {
                    if(linea2[0] == "move")
                    {
                        aa.Argumento = linea2[1];
                        aa.Argumento2 = linea2[2];
                        aa.MoverArchivo();

                    }
                }
            }
        }
    }
}
