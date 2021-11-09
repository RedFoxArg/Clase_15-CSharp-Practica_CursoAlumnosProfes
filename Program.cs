using System;
using System.Collections.Generic;

namespace Practica_Curso_Alumnos_Profs___Clase_15
{
    class Program
    {
        static void Main(string[] args)
        {
            // CURSO 1
            Profesor profe1 = new(6154891, "Ernesto", "García", 1949, 06, 04, 30);
            
            Curso curso1 = new Curso("Administración de Personal", profe1, 10);
            
            Alumno alumno1 = new(27798053, "Javier", "García", 1980, 01, 04, true);
            curso1.InscribirAlumno(alumno1);
            Alumno alumno2 = new(30333444, "Richard", "Dawkins", 1978, 12, 05, true);
            curso1.InscribirAlumno(alumno2);
            Alumno alumno3 = new(14555666, "Peter", "Singer", 1959, 07, 07, true);
            curso1.InscribirAlumno(alumno3);
            Alumno alumno4 = new(29777888, "Edgard", "Poe", 1880, 11, 25, true);
            curso1.InscribirAlumno(alumno4);
            Alumno alumno5 = new(35999000, "Carl", "Sagan", 1940, 09, 03, true);
            curso1.InscribirAlumno(alumno5);

            // CURSO 2
            Profesor profe2 = new(6154891, "Charles", "Darwin", 1986, 11, 01, 12);

            Curso curso2 = new("Biología", profe2, 25);

            curso2.InscribirAlumno(alumno1);
            curso2.InscribirAlumno(alumno2);
            Alumno alumno6 = new(12345678, "Fox", "Molder", 1959, 04, 23, false);
            curso2.InscribirAlumno(alumno6);

            Console.WriteLine($"\r\nF I C H A  D E  P R O F E S O R\r\nNombre y apellido: {profe1.Nombre} {profe1.Apellido}.\r\nDNI: {profe1.DNI}.\r\nFecha Nac.: {profe1.FechaNacimiento:dd/MM/yyyy}\r\nExperiencia: {profe1.AniosExperiencia} años.");
            Console.WriteLine($"\r\nF I C H A  D E  A L U M N O\r\nNombre y apellido: {alumno1.Nombre} {alumno1.Apellido}.\r\nDNI: {alumno1.DNI}.\r\nFecha Nac.: {alumno1.FechaNacimiento:dd/MM/yyyy}\r\nTrabaja: {alumno1.TieneTrabajo}.");
            Console.WriteLine($"\r\nI N F O R M A C I Ó N  D E L  C U R S O\r\nCurso: {curso1.NombreCurso}.\r\nProfesor: {curso1.Profe.Nombre} {curso1.Profe.Apellido}.\r\nCupo máx.: {curso1.CantidadMaxAlumnos}.\r\nAlumnos: ");
            // foreach (Alumno alumno in curso1.ListadoAlumnosCurso){Console.WriteLine($"{alumno.Apellido}, {alumno.Nombre}.");}
            curso1.ListarAlumnos();
            Console.WriteLine($"\r\nI N F O R M A C I Ó N  D E L  C U R S O\r\nCurso: {curso2.NombreCurso}.\r\nProfesor: {curso2.Profe.Nombre} {curso2.Profe.Apellido}.\r\nCupo máx.: {curso2.CantidadMaxAlumnos}.\r\nAlumnos: ");
            curso2.ListarAlumnos();
        }
    }
}

/*
    EJERCICIOS 2

    • Se quiere modelar un curso de ComunidadIT.

    • El Curso tendrá un nombre, una cantidad máxima de alumnos, un Profesor y
      un Listado de Alumnos.

    • Tanto de un Profesor como de un Alumnos se guarda su DNI, Nombre, Apellido y
      Fecha de Nacimiento.

    • Del Profesor también se guarda la cantidad de años de Experiencia.

    • Del Alumno se especifica si tiene trabajo o no.

    • Realizar un programa que permita cargar un curso y al final muestre todo su detalle.
 */
