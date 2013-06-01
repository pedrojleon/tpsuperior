using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OperadorComplejos
{
    public partial class VentanaRadicacion : Form
    {
        public VentanaRadicacion()
        {
            InitializeComponent();
        }

        public Boolean numeroValido(string numero)
        {

            if (numero.Equals(""))
                return false;

            string primer_caracter = numero.Substring(0, 1);
            string ultimo_caracter = numero.Substring(numero.Length - 1, 1);
            char delimitador = ',';

            if (!primer_caracter.Equals("(") && !primer_caracter.Equals("["))
                return false;
            if (!ultimo_caracter.Equals(")") && !ultimo_caracter.Equals("]"))
                return false;
            if (primer_caracter.Equals("(") && !ultimo_caracter.Equals(")"))
                return false;
            if (primer_caracter.Equals("[") && !ultimo_caracter.Equals("]"))
                return false;
            if (primer_caracter.Equals("(") && ultimo_caracter.Equals(")") && !numero.Contains(','))
                return false;
            if (primer_caracter.Equals("[") && ultimo_caracter.Equals("]") && !numero.Contains(';'))
                return false;

            delimitador = (primer_caracter.Equals("[") && ultimo_caracter.Equals("]")) ? ';' : ',';

            string parte_del_medio = numero.Substring(1, numero.Length - 2);
            string[] partes_del_numero = parte_del_medio.Split(delimitador);
            string primera_parte = partes_del_numero[0];
            string segunda_parte = partes_del_numero[1];
            primera_parte = primera_parte.Replace('.', ',');
            segunda_parte = segunda_parte.Replace('.', ',');

            try
            {
                Double d_1 = Convert.ToDouble(primera_parte);
                Double d_2 = Convert.ToDouble(segunda_parte);
            }
            catch
            {
                return false;
            }

            return true;

        }

        public NumeroComplejoBinomico getBinomico(string numero)
        { //viene en formato (a,b)

            string parte_del_medio = numero.Substring(1, numero.Length - 2);
            string[] partes_del_numero = parte_del_medio.Split(',');
            string primera_parte = partes_del_numero[0];
            string segunda_parte = partes_del_numero[1];
            primera_parte = primera_parte.Replace('.', ',');
            segunda_parte = segunda_parte.Replace('.', ',');

            Double d_1 = Convert.ToDouble(primera_parte);
            Double d_2 = Convert.ToDouble(segunda_parte);

            NumeroComplejoBinomico rtado = new NumeroComplejoBinomico(d_1, d_2);
            return rtado;
        }

        public NumeroComplejoPolar getPolar(string numero)
        { //viene en formato [a;b]

            string parte_del_medio = numero.Substring(1, numero.Length - 2);
            string[] partes_del_numero = parte_del_medio.Split(';');
            string primera_parte = partes_del_numero[0];
            string segunda_parte = partes_del_numero[1];
            primera_parte = primera_parte.Replace('.', ',');
            segunda_parte = segunda_parte.Replace('.', ',');

            Double d_1 = Convert.ToDouble(primera_parte);
            Double d_2 = Convert.ToDouble(segunda_parte);

            NumeroComplejoPolar rtado = new NumeroComplejoPolar(d_1, d_2);
            return rtado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str_nro1 = numero1.Text.Trim();
            string raiz = numero2.Text.Trim();
            double raiz_double;
            NumeroComplejoBinomico binomico1;
            NumeroComplejoPolar polar1;

            if (raiz.Trim().Equals("") || raiz.Trim().Equals("0"))
            {
                MessageBox.Show("Ingrese una raiz válida", null, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                try
                {
                    raiz_double = Convert.ToDouble(raiz.Replace('.',','));
                }
                catch
                {
                    MessageBox.Show("Ingrese una raiz válida", null, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (!numeroValido(str_nro1))
            {
                MessageBox.Show("El número ingresado no cumple con el formato establecido. \nFormatos: (a,b) o [a;b].", null, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (str_nro1.Substring(0, 1).Equals("("))
            {
                binomico1 = getBinomico(str_nro1);
                polar1 = OperadorDeComplejos.BinomicoAPolar(binomico1);
                NumeroComplejoBinomico aux = OperadorDeComplejos.PolarABinomico(polar1);

            }
            else
            {
                polar1 = getPolar(str_nro1);
                binomico1 = OperadorDeComplejos.PolarABinomico(polar1);
            }

            List<NumeroComplejoPolar> listaRaicesPolares = OperadorDeComplejos.Raiz(polar1, raiz_double);
            List<NumeroComplejoBinomico> listaRaicesBinomicas = OperadorDeComplejos.Raiz(binomico1, raiz_double);

            label_res_polar.Text = stringListaRaicesPolares(listaRaicesPolares);
            label_res_binom.Text = stringListaRaicesBinomicas(listaRaicesBinomicas);
        }

        public string stringListaRaicesPolares(List<NumeroComplejoPolar> lista) {

            string rtado = "";
            foreach(NumeroComplejoPolar ncp in lista){
                rtado = (rtado.Equals("")) ? ncp.ObtenerPolar() : rtado + " - " + ncp.ObtenerPolar();
            }
            return rtado;
        }

        public string stringListaRaicesBinomicas(List<NumeroComplejoBinomico> lista)
        {

            string rtado = "";
            foreach (NumeroComplejoBinomico ncb in lista)
            {
                rtado = (rtado.Equals("")) ? ncb.ObtenerBinomica() : rtado + " ; " + ncb.ObtenerBinomica();
            }
            return rtado;
        }
    }
}
