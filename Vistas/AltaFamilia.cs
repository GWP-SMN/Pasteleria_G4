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
    public partial class AltaFamilia : Form
    {
        public AltaFamilia()
        {
            InitializeComponent();
        }
        //boton cancelar 
        private void btnCancelarFamilia_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //boton Alta de familia
        private void btnAltaFamilia_Click(object sender, EventArgs e)
        {
            string mostrarDatos;
            Familia familia = new Familia();
            //capturamos los datos de los textbox
            familia.Fam_Id = Convert.ToInt32(txtIdFamilia.Text);
            familia.Fam_Descrip = txtFamiliaDescripcion.Text;
            //mostramos los datos
            mostrarDatos = "ALTA DE FAMILIA\n"+
                           "\nId Familia: " +familia.Fam_Id+"\n"+
                           "\nFamilia Descripcion: " +familia.Fam_Descrip;
            MessageBox.Show(mostrarDatos);
            this.Close();
        }

        private void btnAltaFamilia_MouseHover(object sender, EventArgs e)
        {
            btnAltaFamilia.ForeColor = Color.Red;
        }

        private void btnAltaFamilia_MouseLeave(object sender, EventArgs e)
        {
            btnAltaFamilia.ForeColor = Color.Black;
        }

        private void btnCancelarFamilia_MouseHover(object sender, EventArgs e)
        {
            btnCancelarFamilia.ForeColor = Color.Red;
        }

        private void btnCancelarFamilia_MouseLeave(object sender, EventArgs e)
        {
            btnCancelarFamilia.ForeColor = Color.Black;
        }


    }
}
