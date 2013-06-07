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
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaSuma v_suma = new VentanaSuma();
            v_suma.Tag = this; //guardo en Tag una referencia a mi formulario
            v_suma.ShowDialog();
        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaResta v_resta = new VentanaResta();
            v_resta.Tag = this; //guardo en Tag una referencia a mi formulario
            v_resta.ShowDialog();
        }

        private void mulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaProducto v_producto = new VentanaProducto();
            v_producto.Tag = this; //guardo en Tag una referencia a mi formulario
            v_producto.ShowDialog();
        }

        private void cocienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaCociente v_cociente = new VentanaCociente();
            v_cociente.Tag = this; //guardo en Tag una referencia a mi formulario
            v_cociente.ShowDialog();
        }

        private void potenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaPotencia v_potencia = new VentanaPotencia();
            v_potencia.Tag = this; //guardo en Tag una referencia a mi formulario
            v_potencia.ShowDialog();
        }

        private void radicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaRadicacion v_raiz = new VentanaRadicacion();
            v_raiz.Tag = this; //guardo en Tag una referencia a mi formulario
            v_raiz.ShowDialog();
        }

        private void fasoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaFasores v_fasores = new VentanaFasores();
            v_fasores.Tag = this; //guardo en Tag una referencia a mi formulario
            v_fasores.ShowDialog();

        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
