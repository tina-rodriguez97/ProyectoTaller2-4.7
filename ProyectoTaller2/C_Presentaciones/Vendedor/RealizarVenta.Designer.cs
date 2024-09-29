namespace ProyectoTaller2.C_Presentaciones.Vendedor
{
    partial class RealizarVenta
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
            this.gridVentaProducto = new System.Windows.Forms.DataGridView();
            this.gridRealizarVenta = new System.Windows.Forms.DataGridView();
            this.lblNuevaVenta = new System.Windows.Forms.Label();
            this.lblNomVendedor = new System.Windows.Forms.Label();
            this.lblFechaVentaF = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblClienteV = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.col_NomProductoRV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PrecioRV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stockRV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AgregarProRV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_NomProductoVR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precioUnitarioVR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cantidadVR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precioTotalVR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_EliminarProRV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.btnBuscarProVeenta = new System.Windows.Forms.Button();
            this.txtBuscarProVenta = new System.Windows.Forms.TextBox();
            this.lblSelecPro = new System.Windows.Forms.Label();
            this.lblDetalleVenta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentaProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRealizarVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // gridVentaProducto
            // 
            this.gridVentaProducto.AllowUserToAddRows = false;
            this.gridVentaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridVentaProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridVentaProducto.BackgroundColor = System.Drawing.Color.Lavender;
            this.gridVentaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVentaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_NomProductoRV,
            this.col_PrecioRV,
            this.col_stockRV,
            this.col_AgregarProRV});
            this.gridVentaProducto.Location = new System.Drawing.Point(11, 140);
            this.gridVentaProducto.Name = "gridVentaProducto";
            this.gridVentaProducto.Size = new System.Drawing.Size(776, 110);
            this.gridVentaProducto.TabIndex = 2;
            // 
            // gridRealizarVenta
            // 
            this.gridRealizarVenta.AllowUserToAddRows = false;
            this.gridRealizarVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRealizarVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridRealizarVenta.BackgroundColor = System.Drawing.Color.Lavender;
            this.gridRealizarVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRealizarVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_NomProductoVR,
            this.col_precioUnitarioVR,
            this.col_cantidadVR,
            this.col_precioTotalVR,
            this.col_EliminarProRV});
            this.gridRealizarVenta.Location = new System.Drawing.Point(11, 313);
            this.gridRealizarVenta.Name = "gridRealizarVenta";
            this.gridRealizarVenta.Size = new System.Drawing.Size(776, 116);
            this.gridRealizarVenta.TabIndex = 3;
            // 
            // lblNuevaVenta
            // 
            this.lblNuevaVenta.AutoSize = true;
            this.lblNuevaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaVenta.Location = new System.Drawing.Point(12, 8);
            this.lblNuevaVenta.Name = "lblNuevaVenta";
            this.lblNuevaVenta.Size = new System.Drawing.Size(136, 25);
            this.lblNuevaVenta.TabIndex = 4;
            this.lblNuevaVenta.Text = "Nueva Venta";
            this.lblNuevaVenta.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNomVendedor
            // 
            this.lblNomVendedor.AutoSize = true;
            this.lblNomVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomVendedor.Location = new System.Drawing.Point(644, 13);
            this.lblNomVendedor.Name = "lblNomVendedor";
            this.lblNomVendedor.Size = new System.Drawing.Size(144, 20);
            this.lblNomVendedor.TabIndex = 5;
            this.lblNomVendedor.Text = "Nombre Vendedor";
            // 
            // lblFechaVentaF
            // 
            this.lblFechaVentaF.AutoSize = true;
            this.lblFechaVentaF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVentaF.Location = new System.Drawing.Point(14, 57);
            this.lblFechaVentaF.Name = "lblFechaVentaF";
            this.lblFechaVentaF.Size = new System.Drawing.Size(103, 16);
            this.lblFechaVentaF.TabIndex = 6;
            this.lblFechaVentaF.Text = "Fecha de venta:";
            this.lblFechaVentaF.Click += new System.EventHandler(this.lblFechaVentaF_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // lblClienteV
            // 
            this.lblClienteV.AutoSize = true;
            this.lblClienteV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteV.Location = new System.Drawing.Point(517, 61);
            this.lblClienteV.Name = "lblClienteV";
            this.lblClienteV.Size = new System.Drawing.Size(51, 16);
            this.lblClienteV.TabIndex = 8;
            this.lblClienteV.Text = "Cliente:";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(574, 57);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(214, 21);
            this.cbxCliente.TabIndex = 9;
            // 
            // col_NomProductoRV
            // 
            this.col_NomProductoRV.HeaderText = "Nombre Producto";
            this.col_NomProductoRV.Name = "col_NomProductoRV";
            // 
            // col_PrecioRV
            // 
            this.col_PrecioRV.HeaderText = "Precio";
            this.col_PrecioRV.Name = "col_PrecioRV";
            // 
            // col_stockRV
            // 
            this.col_stockRV.HeaderText = "Stock";
            this.col_stockRV.Name = "col_stockRV";
            // 
            // col_AgregarProRV
            // 
            this.col_AgregarProRV.HeaderText = "Agregar";
            this.col_AgregarProRV.Name = "col_AgregarProRV";
            // 
            // col_NomProductoVR
            // 
            this.col_NomProductoVR.HeaderText = "Nombre Producto";
            this.col_NomProductoVR.Name = "col_NomProductoVR";
            // 
            // col_precioUnitarioVR
            // 
            this.col_precioUnitarioVR.HeaderText = "Precio Unitario";
            this.col_precioUnitarioVR.Name = "col_precioUnitarioVR";
            // 
            // col_cantidadVR
            // 
            this.col_cantidadVR.HeaderText = "Cantidad Productos";
            this.col_cantidadVR.Name = "col_cantidadVR";
            // 
            // col_precioTotalVR
            // 
            this.col_precioTotalVR.HeaderText = "Precio Total";
            this.col_precioTotalVR.Name = "col_precioTotalVR";
            // 
            // col_EliminarProRV
            // 
            this.col_EliminarProRV.HeaderText = "Eliminar";
            this.col_EliminarProRV.Name = "col_EliminarProRV";
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCobrar.Location = new System.Drawing.Point(251, 464);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(70, 31);
            this.btnCobrar.TabIndex = 10;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarVenta.Location = new System.Drawing.Point(449, 464);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(70, 31);
            this.btnCancelarVenta.TabIndex = 11;
            this.btnCancelarVenta.Text = "Cancelar";
            this.btnCancelarVenta.UseVisualStyleBackColor = false;
            // 
            // btnBuscarProVeenta
            // 
            this.btnBuscarProVeenta.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBuscarProVeenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarProVeenta.Location = new System.Drawing.Point(412, 99);
            this.btnBuscarProVeenta.Name = "btnBuscarProVeenta";
            this.btnBuscarProVeenta.Size = new System.Drawing.Size(71, 25);
            this.btnBuscarProVeenta.TabIndex = 12;
            this.btnBuscarProVeenta.Text = "Buscar";
            this.btnBuscarProVeenta.UseVisualStyleBackColor = false;
            // 
            // txtBuscarProVenta
            // 
            this.txtBuscarProVenta.Location = new System.Drawing.Point(489, 102);
            this.txtBuscarProVenta.Name = "txtBuscarProVenta";
            this.txtBuscarProVenta.Size = new System.Drawing.Size(298, 20);
            this.txtBuscarProVenta.TabIndex = 13;
            // 
            // lblSelecPro
            // 
            this.lblSelecPro.AutoSize = true;
            this.lblSelecPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecPro.Location = new System.Drawing.Point(14, 108);
            this.lblSelecPro.Name = "lblSelecPro";
            this.lblSelecPro.Size = new System.Drawing.Size(145, 16);
            this.lblSelecPro.TabIndex = 14;
            this.lblSelecPro.Text = "Seleccionar productos:";
            // 
            // lblDetalleVenta
            // 
            this.lblDetalleVenta.AutoSize = true;
            this.lblDetalleVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleVenta.Location = new System.Drawing.Point(12, 282);
            this.lblDetalleVenta.Name = "lblDetalleVenta";
            this.lblDetalleVenta.Size = new System.Drawing.Size(101, 16);
            this.lblDetalleVenta.TabIndex = 15;
            this.lblDetalleVenta.Text = "Detalle de veta:";
            // 
            // RealizarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.lblDetalleVenta);
            this.Controls.Add(this.lblSelecPro);
            this.Controls.Add(this.txtBuscarProVenta);
            this.Controls.Add(this.btnBuscarProVeenta);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.lblClienteV);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblFechaVentaF);
            this.Controls.Add(this.lblNomVendedor);
            this.Controls.Add(this.lblNuevaVenta);
            this.Controls.Add(this.gridRealizarVenta);
            this.Controls.Add(this.gridVentaProducto);
            this.Name = "RealizarVenta";
            this.Text = "RealizarVenta";
            ((System.ComponentModel.ISupportInitialize)(this.gridVentaProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRealizarVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridVentaProducto;
        private System.Windows.Forms.DataGridView gridRealizarVenta;
        private System.Windows.Forms.Label lblNuevaVenta;
        private System.Windows.Forms.Label lblNomVendedor;
        private System.Windows.Forms.Label lblFechaVentaF;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblClienteV;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NomProductoRV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PrecioRV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stockRV;
        private System.Windows.Forms.DataGridViewButtonColumn col_AgregarProRV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NomProductoVR;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precioUnitarioVR;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cantidadVR;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precioTotalVR;
        private System.Windows.Forms.DataGridViewButtonColumn col_EliminarProRV;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.Button btnBuscarProVeenta;
        private System.Windows.Forms.TextBox txtBuscarProVenta;
        private System.Windows.Forms.Label lblSelecPro;
        private System.Windows.Forms.Label lblDetalleVenta;
    }
}