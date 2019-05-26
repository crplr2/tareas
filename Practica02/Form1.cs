using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica02.Clases;

namespace Practica02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var analizar = new AnalizadorTexto();
            if (txtBoxPalabra.Text.Length > 0)
            {
                char[] carPalabra = analizar.descomponerPalabra(txtBoxPalabra.Text);
                foreach(char c in carPalabra)
                {
                    lstPalabra.Items.Add(c);
                }
            }
            txtBoxPalabra.Clear();

        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            var analizar = new AnalizadorTexto();
            var especiales = analizar.contarCarEspeciales(txtBoxPalabra.Text);
            MessageBox.Show("La palabra " + txtBoxPalabra.Text + " tiene " + especiales + 
                (especiales==1? " caracter especial": "caracteres especiales"));

        }
    }
}
