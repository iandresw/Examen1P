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

        public double CalcularNotaFinal(int n1, int n2, int n3);

        public string MensajeNotaFinal(double NotaFinal);

        public void Imprimir();
    }
}
