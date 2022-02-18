using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Al cargar la ventana el label inicia con una cadena vacia.
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            txtNumero1.Text = "0";
            txtNumero2.Text = "0";
        }
        private void btnSumar_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtNumero1.Text);
            double n2 = Convert.ToDouble(txtNumero2.Text);
            double r = n1 + n2;

            label1.Text = r.ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtNumero1.Text);
            double n2 = Convert.ToDouble(txtNumero2.Text);
            double r = n1 - n2;

            label1.Text = r.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtNumero1.Text);
            double n2 = Convert.ToDouble(txtNumero2.Text);
            double r = n1 / n2;

            label1.Text = r.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtNumero1.Text);
            double n2 = Convert.ToDouble(txtNumero2.Text);
            double r = n1 * n2;

            label1.Text = r.ToString();
        }
    }
}
