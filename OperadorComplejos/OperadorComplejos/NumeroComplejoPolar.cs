using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperadorComplejos
{
    /// <summary>
    /// Clase utilzada para representar un número complejo en forma polar.
    /// </summary>
    public class NumeroComplejoPolar
    {
        public const string FORMATO_POLAR = "[{0};{1}π]";
        public const string FORMATO_TRIGONOMETRICO = "{0}(cos({1}π) + j sen({1}π))";
        public const string FORMATO_EXPONECIAL = "{0}e^j{1}π";

        double _modulo;

        double _angulo;

        /// <summary>
        /// Método utilizado para obtener el módulo de un número complejo.
        /// </summary>
        public double Modulo
        {
            get { return _modulo; }
        }


        /// <summary>
        /// Método utilizado para obtener el ángulo de un número complejo.
        /// </summary>
        public double Angulo
        {
            get { return _angulo; }
        }


        /// <summary>
        /// Método utilizado para construir un número complejo polar. 
        /// </summary>
        /// <param name="modulo">módulo de un número complejo</param>
        /// <param name="angulo">ángulo de un número complejo</param>
        public NumeroComplejoPolar(double modulo, double angulo)
        {

            _modulo = modulo;
            _angulo = angulo;
        }

        /// <summary>
        /// Método utilizado para obtener el número en formato polar.
        /// </summary>
        /// <returns>número complejo binómico en formato polar.</returns>   
        public string ObtenerPolar()
        {
            return string.Format(FORMATO_POLAR, _modulo, _angulo / Math.PI);
        }

        /// <summary>
        /// Método utilizado para obtener el número en formato trigonométrico.
        /// </summary>
        /// <returns>número complejo binómico en formato trigonométrico.</returns>   
        public string ObtenerTrigonometrica()
        {
            return string.Format(FORMATO_TRIGONOMETRICO, _modulo, _angulo / Math.PI);
        }

        /// <summary>
        /// Método utilizado para obtener el número en formato exponencial.
        /// </summary>
        /// <returns>número complejo binómico en formato exponencial.</returns>
        public string ObtenerExponencial()
        {
            return string.Format(FORMATO_EXPONECIAL, _modulo, _angulo / Math.PI);
        }

    }

   
}
