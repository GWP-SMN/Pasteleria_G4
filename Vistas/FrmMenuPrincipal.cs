using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();                   
                switch (Program.userValido.Rol_Id)
                {
                    case 2:
                        comprasToolStripMenuItem.Visible = false;
                        produccionToolStripMenuItem.Visible = false;
                        ventasToolStripMenuItem.Visible = false;
                        usuariosToolStripMenuItem.Visible = false;
                        ///MessageBox.Show("" + Program.userValido.Rol_Id);
                        break;
                    case 3:
                        stockYArticulosToolStripMenuItem.Visible = false;
                        //produccionToolStripMenuItem.Visible = false;
                        comprasToolStripMenuItem.Visible = false;
                        ventasToolStripMenuItem.Visible = false;
                        usuariosToolStripMenuItem.Visible = false;
                        break;
                    case 4:
                        stockYArticulosToolStripMenuItem.Visible = false;
                        produccionToolStripMenuItem.Visible = false;
                        
                        ventasToolStripMenuItem.Visible = false;
                        usuariosToolStripMenuItem.Visible = false;
                        break;
                    case 5:
                        stockYArticulosToolStripMenuItem.Visible = false;
                        produccionToolStripMenuItem.Visible = false;
                        comprasToolStripMenuItem.Visible = false;
                        
                        usuariosToolStripMenuItem.Visible = false;
                        break;
                    case 6:
                        stockYArticulosToolStripMenuItem.Visible = false;
                        produccionToolStripMenuItem.Visible = false;
                        
                        usuariosToolStripMenuItem.Visible = false;
                        break;
                    default:
                        break;
                }
            
           
        }
        private void aMBUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMUsuario oFrmABMUsuario = new FrmABMUsuario();
            
            oFrmABMUsuario.Show();
        }

        private void aMBClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMCliente oFrmABMClienteVentas = new FrmABMCliente();
            oFrmABMClienteVentas.Show();
        }

        /*****************/
       

       
       
       

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void aBMProveedorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmABMProveedor oFrmABMProveedor = new FrmABMProveedor();
            oFrmABMProveedor.Show();
        }

        private void aBMStockyArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMStockyArticulo oFrmABMStockArticulos = new FrmABMStockyArticulo();
            oFrmABMStockArticulos.Show();
        }

        private void aBMProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionProduccion oFrmGestionProduccion = new FrmGestionProduccion();
            oFrmGestionProduccion.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Quiere salir del Sistema?", "Sistema de Pasteleria",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void altaFamiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AltaFamilia oAltaFamilia = new AltaFamilia();
            oAltaFamilia.Show();
        }

        private void altaUnidadDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaUnidaddMedida oAltaUnidadMedida = new AltaUnidaddMedida();
            oAltaUnidadMedida.Show();
        }

        private void cOMPRASREALIZADASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompraRealizada oFrmCompraRealizada = new FrmCompraRealizada();
            oFrmCompraRealizada.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrdendeCompra oFrmOrdendeCompra = new FrmOrdendeCompra();

            oFrmOrdendeCompra.Show();
        }

      

       

        

        
        


     }
}
