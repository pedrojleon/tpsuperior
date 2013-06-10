using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperadorComplejos
{
    /// <summary>
    /// Clase utilizada para realizar operaciones de números complejos.
    /// </summary>
    public class OperadorDeComplejos
    {
        public const uint CUADRANTE_I = 1;
        public const uint CUADRANTE_II = 2;
        public const uint CUADRANTE_III = 3;
        public const uint CUADRANTE_IV = 4;
        //Campo utilizado para limitar la cantidad de decimales en operaciones.
        private static int _cantidadDeDecimales = 9;

        /// <summary>
        /// Método utilizado para setear la cantidad de decimales de las operaciones.
        /// </summary>
        /// <param name="cantidad">cantidad de decimales</param>
        public static void SetearCantidadDeCaracteresDeRedondeo(int cantidad)
        {
            _cantidadDeDecimales = cantidad;
        }

        /// <summary>
        /// Método para realizar la suma de dos números complejos en forma polar.
        /// </summary>
        /// <param name="a">número complejo en forma polar</param>
        /// <param name="b">número complejo en forma polar</param>
        /// <returns></returns>
        public static NumeroComplejoPolar Sumar(NumeroComplejoPolar a, NumeroComplejoPolar b)
        {
            NumeroComplejoBinomico aCarteisano = PolarABinomico(a);
            NumeroComplejoBinomico bCartesiano = PolarABinomico(b);

            return BinomicoAPolar(Sumar(aCarteisano, bCartesiano));

        }

        /// <summary>
        /// Método para realizar la suma de dos números complejos en forma binómica.
        /// </summary>
        /// <param name="a">número complejo en forma binómica</param>
        /// <param name="b">número complejo en forma binómica</param>
        /// <returns></returns>
        public static NumeroComplejoBinomico Sumar(NumeroComplejoBinomico a, NumeroComplejoBinomico b)
        {
            double parteReal = a.ParteReal + b.ParteReal;
            double parteImaginaria = a.ParteImaginaria + b.ParteImaginaria;

            return new NumeroComplejoBinomico(Math.Round(parteReal,3), Math.Round(parteImaginaria,3));
        }
        
        /// <summary>
        /// Método para realizar el cociente de dos números complejos en forma binómica.
        /// </summary>
        /// <param name="a">número complejo en forma binómica</param>
        /// <param name="b">número complejo en forma binómica</param>
        /// <returns></returns>
        public static NumeroComplejoBinomico Cociente(NumeroComplejoBinomico a, NumeroComplejoBinomico b)
        {
            NumeroComplejoPolar aPolar = BinomicoAPolar(a);
            NumeroComplejoPolar bPolar = BinomicoAPolar(b);

            NumeroComplejoPolar resltado = Cociente(aPolar, bPolar);

            return PolarABinomico(resltado);

        }
        /// <summary>
        /// Método para realizar el cociente de dos números complejos en forma polar.
        /// </summary>
        /// <param name="a">número complejo en forma polar</param>
        /// <param name="b">número complejo en forma polar</param>
        /// <returns></returns>
        public static NumeroComplejoPolar Cociente(NumeroComplejoPolar a, NumeroComplejoPolar b)
        {
            double modulo = RedondeoDecimal(a.Modulo / b.Modulo);
            double angulo = a.Angulo - b.Angulo;

            return new NumeroComplejoPolar(Math.Round(modulo,3), Math.Round(angulo,3));
        }


        /// <summary>
        /// Método para realizar el producto de dos números complejos en forma binómica.
        /// </summary>
        /// <param name="a">número complejo en forma binómica</param>
        /// <param name="b">número complejo en forma binómica</param>
        /// <returns></returns>
        public static NumeroComplejoBinomico Producto(NumeroComplejoBinomico a, NumeroComplejoBinomico b)
        {
            double parterealA = a.ParteReal;
            double parteImgA = a.ParteImaginaria;
            double parterealB = b.ParteReal;
            double parteImgB = b.ParteImaginaria;

            double parteRealRtado = (parterealA * parterealB) - (parteImgA * parteImgB);
            double parteImgRtado = (parterealA * parteImgB) + (parteImgA * parterealB);

            NumeroComplejoBinomico resltado = new NumeroComplejoBinomico(Math.Round(parteRealRtado,3), Math.Round(parteImgRtado,3));

            return resltado;
        }


        /// <summary>
        /// Método para realizar el producto de dos números complejos en forma binómica.
        /// </summary>
        /// <param name="a">número complejo en forma polar</param>
        /// <param name="b">número complejo en forma polar</param>
        /// <returns></returns>
        public static NumeroComplejoPolar Producto(NumeroComplejoPolar a, NumeroComplejoPolar b)
        {
            double modulo = RedondeoDecimal(a.Modulo * b.Modulo);
            double angulo = a.Angulo + b.Angulo;

            return new NumeroComplejoPolar(modulo, angulo);

        }

        /// <summary>
        /// Método para realizar la potencia de un número complejo en forma binómica.
        /// </summary>
        /// <param name="a">número complejo en forma binómica</param>
        /// <param name="b">potencia a la que se lo quiere elevar</param>
        /// <returns></returns>
        public static NumeroComplejoBinomico Potencia(NumeroComplejoBinomico a, int b)
        {
            if (b == 2)
            { // z^2 = a^2-b^2 + 2abj
                double parteReal = Math.Pow(a.ParteReal, 2) - Math.Pow(a.ParteImaginaria, 2);
                double parteImag = 2 * a.ParteReal * a.ParteImaginaria;
                NumeroComplejoBinomico ncb = new NumeroComplejoBinomico(parteReal, parteImag);
                return ncb;
            }

            NumeroComplejoPolar polar = OperadorDeComplejos.BinomicoAPolar(a);
            double modulo = Math.Pow(polar.Modulo, b);
            double angulo = polar.Angulo * b;
            NumeroComplejoPolar rtado_polar = new NumeroComplejoPolar(modulo, angulo);
            NumeroComplejoBinomico rtado_binomico = OperadorDeComplejos.PolarABinomico(rtado_polar);
            return rtado_binomico;

        }

        /// <summary>
        /// Método para realizar la potencia de un número complejo en forma polar.
        /// </summary>
        /// <param name="a">número complejo en forma polar</param>
        /// <param name="b">potencia a la que se lo quiere elevar</param>
        /// <returns></returns>
        public static NumeroComplejoPolar Potencia(NumeroComplejoPolar a, int b)
        {
            if (b == 2)
            { // z^2 = a^2-b^2 + 2abj
                NumeroComplejoBinomico aBinomico = OperadorDeComplejos.PolarABinomico(a);
                double parteReal = Math.Pow(aBinomico.ParteReal, 2) - Math.Pow(aBinomico.ParteImaginaria, 2);
                double parteImag = 2 * aBinomico.ParteReal * aBinomico.ParteImaginaria;
                NumeroComplejoBinomico ncb = new NumeroComplejoBinomico(parteReal, parteImag);
                NumeroComplejoPolar rtado = OperadorDeComplejos.BinomicoAPolar(ncb);
                return rtado;
            }

            double modulo = Math.Pow(a.Modulo, b);
            double angulo = a.Angulo * b;
            NumeroComplejoPolar rtado_polar = new NumeroComplejoPolar(modulo, angulo);
            return rtado_polar;

        }

        /// <summary>
        /// Método para realizar la raiz de un número complejo en forma polar.
        /// </summary>
        /// <param name="a">número complejo en forma polar</param>
        /// <param name="b">raiz que se le quiere aplicar</param>
        /// <returns></returns>
        public static List<NumeroComplejoPolar> Raiz(NumeroComplejoPolar a, double b)
        {
            double modulo = Math.Pow(a.Modulo, ((double)1 / b));
            List<NumeroComplejoPolar> listaRaices = new List<NumeroComplejoPolar>();
            for (int i = 0; i < b; i++)
            {
                double angulo = (a.Angulo < 0) ? a.Angulo + (2 * Math.PI) : a.Angulo;
                angulo = ((double)(angulo + (i * 2 * Math.PI)) / b);
                NumeroComplejoPolar raiz = new NumeroComplejoPolar(modulo, angulo);
                listaRaices.Add(raiz);
            }
            return listaRaices;
        }

        /// <summary>
        /// Método para realizar la raiz de un número complejo en forma binomica.
        /// </summary>
        /// <param name="a">número complejo en forma binómica</param>
        /// <param name="b">raiz que se le quiere aplicar</param>
        /// <returns></returns>
        public static List<NumeroComplejoBinomico> Raiz(NumeroComplejoBinomico a, double b)
        {
            NumeroComplejoPolar polar = OperadorDeComplejos.BinomicoAPolar(a);
            double modulo = Math.Pow(polar.Modulo, ((double)1 / b));
            List<NumeroComplejoBinomico> listaRaices = new List<NumeroComplejoBinomico>();
            for (int i = 0; i < b; i++)
            {
                double angulo = (polar.Angulo < 0) ? polar.Angulo + (2 * Math.PI) : polar.Angulo;
                angulo = ((double)(angulo + (i * 2 * Math.PI)) / b);
                NumeroComplejoPolar raiz = new NumeroComplejoPolar(modulo, angulo);
                NumeroComplejoBinomico raiz_binomica = OperadorDeComplejos.PolarABinomico(raiz);
                listaRaices.Add(raiz_binomica);
            }
            return listaRaices;
        }


        /// <summary>
        /// Método utilizado para pasar un número de polar a binómico.
        /// </summary>
        /// <param name="polar">número polar que quiere pasarse a binómico</param>
        /// <returns>número complejo binómico</returns>
        public static NumeroComplejoBinomico PolarABinomico(NumeroComplejoPolar polar)
        {


            double parteReal = RedondeoDecimal(polar.Modulo * Math.Cos(polar.Angulo));
            double parteImaginaria = RedondeoDecimal(polar.Modulo * Math.Sin(polar.Angulo));

            return new NumeroComplejoBinomico(parteReal, parteImaginaria);
        }

        /// <summary>
        /// Método utilizado para pasar un número de binómico a polar.
        /// </summary>
        /// <param name="polar">número binómico que quiere pasarse a polar</param>
        /// <returns>número complejo polar</returns>        
        public static NumeroComplejoPolar BinomicoAPolar(NumeroComplejoBinomico cartesiano)
        {
            double parteReal = cartesiano.ParteReal;
            double parteImaginaria = cartesiano.ParteImaginaria;
            double modulo = RedondeoDecimal(Math.Sqrt(parteReal * parteReal + parteImaginaria * parteImaginaria));
            uint cuadrante = ObtenerCuadrante(parteReal, parteImaginaria);

            double angulo = Math.Atan(parteImaginaria / parteReal);
            switch (cuadrante)
            {

                case CUADRANTE_II:
                    angulo = angulo + Math.PI;
                    break;
                case CUADRANTE_III:
                    angulo = angulo + Math.PI;
                    break;
                case CUADRANTE_IV:
                    angulo = angulo + 2 * Math.PI;
                    break;
            }
            return new NumeroComplejoPolar(modulo, angulo);
        }
        /// <summary>
        /// Método utilizado para determinar el cuadrante al que pertenece un punto.
        /// </summary>
        /// <param name="a">punto sobre el eje de coordenadas horizontal</param>
        /// <param name="b">punto sobre el eje de coordenadas vertical</param>
        /// <returns>número de cuadrante</returns>
        public static uint ObtenerCuadrante(double a, double b)
        {
            if (a >= 0 && b >= 0)
            {
                return CUADRANTE_I;
            }
            else
            {
                if (a < 0 && b < 0)
                {
                    return CUADRANTE_III;
                }
                else
                {
                    if (a < 0)
                    {
                        return CUADRANTE_II;
                    }
                    else
                    {
                        return CUADRANTE_IV;
                    }
                }
            }
        }
        /// <summary>
        /// Método utilizado para redondear la cantidad de decimales de un valor.
        /// </summary>
        /// <param name="valor">valor que se quiere redondear</param>
        /// <returns>valor redondeado con la cantidad de caracteres de la clase</returns>
        public static double RedondeoDecimal(double valor)
        {
            return Math.Round(valor, _cantidadDeDecimales);
        }

    }
}

