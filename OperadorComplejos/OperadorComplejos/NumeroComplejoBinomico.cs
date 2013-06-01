using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperadorComplejos
{
    /// <summary>
    /// Clase utilzada para representar un número complejo en forma binómica.
    /// </summary>
    public class NumeroComplejoBinomico
    {
        public const string FORMATO_PAR_ORDENADO = "({0},{1})";
        public const string FORMATO_BINOMICO = "{0} + {1} j";

        double _parteReal;
        double _parteImaginaria;

        /// <summary>
        /// Método utilizado para obtener la parte real de un número complejo.
        /// </summary>
        public double ParteReal
        {
            get { return _parteReal; }
        }
        /// <summary>
        /// Método utilizado para obtener la parte imginaria de un número complejo.
        /// </summary> 
        public double ParteImaginaria
        {
            get { return _parteImaginaria; }
        }

        /// <summary>
        /// Método utilizado para construir un número complejo binómico.
        /// </summary>
        /// <param name="parteReal">parte real del número complejo binómico</param>
        /// <param name="parteImaginaria">parte imaginaria del número complejo binómico</param>
        public NumeroComplejoBinomico(double parteReal, double parteImaginaria)
        {
            _parteReal = parteReal;
            _parteImaginaria = parteImaginaria;
        }

        /// <summary>
        /// Método utilizado para obtener el número en formato de par ordenado.
        /// </summary>
        /// <returns>número complejo binómico en formato de par ordenado.</returns>
        public string ObtenerParOrdenado()
        {
            return string.Format(FORMATO_PAR_ORDENADO, _parteReal, _parteImaginaria);
        }

        /// <summary>
        /// Método utilizado para obtener el número en formato binómico.
        /// </summary>
        /// <returns>número complejo binómico en formato binómico.</returns>        
        public string ObtenerBinomica()
        {
            string foramtoFinal = _parteImaginaria >= 0 ? FORMATO_BINOMICO : FORMATO_BINOMICO.Replace("+", "");
            return string.Format(foramtoFinal, _parteReal, _parteImaginaria);
        }

    }
}
