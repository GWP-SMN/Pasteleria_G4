namespace Vistas
{
    partial class AltaFamilia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaFamilia));
            this.lblIdFamilia = new System.Windows.Forms.Label();
            this.txtIdFamilia = new System.Windows.Forms.TextBox();
            this.txtFamiliaDescripcion = new System.Windows.Forms.TextBox();
            this.lblFamiliaDescripcion = new System.Windows.Forms.Label();
            this.btnAltaFamilia = new System.Windows.Forms.Button();
            this.btnCancelarFamilia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdFamilia
            // 
            this.lblIdFamilia.AutoSize = true;
            this.lblIdFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdFamilia.Location = new System.Drawing.Point(42, 31);
            this.lblIdFamilia.Name = "lblIdFamilia";
            this.lblIdFamilia.Size = new System.Drawing.Size(69, 16);
            this.lblIdFamilia.TabIndex = 1;
            this.lblIdFamilia.Text = "Id Familia:";
            // 
            // txtIdFamilia
            // 
            this.txtIdFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdFamilia.Location = new System.Drawing.Point(108, 31);
            this.txtIdFamilia.Name = "txtIdFamilia";
            this.txtIdFamilia.Size = new System.Drawing.Size(141, 22);
            this.txtIdFamilia.TabIndex = 2;
            // 
            // txtFamiliaDescripcion
            // 
            this.txtFamiliaDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamiliaDescripcion.Location = new System.Drawing.Point(108, 67);
            this.txtFamiliaDescripcion.Name = "txtFamiliaDescripcion";
            this.txtFamiliaDescripcion.Size = new System.Drawing.Size(141, 22);
            this.txtFamiliaDescripcion.TabIndex = 4;
            // 
            // lblFamiliaDescripcion
            // 
            this.lblFamiliaDescripcion.AutoSize = true;
            this.lblFamiliaDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamiliaDescripcion.Location = new System.Drawing.Point(28, 67);
            this.lblFamiliaDescripcion.Name = "lblFamiliaDescripcion";
            this.lblFamiliaDescripcion.Size = new System.Drawing.Size(83, 16);
            this.lblFamiliaDescripcion.TabIndex = 3;
            this.lblFamiliaDescripcion.Text = "Descripción:";
            // 
            // btnAltaFamilia
            // 
            this.btnAltaFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaFamilia.Image = global::Vistas.Properties.Resources.imgGuardar;
            this.btnAltaFamilia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaFamilia.Location = new System.Drawing.Point(36, 124);
            this.btnAltaFamilia.Name = "btnAltaFamilia";
            this.btnAltaFamilia.Size = new System.Drawing.Size(102, 23);
            this.btnAltaFamilia.TabIndex = 5;
            this.btnAltaFamilia.Text = "Alta Familia";
            this.btnAltaFamilia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAltaFamilia.UseVisualStyleBackColor = true;
            this.btnAltaFamilia.Click += new System.EventHandler(this.btnAltaFamilia_Click);
            this.btnAltaFamilia.MouseLeave += new System.EventHandler(this.btnAltaFamilia_MouseLeave);
            this.btnAltaFamilia.MouseHover += new System.EventHandler(this.btnAltaFamilia_MouseHover);
            // 
            // btnCancelarFamilia
            // 
            this.btnCancelarFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFamilia.Image = global::Vistas.Properties.Resources.imgSalir;
            this.btnCancelarFamilia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarFamilia.Location = new System.Drawing.Point(155, 124);
            this.btnCancelarFamilia.Name = "btnCancelarFamilia";
            this.btnCancelarFamilia.Size = new System.Drawing.Size(94, 23);
            this.btnCancelarFamilia.TabIndex = 6;
            this.btnCancelarFamilia.Text = "Cancelar";
            this.btnCancelarFamilia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarFamilia.UseVisualStyleBackColor = true;
            this.btnCancelarFamilia.Click += new System.EventHandler(this.btnCancelarFamilia_Click);
            this.btnCancelarFamilia.MouseLeave += new System.EventHandler(this.btnCancelarFamilia_MouseLeave);
            this.btnCancelarFamilia.MouseHover += new System.EventHandler(this.btnCancelarFamilia_MouseHover);
            // 
            // AltaFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 193);
            this.Controls.Add(this.btnCancelarFamilia);
            this.Controls.Add(this.btnAltaFamilia);
            this.Controls.Add(this.txtFamiliaDescripcion);
            this.Controls.Add(this.lblFamiliaDescripcion);
            this.Controls.Add(this.txtIdFamilia);
            this.Controls.Add(this.lblIdFamilia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaFamilia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaFamilia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdFamilia;
        private System.Windows.Forms.TextBox txtIdFamilia;
        private System.Windows.Forms.TextBox txtFamiliaDescripcion;
        private System.Windows.Forms.Label lblFamiliaDescripcion;
        private System.Windows.Forms.Button btnAltaFamilia;
        private System.Windows.Forms.Button btnCancelarFamilia;
    }
}