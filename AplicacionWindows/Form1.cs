using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionWindows2
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
                lblNombre.ForeColor = Color.Red;
            else
                lblNombre.ForeColor = System.Drawing.SystemColors.InfoText;

            if (txtApellido.Text == "")
                lblApellido.ForeColor = Color.Red;
            else
                lblApellido.ForeColor = System.Drawing.SystemColors.InfoText;

            if (txtEdad.Text == "")
                lblEdad.ForeColor = Color.Red;
            else
                lblEdad.ForeColor = System.Drawing.SystemColors.InfoText;

            if (txtDirec.Text == "")
                lblDirec.ForeColor = Color.Red;
            else
                lblDirec.ForeColor = System.Drawing.SystemColors.InfoText;

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string edad = txtEdad.Text;
            string direc = txtDirec.Text;

            if (nombre != "" && apellido != "" && edad != "" && direc != "")
            {
                txtResultado.Text = "Apellido y Nombre: " + apellido + " " + nombre + Environment.NewLine + "Edad: " + edad + Environment.NewLine + "Dirección : " + direc;
            }
            else
            {
                MessageBox.Show("Faltan completar campos.");
            }
            

        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            lblNombre.ForeColor = Color.Black;
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                lblNombre.ForeColor = Color.Red;
            }
            else
            {
                lblNombre.ForeColor = Color.Black;
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            lblApellido.ForeColor = Color.Black;
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                lblApellido.ForeColor = Color.Red;
            }
            else
            {
                lblApellido.ForeColor = Color.Black;
            }
        }

        private void txtEdad_Enter(object sender, EventArgs e)
        {
            lblEdad.ForeColor = Color.Black;
        }

        private void txtEdad_Leave(object sender, EventArgs e)
        {
            if (txtEdad.Text == "")
            {
                lblEdad.ForeColor = Color.Red;
            }
            else
            {
                lblEdad.ForeColor = Color.Black;
            }
        }

        private void txtDirec_Enter(object sender, EventArgs e)
        {
            lblDirec.ForeColor = Color.Black;
        }

        private void txtDirec_Leave(object sender, EventArgs e)
        {
            if (txtDirec.Text == "")
            {
                lblDirec.ForeColor = Color.Red;
            }
            else
            {
                lblDirec.ForeColor = Color.Black;
            }
        }

        private void frm1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
