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

        // Sumar
        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = Convert.ToDouble(txtNumero1.Text);
                double n2 = Convert.ToDouble(txtNumero2.Text);
                double r = n1 + n2;
                label1.Text = r.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No puedes sumar un caracter alfabetico con un caracter númerico ");
                throw;
            }  
        }

        // Restar
        private void btnRestar_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = Convert.ToDouble(txtNumero1.Text);
                double n2 = Convert.ToDouble(txtNumero2.Text);
                double r = n1 - n2;

                label1.Text = r.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No puedes restar un caracter alfabetico con un caracter númerico ");
                throw;
            }
        }

        // Dividir
        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = Convert.ToDouble(txtNumero1.Text);
                double n2 = Convert.ToDouble(txtNumero2.Text);
                double r = n1 / n2;

                label1.Text = r.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("No puedes dividir un caracter alfabetico con un caracter númerico ");
                throw;
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dividir por 0 ");
                throw;
            }
        }

        // Multiplicar
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = Convert.ToDouble(txtNumero1.Text);
                double n2 = Convert.ToDouble(txtNumero2.Text);
                double r = n1 * n2;

                label1.Text = r.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No puedes multiplicar un caracter alfabetico con un caracter númerico ");
                throw;
            }
        }
    }
}
