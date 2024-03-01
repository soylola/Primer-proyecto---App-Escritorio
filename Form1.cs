using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Cuchau");
        }

        private void lblImagen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://unsplash.com/es/fotos/gato-marron-y-negro-sobre-fondo-blanco-Y0WXj3xqJz0");
        }

        private void btnBoton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento Click", "Atención");
            //this.BackColor = Color.Blue;

            if (txtTexto.Text == "")
                txtTexto.BackColor = Color.Red;
            else
                txtTexto.BackColor = System.Drawing.SystemColors.Control;

        }

        private void frmPrincipal_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else
            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.Cyan;
            label1.Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.SystemColors.ControlDark;
            label1.Cursor = Cursors.Arrow;
        }

        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtTexto2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtTexto2.Text.Length + " Caracteres");

        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
