using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen1P
{
    public class Asignatura : Alumno, IAsignatura
    {
        public int N1;
        public int N2;
        public int N3;
        public string NombreAsignatura { get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }

        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3 ;
        }

        public double CalcularNotaFinal(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public void Imprimir()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("/n");
            Console.WriteLine($"Nombre del Estudiante: {NombreAlumno}");
            Console.WriteLine($"Numero de Cuenta: {NumeroCuenta}");
            Console.WriteLine($"Correo Electronico: {Email}");
            Console.WriteLine($"Nombre de la clase {NombreAsignatura}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Nombre del Docente: {NombreDocente}");
            Console.WriteLine($"Nora Final: {CalcularNotaFinal()} - {MensajeNotaFinal(CalcularNotaFinal())}");
            Console.WriteLine($"Nora Final: {CalcularNotaFinal(N1, N2, N3)} - {MensajeNotaFinal(CalcularNotaFinal(N1, N2, N3))}");
            Console.WriteLine("/n");
            Console.WriteLine("**********Este es el FIN!************************");
        }

        public string MensajeNotaFinal(double NotaFinal)
        {
            string estado ;
            estado = "";
            if ((NotaFinal > 0) && (NotaFinal< 59)){
                estado = "Reprobado";
            }else if ((NotaFinal > 60 ) && (NotaFinal<79))
            {
                estado = "Bueno";
            }else if ((NotaFinal > 80) && (NotaFinal < 89))
            {
                estado = "Muy Bueno";
            }else if ((NotaFinal > 90) && (NotaFinal <= 100))
            {
                estado = "Sobresaliente";
            }
            return estado;
        }
    }
}
