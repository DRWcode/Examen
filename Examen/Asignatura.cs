using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Asignatura : Alumno
    {
        public string? NombreClase { get; set; }
        public string? Horario { get; set; }
        public string? Docente { get; set; }


        public override void Imprimir()
        {
            Console.WriteLine("Nombre del estudiante: " + Nombre);
            Console.WriteLine("Numero de cuenta: " + NumeroCuenta);
            Console.WriteLine("Correo electronico: " + Email);
            Console.WriteLine("-------------------");
            Console.WriteLine("Nombre de la clase: " + NombreClase);
            Console.WriteLine("Horario : " + Horario);
            Console.WriteLine("Nombre del docente: " + Docente);
            Console.WriteLine("-------------------");
        }

    }
}