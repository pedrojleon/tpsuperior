using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// VER COMO LIMPIAR EL TEXTBOX DESPUÉS DE HABER INGRESADO DATO INVÁLIDO

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
            int operacion;
            operacion = 1;          // 1 si es SUMA ; 2 si es RESTA
        }

        private void numero1_TextChanged(object sender, EventArgs e)
        {
            string s_amplitud1 = numero1.Text.Trim();

            if (!esNumero(s_amplitud1))
            {
                MessageBox.Show("Solo puede ingresar números.", null, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Double amplitud1 = Convert.ToDouble(s_amplitud1);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            string s_frecuencia1 = textBox1.Text.Trim();

            if (!esNumero(s_frecuencia1))
            {
                MessageBox.Show("Solo puede ingresar números.", null, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Double frecuencia1 = Convert.ToDouble(s_frecuencia1);
            }
        }
    
        private void numero2_TextChanged(object sender, EventArgs e)
        {
            string s_fase1 = numero2.Text.Trim();

            if (!esNumero(s_fase1))
            {
                MessageBox.Show("Solo puede ingresar números.", null, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Double fase1 = Convert.ToDouble(s_fase1);
            }
        }   
           
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int tipoFuncion1;
            tipoFuncion1 = 1;               // 1 si es COSENO ; 2 si es SENO
        }                                   

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string s_amplitud2 = textBox4.Text.Trim();

            if (!esNumero(s_amplitud2))
            {
                MessageBox.Show("Solo puede ingresar números.", null, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Double amplitud2 = Convert.ToDouble(s_amplitud2);
            }       
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string s_fase2 = textBox3.Text.Trim();

            if (!esNumero(s_fase2))
            {
                MessageBox.Show("Solo puede ingresar números.", null, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Double fase2 = Convert.ToDouble(s_fase2);
            }   
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string s_frecuencia2 = textBox2.Text.Trim();

            if (!esNumero(s_frecuencia2))
            {
                MessageBox.Show("Solo puede ingresar números.", null, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Double frecuencia2 = Convert.ToDouble(s_frecuencia2);
            }  
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int tipoFuncion1;
            tipoFuncion1 = 2;               // 1 si es COSENO ; 2 si es SENO
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int tipoFuncion2;
            tipoFuncion2 = 1;               // 1 si es COSENO ; 2 si es SENO
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int tipoFuncion2;
            tipoFuncion2 = 2;               // 1 si es COSENO ; 2 si es SENO
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            int operacion;
            operacion = 2;          // 1 si es SUMA ; 2 si es RESTA
        }

        public Boolean esNumero(string numeroString) 
        {
            try
            {
                Double numero = Convert.ToDouble(numeroString);
            }
            catch 
            {
                return false;
            }
            return true;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            int tipoFuncion1;
            tipoFuncion1 = 1;          // 1 si es COSENO ; 2 si es SENO
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            int tipoFuncion1;
            tipoFuncion1 = 2;          // 1 si es COSENO ; 2 si es SENO
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            int tipoFuncion2;
            tipoFuncion2 = 1;          // 1 si es COSENO ; 2 si es SENO
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            int tipoFuncion2;
            tipoFuncion2 = 2;          // 1 si es COSENO ; 2 si es SENO
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        } 
    }

