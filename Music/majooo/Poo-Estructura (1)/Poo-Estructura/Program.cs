using Poo_Estructura.Entities;
using Poo_Estructura.Servicios;
using System;

namespace Poo_Estructura
{
    internal class Program
    {
        static void Main(string[] args)
            
        {


            AlumnoServicio servicio = new AlumnoServicio();

            Alumno alumno1 = servicio.Agregar();
          
            //var res = servicio.Agregar();
            servicio.Imprimir(alumno1);
            //creando una variable general 


            Console.WriteLine("la calificacion es"+servicio.ValidarProm(alumno1.Promedio));

        }
    }
}
