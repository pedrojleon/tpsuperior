using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OperadorComplejos
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            NumeroComplejoBinomico ncb = new NumeroComplejoBinomico(1, 2);
            NumeroComplejoBinomico ncb2 = new NumeroComplejoBinomico(0, -8);
            NumeroComplejoPolar ncp1 = new NumeroComplejoPolar(2.236068, 1.107148);
            NumeroComplejoPolar ncp2 = new NumeroComplejoPolar(8, -1.57);
            //abcpedroleonabcpedroleonabcpedroleonabcpedroleonabcpedroleon
            NumeroComplejoBinomico sumadobinomico = OperadorDeComplejos.Sumar(ncb, ncb2);
            NumeroComplejoPolar sumadopolar = OperadorDeComplejos.Sumar(ncp1, ncp2);

            string str_sumadobinomico = sumadobinomico.ObtenerBinomica();

            NumeroComplejoBinomico polarabinomico = OperadorDeComplejos.PolarABinomico(sumadopolar);
            string str_polarabinomico = polarabinomico.ObtenerBinomica();
            //NumeroComplejoBinomico potenciado = OperadorDeComplejos.Potencia(ncb2, 5);
            //string str_potenciado = potenciado.ObtenerBinomica();
            List<NumeroComplejoPolar> listaRaices = OperadorDeComplejos.Raiz(ncp2, 3);
            //string str_potenciado2 = OperadorDeComplejos.PolarABinomico(potenciado2).ObtenerBinomica();
        }
    }
}
