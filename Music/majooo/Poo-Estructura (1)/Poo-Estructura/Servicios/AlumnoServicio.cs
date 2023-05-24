using Poo_Estructura.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Estructura.Servicios
{
    public class AlumnoServicio
    {
        public Alumno Agregar()
        {
            try
            {
                Alumno alumno = new Alumno()
                {
                    Id = 1,
                    Nombre = "Beto Estrada",
                    Apellido = "Canto",
                    FechaIngreso = DateTime.Now,
                    Grado = 23,
                    Promedio = 5
                   
                };
                return alumno;
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);

            }



        }
        public void Imprimir(Alumno request)
        {
            try
            {
                Console.WriteLine("El ID del alumno es de: " + request.Id);
                Console.WriteLine("El nombre es: " + request.Nombre);
                Console.WriteLine("El Apellido es: " + request.Apellido);
                Console.WriteLine("La fecha de ingreso es de: " + request.FechaIngreso);
                Console.WriteLine("El grado que cursa es: " + request.Grado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);

            }
        }

        #region----- Validar Aprobacion 
        public bool ValidarProm(double num1)
        {
            bool validar = false;

            if(num1 > 7)
            {
                validar = true; 
            }
            return validar;
        }
        #endregion
    }
}

