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
    public partial class FrmOrdendeCompra : Form
    {
        public FrmOrdendeCompra()
        {
            InitializeComponent();
        }

        //traer la lista del combo de proveedores: Model de la clase OrdenCompraModel
        private void traerListaComboProveedores()
        {
            //DisplayMember:muestra la descripcion.
            cmbProveedor.DisplayMember = "prov_nombre";
            //ValueMember: va a madar el id de refencia.
            cmbProveedor.ValueMember = "prov_id";
            //DataSource: permite recibir el dataTable que va hacer uso de ese recurso.
            cmbProveedor.DataSource = OrdenCompraModel.listarProveedor();



        }

        //traer la lista del combo de proveedores: Model de la clase OrdenCompraModel
        private void traerListaComboArticulos()
        {
           


            cmbArticuloId.DataSource = OrdenCompraModel.listarArticulo();
            cmbArticuloId.DisplayMember = "art_id";
            cmbArticuloId.ValueMember = "art_id";

            //cmbDescripcion.DataSource = OrdenCompraModel.listarArticulo();
            cmbDescripcion.DataSource = cmbArticuloId.DataSource;
            cmbDescripcion.DisplayMember = "art_descrip";
            cmbDescripcion.ValueMember = "art_precio";



        }

        private void FrmOrdendeCompra_Load(object sender, EventArgs e)
        {
            traerListaComboProveedores();
            traerListaComboArticulos();
            //carga y permite traer a todos los Items de orden de compra
            dataGridViewArticulos.DataSource = OrdenCompraModel.listarItemsOrdenCompra();

            
        }






        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            decimal p = Convert.ToDecimal(txtCosto.Text);
            txtImporte.Text = (Convert.ToDecimal(numericUpDownCantidad.Value) * p).ToString();
        }

       
        
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            
           
            
            Orden_Compra oOrdenCompra = new Orden_Compra();
            oOrdenCompra.Prov_Id = (int)cmbProveedor.SelectedValue;
            oOrdenCompra.Oc_fecha = DateTime.Today;
            oOrdenCompra.Pagada = false;

            OrdenCompraModel.insertarOrdenCompra(oOrdenCompra);


            Items_Orden_Compra oItemsOrdenCompra = new Items_Orden_Compra();

            oItemsOrdenCompra.Art_id = (int)cmbArticuloId.SelectedValue;
            oItemsOrdenCompra.Costo = Convert.ToDecimal(txtCosto.Text);
            oItemsOrdenCompra.Cantidad = Convert.ToDecimal(numericUpDownCantidad.Value);
            oItemsOrdenCompra.Importe = Convert.ToDecimal(txtImporte.Text);
            oItemsOrdenCompra.Oc_id = 14;
           


            

            OrdenCompraModel.insertarItemsOrdenCompra(oItemsOrdenCompra);

            dataGridViewArticulos.DataSource = OrdenCompraModel.listarItemsOrdenCompra();
            MessageBox.Show("Se guardo exitosamente!");
           
        }
        
        private void cmbDescripcion_SelectionChangeCommitted(object sender, EventArgs e)
        {

            txtCosto.Text = cmbDescripcion.SelectedValue.ToString();
            txtCosto.Refresh();
        }

        private void cmbArticuloId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtCosto.Text = cmbDescripcion.SelectedValue.ToString();
            txtCosto.Refresh();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        


    }
}
