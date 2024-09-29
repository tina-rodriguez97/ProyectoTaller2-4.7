namespace ProyectoTaller2.C_Presentaciones.Vendedor
{
    partial class ListaVentasRealizadas
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
            this.gbxVentasRealizadas = new System.Windows.Forms.GroupBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFiltrarFecha = new System.Windows.Forms.Label();
            this.btnFiltroVen = new System.Windows.Forms.Button();
            this.lblTilMisVentas = new System.Windows.Forms.Label();
            this.gridListaProductos = new System.Windows.Forms.DataGridView();
            this.col_NroVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NomProductoV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_detalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbxVentasRealizadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxVentasRealizadas
            // 
            this.gbxVentasRealizadas.BackColor = System.Drawing.Color.Lavender;
            this.gbxVentasRealizadas.Controls.Add(this.lblHasta);
            this.gbxVentasRealizadas.Controls.Add(this.lblDesde);
            this.gbxVentasRealizadas.Controls.Add(this.dtpHasta);
            this.gbxVentasRealizadas.Controls.Add(this.dtpDesde);
            this.gbxVentasRealizadas.Controls.Add(this.lblFiltrarFecha);
            this.gbxVentasRealizadas.Controls.Add(this.btnFiltroVen);
            this.gbxVentasRealizadas.Controls.Add(this.lblTilMisVentas);
            this.gbxVentasRealizadas.Location = new System.Drawing.Point(12, 2);
            this.gbxVentasRealizadas.Name = "gbxVentasRealizadas";
            this.gbxVentasRealizadas.Size = new System.Drawing.Size(776, 76);
            this.gbxVentasRealizadas.TabIndex = 1;
            this.gbxVentasRealizadas.TabStop = false;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(599, 16);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(35, 13);
            this.lblHasta.TabIndex = 7;
            this.lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(483, 16);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(38, 13);
            this.lblDesde.TabIndex = 6;
            this.lblDesde.Text = "Desde";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(568, 36);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(98, 20);
            this.dtpHasta.TabIndex = 5;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(454, 36);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(98, 20);
            this.dtpDesde.TabIndex = 4;
            // 
            // lblFiltrarFecha
            // 
            this.lblFiltrarFecha.AutoSize = true;
            this.lblFiltrarFecha.Location = new System.Drawing.Point(355, 43);
            this.lblFiltrarFecha.Name = "lblFiltrarFecha";
            this.lblFiltrarFecha.Size = new System.Drawing.Size(83, 13);
            this.lblFiltrarFecha.TabIndex = 3;
            this.lblFiltrarFecha.Text = "Filtrar por fecha:";
            // 
            // btnFiltroVen
            // 
            this.btnFiltroVen.BackColor = System.Drawing.Color.AliceBlue;
            this.btnFiltroVen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltroVen.Location = new System.Drawing.Point(685, 31);
            this.btnFiltroVen.Name = "btnFiltroVen";
            this.btnFiltroVen.Size = new System.Drawing.Size(71, 25);
            this.btnFiltroVen.TabIndex = 1;
            this.btnFiltroVen.Text = "Filtrar";
            this.btnFiltroVen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFiltroVen.UseVisualStyleBackColor = false;
            // 
            // lblTilMisVentas
            // 
            this.lblTilMisVentas.AutoSize = true;
            this.lblTilMisVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTilMisVentas.Location = new System.Drawing.Point(12, 16);
            this.lblTilMisVentas.Name = "lblTilMisVentas";
            this.lblTilMisVentas.Size = new System.Drawing.Size(119, 25);
            this.lblTilMisVentas.TabIndex = 0;
            this.lblTilMisVentas.Text = "Mis Ventas";
            // 
            // gridListaProductos
            // 
            this.gridListaProductos.AllowUserToAddRows = false;
            this.gridListaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridListaProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridListaProductos.BackgroundColor = System.Drawing.Color.Lavender;
            this.gridListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_NroVenta,
            this.col_FechaVenta,
            this.col_cliente,
            this.col_NomProductoV,
            this.col_cantidad,
            this.col_precioTotal,
            this.col_detalle});
            this.gridListaProductos.Location = new System.Drawing.Point(12, 85);
            this.gridListaProductos.Name = "gridListaProductos";
            this.gridListaProductos.Size = new System.Drawing.Size(776, 353);
            this.gridListaProductos.TabIndex = 2;
            // 
            // col_NroVenta
            // 
            this.col_NroVenta.HeaderText = "Nro de Venta";
            this.col_NroVenta.Name = "col_NroVenta";
            // 
            // col_FechaVenta
            // 
            this.col_FechaVenta.HeaderText = "Fecha de Venta";
            this.col_FechaVenta.Name = "col_FechaVenta";
            // 
            // col_cliente
            // 
            this.col_cliente.HeaderText = "Cliente";
            this.col_cliente.Name = "col_cliente";
            // 
            // col_NomProductoV
            // 
            this.col_NomProductoV.HeaderText = "Nombre Producto";
            this.col_NomProductoV.Name = "col_NomProductoV";
            // 
            // col_cantidad
            // 
            this.col_cantidad.HeaderText = "Cantidad Productos";
            this.col_cantidad.Name = "col_cantidad";
            // 
            // col_precioTotal
            // 
            this.col_precioTotal.HeaderText = "Precio Total";
            this.col_precioTotal.Name = "col_precioTotal";
            // 
            // col_detalle
            // 
            this.col_detalle.HeaderText = "Ver detalle";
            this.col_detalle.Name = "col_detalle";
            // 
            // ListaVentasRealizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.gridListaProductos);
            this.Controls.Add(this.gbxVentasRealizadas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaVentasRealizadas";
            this.Text = "ListaVentasRealizadas";
            this.gbxVentasRealizadas.ResumeLayout(false);
            this.gbxVentasRealizadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxVentasRealizadas;
        private System.Windows.Forms.Button btnFiltroVen;
        private System.Windows.Forms.Label lblTilMisVentas;
        private System.Windows.Forms.DataGridView gridListaProductos;
        private System.Windows.Forms.Label lblFiltrarFecha;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NroVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NomProductoV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precioTotal;
        private System.Windows.Forms.DataGridViewButtonColumn col_detalle;
    }
}