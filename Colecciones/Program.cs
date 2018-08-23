using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //Declaracion e inicializacion de 
            //lista de alumos
            List<Alumno> alumnos =
                new List<Alumno>();

            //Declaracion y asignacion de valores
            // de alumno1
            Alumno alumno1 =
                new Alumno();
            alumno1.Nombre = "Jose Perez";
            alumno1.Materias.Add(
                new Materia("Historia", "HST741"));
            alumno1.Materias.Add(
                new Materia("Matematicas", "MAT789"));
            alumno1.Materias.Add(
                new Materia("Civismo", "CVC753"));


            alumnos.Add(alumno1);

            foreach(Alumno elemento in alumnos)
            {
                Console.WriteLine("Nombre:" +
                    elemento.Nombre);
                foreach(Materia materia in 
                    elemento.Materias)
                {
                    Console.WriteLine("Materia: " +
                        materia.Nombre);
                }

            }
            Console.ReadLine();

        }
    }
}
