using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Visible = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bienvenidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Como Estas!!", "Mensaje de Bienvenida");
        }

        private void despedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta Pronto", "Mensaje de Despedida");
        }
    }
}
