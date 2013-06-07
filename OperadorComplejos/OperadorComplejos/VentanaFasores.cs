using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// VALIDAR QUE NO SEAN LETRAS, lo validamos??

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
            double amplitud1;
            amplitud1 = Convert.ToDouble(numero1.Text);

            /*ATRAPAR EXCEPCION!! SI NO PUEDE CASTEAR VA A ARROJAR ERROR, ATRAPARLA Y
             * REELANZARLA CON EL ERROR QUE DIGA QUE NO SE PUEDE INGRESAR LETRAS
             * try
            {
            }
            carch
            {
            }*/

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
            double frecuencia1;
            frecuencia1 = Convert.ToDouble(textBox1.Text);

            /*ATRAPAR EXCEPCION!! SI NO PUEDE CASTEAR VA A ARROJAR ERROR, ATRAPARLA Y
             * REELANZARLA CON EL ERROR QUE DIGA QUE NO SE PUEDE INGRESAR LETRAS
             * try
            {
            }
            carch
            {
            }*/

        }

        private void numero2_TextChanged(object sender, EventArgs e)
        {
            double fase1;
            fase1 = Convert.ToDouble(numero2.Text);

            /*ATRAPAR EXCEPCION!! SI NO PUEDE CASTEAR VA A ARROJAR ERROR, ATRAPARLA Y
             * REELANZARLA CON EL ERROR QUE DIGA QUE NO SE PUEDE INGRESAR LETRAS
             * try
            {
            }
            carch
            {
            }*/

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int tipoFuncion1;
            tipoFuncion1 = 1;               // 1 si es COSENO ; 2 si es SENO
        }                                   

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double amplitud2;
            amplitud2 = Convert.ToDouble(textBox4.Text);

            /*ATRAPAR EXCEPCION!! SI NO PUEDE CASTEAR VA A ARROJAR ERROR, ATRAPARLA Y
             * REELANZARLA CON EL ERROR QUE DIGA QUE NO SE PUEDE INGRESAR LETRAS
             * try
            {
            }
            carch
            {
            }*/

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double fase2;
            fase2 = Convert.ToDouble(textBox3.Text);

            /*ATRAPAR EXCEPCION!! SI NO PUEDE CASTEAR VA A ARROJAR ERROR, ATRAPARLA Y
             * REELANZARLA CON EL ERROR QUE DIGA QUE NO SE PUEDE INGRESAR LETRAS
             * try
            {
            }
            carch
            {
            }*/

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double frecuencia2;
            frecuencia2 = Convert.ToDouble(textBox2.Text);

            /*ATRAPAR EXCEPCION!! SI NO PUEDE CASTEAR VA A ARROJAR ERROR, ATRAPARLA Y
             * REELANZARLA CON EL ERROR QUE DIGA QUE NO SE PUEDE INGRESAR LETRAS
             * try
            {
            }
            carch
            {
            }*/

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

        }
}
