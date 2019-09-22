using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1_POO_C_sharp_
{
    public partial class Form1 : Form
    {
        //Instancia de una clase.
        Matematicas matematicas = new Matematicas();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            matematicas.setNumero1(double.Parse(txtNumero1.Text));
            matematicas.setNumero2(double.Parse(txtNumero2.Text));
            lblResultado.Text =" Resultado: " + matematicas.sumar().ToString();          
            lblResultado.Visible = true;
            txtNumero1.Text = "";
            txtNumero2.Text = "";

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            matematicas.setNumero1(double.Parse(txtNumero1.Text));
            matematicas.setNumero2(double.Parse(txtNumero2.Text));
            lblResultado.Text = " Resultado: " + matematicas.resta().ToString();
            lblResultado.Visible = true;
            txtNumero1.Text = "";
            txtNumero2.Text = "";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            matematicas.setNumero1(double.Parse(txtNumero1.Text));
            matematicas.setNumero2(double.Parse(txtNumero2.Text));
            lblResultado.Text = " Resultado: " + matematicas.multiplicacion().ToString();
            lblResultado.Visible = true;
            txtNumero1.Text = "";
            txtNumero2.Text = "";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            matematicas.setNumero1(double.Parse(txtNumero1.Text));
            matematicas.setNumero2(double.Parse(txtNumero2.Text));
            lblResultado.Text = " Resultado: " + matematicas.division().ToString();
            lblResultado.Visible = true;
            txtNumero1.Text = "";
            txtNumero2.Text = "";
        }
    }
}
