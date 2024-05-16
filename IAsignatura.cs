using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1P
{
    public interface IAsignatura
    {
        public double CalcularNotaFinal();

        public double CalcularNotaFinal(double n1, double n2, double n3);

        public string MensajeNotaFinal(double NotaFinal);
    }
}
