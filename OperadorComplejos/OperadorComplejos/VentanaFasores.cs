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
            // VER DONDE VALIDO QUE LAS FRECUENCIAS NO SEAN IGUALES. SI LO HAGO ABAJO DE TODO
            // ME DA ERROR. VER SI LO PONGO EN EL TRY CATCH
            
            int tipoOperacion;
            int tipoFuncion1, tipoFuncion2;
            Double frecuencia1;
            Double frecuencia2;

            try
            {
                Double amplitud1 = Convert.ToDouble(numero1.Text.Trim());
                Double amplitud2 = Convert.ToDouble(textBox4.Text.Trim());
                Double fase1 = Convert.ToDouble(numero2.Text.Trim());
                Double fase2 = Convert.ToDouble(textBox3.Text.Trim());
                frecuencia1 = Convert.ToDouble(textBox1.Text.Trim());
                frecuencia2 = Convert.ToDouble(textBox2.Text.Trim());
                
            }
            catch
            {
                MessageBox.Show("Solo puede ingresar números.", null, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

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

            NumeroComplejoBinomico binomico1;
            NumeroComplejoBinomico binomico2;
            NumeroComplejoPolar polar1;
            NumeroComplejoPolar polar2;

            string fasor;

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
        } 
    }

