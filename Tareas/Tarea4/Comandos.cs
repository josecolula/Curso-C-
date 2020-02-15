using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Tarea4
{
    class Comandos : AdministradorArchivo
    {
        string comando;
        string argumento;
        string argumento2;
        string history;
        static int i;
        public string Argumento
        {
            get { return argumento; }
            set { argumento = value; }
        }
        public string Comando
        {
            get { return comando; }
            set { comando = value; }
        }
        public string Historial
        {
            get { return history; }
            set { history = value; }
        }
        public string Argumento2
        {
            get { return argumento2; }
            set { argumento2 = value; }
        }
        public void ListarContenido()
        {
            //this.comando = comando;
            string aux2 = "";
            //string aux3 = "";
            int j = Argumento.Length;
            //Console.WriteLine(Argumento[j - 1]);
            try
            {
                if (Argumento[j - 1] == '\\')
                {
                    aux2 = Argumento.Substring(0, j - 1);
                    Argumento = aux2;
                }
                if (Argumento == "c:")
                {
                    Argumento = Argumento + "\\";
                }

                if (!Argumento.Contains("\\") && Argumento != Ruta)
                {
                    Argumento = Ruta + "\\" + Argumento;
                }
                //Console.WriteLine(Argumento);
                if (Directory.Exists(Argumento))
                {
                    var files = Directory.EnumerateFiles(Argumento, "*");
                    var directorys = Directory.EnumerateDirectories(Argumento, "*");
                    foreach (string directory in directorys)
                    {
                        if (Argumento == "c:\\")
                        {
                            string directoryName = directory.Substring(Argumento.Length);
                            Console.WriteLine(directoryName);
                        }
                        else
                        {
                            string directoryName = directory.Substring(Argumento.Length + 1);
                            Console.WriteLine(directoryName);
                        }
                    }
                    foreach (string file in files)
                    {
                        if (Argumento == "c:\\")
                        {
                            string fileName = file.Substring(Argumento.Length);
                            Console.WriteLine(fileName);
                        }
                        else
                        {
                            string fileName = file.Substring(Argumento.Length + 1);
                            Console.WriteLine(fileName);
                        }

                    }
                }
                else
                {
                    Console.WriteLine("El sistema no puede encontrar la ruta especificada");
                }
            }
            catch(IndexOutOfRangeException ie)
            {
                Console.WriteLine("Escpacios Invalidos");
            }

 
        }
        public void Limpiar()
        {
            Console.Clear();
        }
        public void Salir()
        {
            Environment.Exit(1);
        }
        public void MostrarHistorial()
        {
            Console.WriteLine(history);

        }
        public void CambiarDirectorio()
        {
            if (Argumento == "..")
            {
                string[] aux  = Ruta.Split(@"\");
                string aux2 = "";
                for(int i=0;i<aux.Length-1; i++)
                {
                    if(aux.Length-1 == 1)
                    {
                        aux2 = aux[i] + "\\";
                    }
                    else
                    {
                        if (i == 0)
                        {
                            aux2 = aux2 + aux[i];
                        }
                        else
                        {
                            aux2 = aux2 + "\\" + aux[i];
                        }
                    }

                }
                Ruta = aux2;

            }
            else
            {
                string aux2 = "";
                int j = Argumento.Length;
                //Console.WriteLine(Argumento[j - 1]);
                if (Argumento[j - 1] == '\\')
                {
                    aux2 = Argumento.Substring(0, j - 1);
                    Argumento = aux2;
                }
                if (Argumento == "c:")
                {
                    Argumento = Argumento + "\\";
                }
                if (!Argumento.Contains("\\") && Argumento != Ruta)
                {
                    Argumento = Ruta + "\\" + Argumento;
                }
                if (Directory.Exists(Argumento))
                {
                    Ruta = Argumento;
                }
                else
                {
                    Console.WriteLine("El sistema no puede encontrar la ruta especificada");
                }
            }
        }
        public void CrearArchivo()
        {
            if (!Argumento.Contains("\\") && Argumento != Ruta)
            {
                Argumento = Ruta + "\\" + Argumento;
            }
            //Console.WriteLine(Argumento);
            if(!File.Exists(Argumento))
            {
                try
                {
                    using (StreamWriter sw = File.CreateText(Argumento)) ;
                }
                catch(IOException io)
                {
                    Console.WriteLine("Nombre del archivo o la ruta no son correctas");
                }
                catch(UnauthorizedAccessException ua)
                {
                    Console.WriteLine("Nombre del archivo o la ruta no son correctas");
                }
            }
            else
            {
                Console.WriteLine("Archivo ya existe");
            }

        }
        public void MoverArchivo()
        {
            string copy = "";
            string arg = Argumento;
            if (!(Argumento2[Argumento2.Length - 1] == '\\'))
            {
                if (Argumento.Contains("\\"))
                {
                    string[] name = Argumento.Split("\\");
                    arg = name[name.Length - 1];
                }
                copy = Argumento2 + "\\" + arg;
            }
            else
            {
                if (Argumento.Contains("\\"))
                {
                    arg = Argumento.Substring(Ruta.Length + 1);
                }
                copy = Argumento2 + arg;
            }

            if (!Argumento.Contains("\\") && Argumento != Ruta)
            {
                Argumento = Ruta + "\\" + Argumento;
            }

            //Console.WriteLine(Argumento);
            //Console.WriteLine(Argumento2);
            if(File.Exists(Argumento) && Directory.Exists(Argumento2))
            {
                try
                {
                    if (!File.Exists(copy))
                    {
                        File.Copy(Argumento, copy);
                        File.Delete(Argumento);
                    }
                    else
                    {
                        Console.WriteLine("Existe un archivo igual en la directorio destino");
                    }
                }
                catch (UnauthorizedAccessException ua)
                {
                    Console.WriteLine("No cuentas con los privilegios para editar el directorio");
                }

            }
            else
            {
                Console.WriteLine("Nombre del archivo o la ruta no son correctas");
            }
        }
    }
}
