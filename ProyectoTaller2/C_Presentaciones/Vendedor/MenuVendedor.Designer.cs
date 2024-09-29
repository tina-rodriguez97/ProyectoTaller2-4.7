namespace ProyectoTaller2.C_Presentaciones.Vendedor
{
    partial class MenuVendedor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenuVendedor = new System.Windows.Forms.Panel();
            this.pbxLogoV = new System.Windows.Forms.PictureBox();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.btnCancelarAltaC = new System.Windows.Forms.Button();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.btnMisVentas = new System.Windows.Forms.Button();
            this.btnListaProductos = new System.Windows.Forms.Button();
            this.panelMuestra = new System.Windows.Forms.Panel();
            this.panelMenuVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuVendedor
            // 
            this.panelMenuVendedor.BackColor = System.Drawing.Color.GhostWhite;
            this.panelMenuVendedor.Controls.Add(this.pbxLogoV);
            this.panelMenuVendedor.Controls.Add(this.lblNomUsuario);
            this.panelMenuVendedor.Controls.Add(this.btnCancelarAltaC);
            this.panelMenuVendedor.Controls.Add(this.btnAltaCliente);
            this.panelMenuVendedor.Controls.Add(this.btnRealizarVenta);
            this.panelMenuVendedor.Controls.Add(this.btnMisVentas);
            this.panelMenuVendedor.Controls.Add(this.btnListaProductos);
            this.panelMenuVendedor.Location = new System.Drawing.Point(2, 2);
            this.panelMenuVendedor.Name = "panelMenuVendedor";
            this.panelMenuVendedor.Size = new System.Drawing.Size(231, 516);
            this.panelMenuVendedor.TabIndex = 4;
            // 
            // pbxLogoV
            // 
            this.pbxLogoV.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbxLogoV.Image = global::ProyectoTaller2.Properties.Resources.logo;
            this.pbxLogoV.Location = new System.Drawing.Point(27, 15);
            this.pbxLogoV.Name = "pbxLogoV";
            this.pbxLogoV.Size = new System.Drawing.Size(180, 100);
            this.pbxLogoV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxLogoV.TabIndex = 0;
            this.pbxLogoV.TabStop = false;
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUsuario.Location = new System.Drawing.Point(57, 129);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(139, 20);
            this.lblNomUsuario.TabIndex = 0;
            this.lblNomUsuario.Text = "Nombre Vendedor";
            // 
            // btnCancelarAltaC
            // 
            this.btnCancelarAltaC.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelarAltaC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarAltaC.Location = new System.Drawing.Point(61, 481);
            this.btnCancelarAltaC.Name = "btnCancelarAltaC";
            this.btnCancelarAltaC.Size = new System.Drawing.Size(113, 25);
            this.btnCancelarAltaC.TabIndex = 10;
            this.btnCancelarAltaC.Text = "Cerrar Sesión";
            this.btnCancelarAltaC.UseVisualStyleBackColor = false;
            this.btnCancelarAltaC.Click += new System.EventHandler(this.btnCancelarAltaC_Click);
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.BackColor = System.Drawing.Color.Lavender;
            this.btnAltaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAltaCliente.Location = new System.Drawing.Point(27, 354);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(180, 23);
            this.btnAltaCliente.TabIndex = 3;
            this.btnAltaCliente.Text = "Alta Cliente";
            this.btnAltaCliente.UseVisualStyleBackColor = false;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.BackColor = System.Drawing.Color.Lavender;
            this.btnRealizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRealizarVenta.Location = new System.Drawing.Point(27, 305);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(180, 23);
            this.btnRealizarVenta.TabIndex = 2;
            this.btnRealizarVenta.Text = "Realizar Venta";
            this.btnRealizarVenta.UseVisualStyleBackColor = false;
            this.btnRealizarVenta.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // btnMisVentas
            // 
            this.btnMisVentas.BackColor = System.Drawing.Color.Lavender;
            this.btnMisVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMisVentas.Location = new System.Drawing.Point(27, 255);
            this.btnMisVentas.Name = "btnMisVentas";
            this.btnMisVentas.Size = new System.Drawing.Size(180, 23);
            this.btnMisVentas.TabIndex = 1;
            this.btnMisVentas.Text = "Mis Ventas";
            this.btnMisVentas.UseVisualStyleBackColor = false;
            this.btnMisVentas.Click += new System.EventHandler(this.btnMisVentas_Click);
            // 
            // btnListaProductos
            // 
            this.btnListaProductos.BackColor = System.Drawing.Color.Lavender;
            this.btnListaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListaProductos.Location = new System.Drawing.Point(27, 201);
            this.btnListaProductos.Name = "btnListaProductos";
            this.btnListaProductos.Size = new System.Drawing.Size(180, 23);
            this.btnListaProductos.TabIndex = 0;
            this.btnListaProductos.Text = "Listar Productos";
            this.btnListaProductos.UseVisualStyleBackColor = false;
            this.btnListaProductos.Click += new System.EventHandler(this.btnListaProductos_Click);
            // 
            // panelMuestra
            // 
            this.panelMuestra.Location = new System.Drawing.Point(234, 2);
            this.panelMuestra.Name = "panelMuestra";
            this.panelMuestra.Size = new System.Drawing.Size(805, 516);
            this.panelMuestra.TabIndex = 5;
            // 
            // MenuVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 520);
            this.Controls.Add(this.panelMuestra);
            this.Controls.Add(this.panelMenuVendedor);
            this.IsMdiContainer = true;
            this.Name = "MenuVendedor";
            this.Text = "MenuVendedor";
            this.panelMenuVendedor.ResumeLayout(false);
            this.panelMenuVendedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoV)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panelMenuVendedor;
        private System.Windows.Forms.Panel panelMuestra;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.Button btnRealizarVenta;
        private System.Windows.Forms.Button btnMisVentas;
        private System.Windows.Forms.Button btnListaProductos;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.PictureBox pbxLogoV;
        private System.Windows.Forms.Button btnCancelarAltaC;
    }
}



