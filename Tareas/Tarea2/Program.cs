using System;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {

            Alumno a = new Alumno();
            Console.WriteLine(a.ToString());
            Console.WriteLine();
            Console.WriteLine("Ingresa el número de alumnos a calificar: ");
            int tam = Convert.ToInt32(Console.ReadLine());
            Alumno[] alumnos = new Alumno[tam];
            Console.WriteLine();
            for(int i=0; i<alumnos.Length; i++)
            {
                Alumno objalum = new Alumno();
                Console.WriteLine("Datos del alumno {0}", i + 1);
                Console.WriteLine("Nombre: ");
                objalum.Nombre = Console.ReadLine();
                //alumnos[i].Nombre = objalum.Nombre;
                Console.WriteLine("Apellido Paterno: ");
                objalum.ApellidoPaterno = Console.ReadLine();
                //alumnos[i].ApellidoPaterno = objalum.ApellidoPaterno;
                Console.WriteLine("Apellido Materno: ");
                objalum.ApellidoMaterno = Console.ReadLine();
                //alumnos[i].ApellidoMaterno = objalum.ApellidoMaterno;
                Console.WriteLine("Calificación del Proyecto: ");
                objalum.CalificacionProyecto = Convert.ToInt32(Console.ReadLine());
                //alumnos[i].CalificacionProyecto = objalum.CalificacionProyecto;
                Console.WriteLine("Cantidad de Tareas: ");
                objalum.CantidadTareas = Convert.ToInt32(Console.ReadLine());
                //alumnos[i].CantidadTareas = objalum.CantidadTareas;
                Console.WriteLine("Cantidad de Participaciones: ");
                objalum.CantidadParticipaciones = Convert.ToInt32(Console.ReadLine());
                //alumnos[i].CantidadParticipaciones = objalum.CantidadParticipaciones;
                objalum.CalificacionFinal = 50;
                //alumnos[i].CalificacionFinal = objalum.CalificacionFinal;
                alumnos[i] = objalum;
                Console.WriteLine();
            }
            Calculadora(alumnos);
            Console.ReadKey();
        }
        static void Calculadora(Alumno[] alumnos)
        {
            int calificacion_f = 0;
            int tareas=0;
            int i = 0;
            for(int k=0; k < alumnos.Length; k++)
            {
                calificacion_f = 0;
                tareas = 0;
                calificacion_f = (alumnos[k].CalificacionProyecto * 6);
                for( int j=0; j< alumnos[k].CantidadTareas; j++)
                {
                    tareas = tareas + 10;
                }
                calificacion_f = calificacion_f + ((tareas / 5) * 4);
                if(alumnos[k].CantidadParticipaciones > 5)
                {
                    calificacion_f = calificacion_f + 8;
                }

                alumnos[k].CalificacionFinal = calificacion_f; 
            }
            foreach(Alumno objalu3 in alumnos)
            {
                Console.WriteLine("La calificación final de " + objalu3.Nombre +" "+ objalu3.ApellidoPaterno+" "+objalu3.ApellidoMaterno+" es de: " + objalu3.CalificacionFinal+"/100");

            }
        }
    }
}
