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
    public partial class VentanaFasores : Form
    {
        public VentanaFasores()
        {
            InitializeComponent();
        }

        private void VentanaFasores_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void numero1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            int tipoOperacion;
            int tipoFuncion1, tipoFuncion2;
            
            Double amplitud1;
            Double amplitud2;
            Double fase1; 
            Double fase2;
            Double frecuencia1;
            Double frecuencia2;
            
            NumeroComplejoBinomico fasor1B;
            NumeroComplejoBinomico fasor2B;
            NumeroComplejoBinomico resultadoOperacionB;
            NumeroComplejoPolar resultadoOperacionP;
                        
            // Valido que se ingresen solo números
            try
            {
                amplitud1 = Convert.ToDouble(numero1.Text.Trim());
                amplitud2 = Convert.ToDouble(textBox4.Text.Trim());
                fase1 = Convert.ToDouble(numero2.Text.Trim());
                fase2 = Convert.ToDouble(textBox3.Text.Trim());
                frecuencia1 = Convert.ToDouble(textBox1.Text.Trim());
                frecuencia2 = Convert.ToDouble(textBox2.Text.Trim());
                
            }
            catch
            {
                MessageBox.Show("Solo puede ingresar números.", null, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // Valido que se indique si es SUMA o RESTA
            if (radioButton5.Checked)
            {
                tipoOperacion = 1;           // SUMA es 1 y RESTA es 2
            }
            else
            {
                if (radioButton6.Checked)
                {
                    tipoOperacion = 2;
                }
                else
                {
                    MessageBox.Show("Debe especificar si desea SUMAR o RESTAR.", null, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            // Valido que se indique si la primer función es COSENO o SENO 
            if (radioButton1.Checked)
            {
                tipoFuncion1 = 1;            // COSENO es 1 y SENO es 2
            }
            else
            {
                if (radioButton2.Checked)
                {
                    tipoFuncion1 = 2;
                }
                else
                {
                    MessageBox.Show("Debe especificar si la primer función es SENO o COSENO.", null, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            // Valido que se indique si la segunda función es COSENO o SENO 
            if (radioButton3.Checked)
            {
                tipoFuncion2 = 1;            // COSENO es 1 y SENO es 2
            }
            else
            {
                if (radioButton4.Checked)
                {
                    tipoFuncion2 = 2;
                }
                else
                {
                    MessageBox.Show("Debe especificar si la segunda función es SENO o COSENO.", null, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            // Valido que las frecuencias de las dos funciones sean iguales (así se puede aplicar fasores)
            if (!(frecuencia1 == frecuencia2))
            {
                MessageBox.Show("Las frecuencias de ambas funciones deben ser iguales.", null, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // Valido que ambas funciones sean SENO o COSENO
            if (radioButton1.Checked && radioButton4.Checked)
            {
                // Transformar la segunda función
                fase2 = fase2 - (1 / 2);

            }

            if (radioButton2.Checked && radioButton3.Checked)
            {
                // Transformar la primer función
                fase1 = fase1 + (1 / 2);
            }
            
            NumeroComplejoPolar fasor1p = new
            NumeroComplejoPolar(amplitud1,fase1);

            NumeroComplejoPolar fasor2p = new
            NumeroComplejoPolar(amplitud2, fase2);

            fasor1B = OperadorDeComplejos.PolarABinomico(fasor1p);
            fasor2B = OperadorDeComplejos.PolarABinomico(fasor2p);

            // Sumo o resto según la operación indicada
            if (radioButton5.Checked)
            {
                resultadoOperacionB = OperadorDeComplejos.Sumar(fasor1B, fasor2B);
            }
            else
            {
                fasor2B.setParteReal(fasor2B.ParteReal * -1);
                fasor2B.setParteImaginaria(fasor2B.ParteImaginaria * -1);
                resultadoOperacionB = OperadorDeComplejos.Sumar(fasor1B, fasor2B);
            }

            resultadoOperacionP = OperadorDeComplejos.BinomicoAPolar(resultadoOperacionB);
      
            string str_resultado = ObtenerFasor(resultadoOperacionP);
            label11.Text = str_resultado;

            /* - validar que las frecuencias de ambas funciones son iguales
             * - ambas frecuencias son iguales      SI, validar si ambas son senos o cosenos
             *                                      NO, informar que ambas frecuencias deben ser iguales
             * 
             * - ambas son senos o cosenos          SI, armar fasor
             *                                      NO, transformar a todo coseno o todo seno
             *                                      
             * - armar fasor es obtener módulo y argumento (amplitud y fase)
             * - pasar a forma canónica 
             * - sumar o restar (según la variable OPERACION)
             * - pasar a forma exponencial 
             * - imprimir por pantalla
             */
        }

        // REVISAR COMO HACERLO
        public string ObtenerFasor(NumeroComplejoPolar resultado)
        {
            public const string FORMATO_FASOR = "{0} cos({1}t+{2}π)";

            return string.Format(FORMATO_FASOR, Math.Round(_modulo,3), Math.Round(_frecuencia,3), Math.Round((_fase / Math.PI),3));
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    
        private void numero2_TextChanged(object sender, EventArgs e)
        {
        }   
           
        private void textBox4_TextChanged(object sender, EventArgs e)
        {     
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        } 
    }

