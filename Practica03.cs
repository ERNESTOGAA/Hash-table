using System;
using System.Collections;
namespace Practica_03
{
    public class Alumno
    {
        private Hashtable BdAlumnos=new Hashtable();
        private string NombreAlumno;
        private string CodigoAlumno;
  
        public Alumno()
        {

        }

        public void practicaHashtableAlumnos()
        {
           
            this.alta1();
            this.alta2();
            this.editar();
            this.imprimir();
            this.eliminar();
            this.imprimir();
            Console.ReadKey(true);
        }

        private void alta1()
        {
            Console.Write("Ingrese Nombre Del Alumno: ");
            NombreAlumno = Console.ReadLine();
            
            Console.Write("Ingresa Codigo Del Alumno: ");
            CodigoAlumno = Console.ReadLine();
            try
            {
                BdAlumnos.Add(CodigoAlumno, NombreAlumno);
            }
            catch
            {
                Console.Write("\nCodigo de alumno repetido\nUltimo NO!! Registrado\n");
            }
            
        }
         private void alta2()
        {
            Console.Write("Ingrese Nombre Del Alumno: ");
            NombreAlumno = Console.ReadLine();
            
            Console.Write("Ingresa Codigo Del Alumno: ");
            CodigoAlumno = Console.ReadLine();
            try
            {
                BdAlumnos.Add(CodigoAlumno, NombreAlumno);
            }
            catch
            {
                Console.Write("\nCodigo de alumno repetido\nUltimo NO!! Registrado\n");
            }
            
        }
        
        
        private void editar()
        {
            Console.Write("Codigo Del Alumno Que Desea Editar: ");
            CodigoAlumno = Console.ReadLine();
            if (BdAlumnos.Contains(CodigoAlumno))
            {
                Console.Write("Coloque nuevo nombre: ");
                NombreAlumno = Console.ReadLine();
                
                BdAlumnos[CodigoAlumno] = NombreAlumno;
                Console.WriteLine("Codigo " + CodigoAlumno + " Se ha Editado");
            }
            else
            {
                Console.Write("\nNo Encontrado\n");
            }
        }
        private void eliminar()
        {
            Console.Write("\nCodigo Del Alumno Que Desea Eliminar");
            CodigoAlumno = Console.ReadLine();
            if (BdAlumnos.ContainsKey(CodigoAlumno))
            {
                Console.WriteLine("Codigo "+CodigoAlumno+" Eliminado");
            }
            else
            {
                Console.Write("Codigo " + CodigoAlumno + " No se ha encontrado");
            }
            BdAlumnos.Remove(CodigoAlumno);
        }
        private void imprimir()
        {
            Console.WriteLine("\n   Clave    Nombre");
            foreach (DictionaryEntry Bd in BdAlumnos)
                Console.WriteLine("    {0}:    {1}", Bd.Key, Bd.Value);
        }

    }
}
