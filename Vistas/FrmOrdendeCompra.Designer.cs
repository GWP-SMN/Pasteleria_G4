namespace Vistas
{
    partial class FrmOrdendeCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbArticulo = new System.Windows.Forms.GroupBox();
            this.cmbDescripcion = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.cmbArticuloId = new System.Windows.Forms.ComboBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.gbOrdenCompra = new System.Windows.Forms.GroupBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.dataGridViewArticulos = new System.Windows.Forms.DataGridView();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.gbOrdenCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbArticulo
            // 
            this.gbArticulo.Controls.Add(this.cmbDescripcion);
            this.gbArticulo.Controls.Add(this.btnAgregar);
            this.gbArticulo.Controls.Add(this.txtImporte);
            this.gbArticulo.Controls.Add(this.numericUpDownCantidad);
            this.gbArticulo.Controls.Add(this.txtCosto);
            this.gbArticulo.Controls.Add(this.cmbArticuloId);
            this.gbArticulo.Controls.Add(this.lblImporte);
            this.gbArticulo.Controls.Add(this.lblCantidad);
            this.gbArticulo.Controls.Add(this.lblCosto);
            this.gbArticulo.Controls.Add(this.lblDescripcion);
            this.gbArticulo.Controls.Add(this.lblId);
            this.gbArticulo.Location = new System.Drawing.Point(676, 43);
            this.gbArticulo.Name = "gbArticulo";
            this.gbArticulo.Size = new System.Drawing.Size(319, 303);
            this.gbArticulo.TabIndex = 6;
            this.gbArticulo.TabStop = false;
            this.gbArticulo.Text = "Articulo";
            // 
            // cmbDescripcion
            // 
            this.cmbDescripcion.FormattingEnabled = true;
            this.cmbDescripcion.Location = new System.Drawing.Point(148, 45);
            this.cmbDescripcion.Name = "cmbDescripcion";
            this.cmbDescripcion.Size = new System.Drawing.Size(121, 21);
            this.cmbDescripcion.TabIndex = 11;
            this.cmbDescripcion.SelectionChangeCommitted += new System.EventHandler(this.cmbDescripcion_SelectionChangeCommitted);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(194, 222);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(148, 179);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(120, 20);
            this.txtImporte.TabIndex = 9;
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(148, 146);
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCantidad.TabIndex = 8;
            this.numericUpDownCantidad.ValueChanged += new System.EventHandler(this.numericUpDownCantidad_ValueChanged);
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(148, 113);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(121, 20);
            this.txtCosto.TabIndex = 7;
            // 
            // cmbArticuloId
            // 
            this.cmbArticuloId.FormattingEnabled = true;
            this.cmbArticuloId.Location = new System.Drawing.Point(148, 79);
            this.cmbArticuloId.Name = "cmbArticuloId";
            this.cmbArticuloId.Size = new System.Drawing.Size(121, 21);
            this.cmbArticuloId.TabIndex = 5;
            this.cmbArticuloId.SelectionChangeCommitted += new System.EventHandler(this.cmbArticuloId_SelectionChangeCommitted);
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(72, 180);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(45, 13);
            this.lblImporte.TabIndex = 4;
            this.lblImporte.Text = "Importe:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(72, 147);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(72, 114);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(40, 13);
            this.lblCosto.TabIndex = 2;
            this.lblCosto.Text = "Precio:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(72, 48);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(72, 81);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // gbOrdenCompra
            // 
            this.gbOrdenCompra.Controls.Add(this.cmbProveedor);
            this.gbOrdenCompra.Controls.Add(this.dataGridViewArticulos);
            this.gbOrdenCompra.Controls.Add(this.lblProveedor);
            this.gbOrdenCompra.Location = new System.Drawing.Point(12, 30);
            this.gbOrdenCompra.Name = "gbOrdenCompra";
            this.gbOrdenCompra.Size = new System.Drawing.Size(658, 354);
            this.gbOrdenCompra.TabIndex = 5;
            this.gbOrdenCompra.TabStop = false;
            this.gbOrdenCompra.Text = "Orden de Compra";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(111, 24);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(121, 21);
            this.cmbProveedor.TabIndex = 0;
            // 
            // dataGridViewArticulos
            // 
            this.dataGridViewArticulos.AllowUserToAddRows = false;
            this.dataGridViewArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticulos.Location = new System.Drawing.Point(28, 87);
            this.dataGridViewArticulos.Name = "dataGridViewArticulos";
            this.dataGridViewArticulos.ReadOnly = true;
            this.dataGridViewArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArticulos.Size = new System.Drawing.Size(613, 185);
            this.dataGridViewArticulos.TabIndex = 2;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(25, 32);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(59, 13);
            this.lblProveedor.TabIndex = 1;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(869, 352);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmOrdendeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 418);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbArticulo);
            this.Controls.Add(this.gbOrdenCompra);
            this.Name = "FrmOrdendeCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de Compra";
            this.Load += new System.EventHandler(this.FrmOrdendeCompra_Load);
            this.gbArticulo.ResumeLayout(false);
            this.gbArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.gbOrdenCompra.ResumeLayout(false);
            this.gbOrdenCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbArticulo;
        private System.Windows.Forms.ComboBox cmbDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.ComboBox cmbArticuloId;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox gbOrdenCompra;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.DataGridView dataGridViewArticulos;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Button btnSalir;
    }
}