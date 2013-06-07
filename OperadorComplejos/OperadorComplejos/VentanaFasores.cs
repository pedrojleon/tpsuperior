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
            int amplitud1;
            amplitud1 = Convert.ToInt32(numero1.Text);   //está bien?
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int frecuencia1;
            frecuencia1 = Convert.ToInt32(textBox1.Text);
        }

        private void numero2_TextChanged(object sender, EventArgs e)
        {
            int fase1;
            fase1 = Convert.ToInt32(numero2.Text); //está bien?
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int tipoFuncion1;
            tipoFuncion1 = 1;               // 1 si es COSENO ; 2 si es SENO
        }                                   

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int amplitud2;
            amplitud2 = Convert.ToInt32(textBox4.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int fase2;
            fase2 = Convert.ToInt32(textBox3.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int frecuencia2;
            frecuencia2 = Convert.ToInt32(textBox2.Text);
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
