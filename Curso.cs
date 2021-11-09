using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Curso_Alumnos_Profs___Clase_15
{
    class Curso
    {            
        public string NombreCurso = "";
        public Profesor Profe;
        public short CantidadMaxAlumnos = 0;
        public List<Alumno> ListadoAlumnosCurso;

        public Curso()
        {
            
        }
        public Curso(string nomCurso, Profesor profesor, short cantMaxAlum)
        {
            NombreCurso = nomCurso;
            Profe = profesor;
            CantidadMaxAlumnos = cantMaxAlum;
            ListadoAlumnosCurso = new();
        }
        public void InscribirAlumno(Alumno alumno)
        {
            ListadoAlumnosCurso.Add(alumno);
        }

        public void ListarAlumnos()
        {
            foreach (Alumno alumno in ListadoAlumnosCurso)
            {
                Console.WriteLine($"{alumno.Apellido.PadLeft(alumno.Apellido.Length + 8)}, {alumno.Nombre}");
            }
        }

    }
}
