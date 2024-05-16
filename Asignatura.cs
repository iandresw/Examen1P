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
        public double N1;
        public double N2;
        public double N3;
        public string NombreAsignatura{ get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }

        public double CalcularNotaFinal()
        {
            throw new NotImplementedException();
        }

        public double CalcularNotaFinal(double n1, double n2, double n3)
        {
            throw new NotImplementedException();
        }

        public void Imprimir()
        {
            throw new NotImplementedException();
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
            }else if ((NotaFinal > 90) && (NotaFinal < 100))
            {
                estado = "Sobresaliente";
            }
            return estado;
        }
    }
}
