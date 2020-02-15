using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Tarea4
{
    class AdministradorArchivo
    {
        string ruta;

        public string Ruta
        {
            get { return ruta; }
            set { ruta = value; }
        }

        public AdministradorArchivo() 
        {
        }
        public void Iniciar()
        {
            ruta = @"c:\Users\" + Environment.UserName + @"\Documents";
            ruta = ruta.ToLower();
            if(!Directory.Exists(ruta))
            {
                ruta = @"c:\Usuarios\" + Environment.UserName + @"\Documentos";
                Console.Write(ruta + "> ");
            }
                       
        }
        public void Prompt()
        {
            Console.Write(ruta + "> ");
        }



    }
}
