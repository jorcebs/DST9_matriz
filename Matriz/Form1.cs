using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz
{
    public partial class Form1 : Form
    {
        Matriz matriz;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            matriz = new Matriz(Convert.ToInt32(txtSize.Text));
        }

        private void btnMostrarXRenglón_Click(object sender, EventArgs e)
        {
            txtShow.Text = matriz.mostrarXRenglón();
        }

        private void btnLlenarXRenglón_Click(object sender, EventArgs e)
        {
            matriz.llenarXRenglón();
        }

        private void btnInversoRenglón_Click(object sender, EventArgs e)
        {
            matriz.llenarXRenglónInverso();
        }

        private void btnMostrarXColumna_Click(object sender, EventArgs e)
        {
            txtShow.Text = matriz.mostrarXColumna();
        }

        private void btnLlenarXColumna_Click(object sender, EventArgs e)
        {
            matriz.llenarXColumna();
        }

        private void btnInversoColumna_Click(object sender, EventArgs e)
        {
            matriz.llenarXColumnaInverso();
        }

        private void btnArribaDiagPrinc_Click(object sender, EventArgs e)
        {
            txtShow.Text = matriz.mostrarArribaDiagonalPrincipal();
        }

        private void btnDebajoDiagPrinc_Click(object sender, EventArgs e)
        {
            txtShow.Text = matriz.mostrarDebajoDiagonalPrincipal();
        }

        private void btnDiagPrinc_Click(object sender, EventArgs e)
        {
            txtShow.Text = matriz.mostrarDiagonalPrincipal();
        }

        private void btnArribaDiagSec_Click(object sender, EventArgs e)
        {
            txtShow.Text = matriz.mostrarArribaDiagonalSecundaria();
        }

        private void btnDebajoDiagSec_Click(object sender, EventArgs e)
        {
            txtShow.Text = matriz.mostrarDebajoDiagonalSecundaria();
        }

        private void btnDiagSec_Click(object sender, EventArgs e)
        {
            txtShow.Text = matriz.mostrarDiagonalSecundaria();
        }

        private void btnMostrarPro_Click(object sender, EventArgs e)
        {
            txtShow.Text = matriz.mostrarPro();
        }

        private void btnRotarXPrincipal_Click(object sender, EventArgs e)
        {
            matriz.rotarXDiagonalPrincipal();
        }
    }
}