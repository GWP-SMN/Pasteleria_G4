using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
namespace Vistas
{
    public partial class FrmABMCliente : Form
    {
        public FrmABMCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente oCliente = new Cliente();
            oCliente.Cli_Nombre = txtNombre.Text;
            oCliente.Cli_Domicilio = txtDomicilio.Text;
            oCliente.Cli_Departamento = txtDepartamento.Text;
            oCliente.Cli_Codigo_Postal = txtCodigoPostal.Text;
            oCliente.Cli_Telefono = txtTelefono.Text;
            oCliente.Cli_Email = txtEmail.Text;
            oCliente.Cli_Fecha_Nac = dateTimeFecha.Value;
            string mostrarDatos;  
            //para mostrar los datos:
            mostrarDatos = "ALTA DE Cliente\n" +
                           "\nNombre: " + oCliente.Cli_Nombre + "\n" +
                           "\nDomicilio: " + oCliente.Cli_Domicilio + "\n" +
                           "\nDepartamento: " + oCliente.Cli_Departamento + "\n" +
                           "\nCodigo Postal: " + oCliente.Cli_Codigo_Postal + "\n" +
                           "\nTelefono: " + oCliente.Cli_Telefono + "\n" +
                           "\nEmail: " + oCliente.Cli_Email +
                           "\nFecha de Nac: " + oCliente.Cli_Fecha_Nac;
            MessageBox.Show(mostrarDatos);
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_MouseHover(object sender, EventArgs e)
        {
            btnGuardar.ForeColor = Color.Red;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar.ForeColor = Color.Black;
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.Red;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.Black;
        }



    }
}
