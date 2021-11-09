using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Curso_Alumnos_Profs___Clase_15
{
    class Alumno : Persona
    {
        // le cambié el tipo de dato (bool por string) cuando agregué el método Trabaja(),
        // así no imprimía "true/false"
        public string TieneTrabajo = "";


        public Alumno()
        {

        }
        public Alumno(int dni, string nom, string ape, int anio, int mes, int dia, bool trabaja)
        {
            DNI = dni;
            Nombre = nom;
            Apellido = ape;
            FechaNacimiento = new(anio, mes, dia);
            TieneTrabajo = Trabaja(trabaja);
        }

        private string Trabaja(bool trabaja)
        {
            if (trabaja)
            {
                return "Sí";
            }
            else
            {
                return "No";
            }
        }
    }
}
