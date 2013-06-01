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
    }
}
