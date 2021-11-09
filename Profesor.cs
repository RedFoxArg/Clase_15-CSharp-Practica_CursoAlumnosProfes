using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Curso_Alumnos_Profs___Clase_15
{
    class Profesor : Persona
    {
        public short AniosExperiencia;
        public Profesor()
        {

        }
        public Profesor(int dni, string nom, string ape, int anio, int mes, int dia, short antig)
        {
            DNI = dni;
            Nombre = nom;
            Apellido = ape;
            FechaNacimiento = new(anio, mes, dia);
            AniosExperiencia = antig;
        }
    }

}
