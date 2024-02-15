using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Nota : INota
    {
        public Nota() { }

        public double CalcularNotaFinal(double nota1, double nota2, double nota3)
        {
            if (nota1 > 30)
            {
                throw new ArgumentException("La nota del primer parcial excede el 30%.");
            }

            if (nota2 > 30)
            {
                throw new ArgumentException("La nota del segundo parcial excede el 30%.");
            }

            if (nota3 > 40)
            {
                throw new ArgumentException("La nota del tercer parcial excede el 40%.");
            }

            double sumaTotal = nota1 + nota2 + nota3;

            if (sumaTotal > 100)
            {
                throw new ArgumentException("La suma total de las notas excede el 100%.");
            }

            return sumaTotal;
        }

        public string MensajeNota(double notaFinal)
        {


            if(notaFinal < 0 || notaFinal > 100)
            {
                throw new ArgumentException("La nota final está fuera del rango permitido.");
            }

            if (notaFinal < 60)
            {
                return "Reprobado";
            }
            else if (notaFinal < 80)
            {
                return "Bueno";
            }
            else if (notaFinal < 90)
            {
                return "Muy Bueno";
            }
            else
            {
                return "Sobresaliente";
            }

        }
    }


    }

