namespace ProyectoTaller2
{
    partial class ListaProductos
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
            this.gbxProductos = new System.Windows.Forms.GroupBox();
            this.txtBuscarPro = new System.Windows.Forms.TextBox();
            this.btnBuscarPro = new System.Windows.Forms.Button();
            this.lblTilProductos = new System.Windows.Forms.Label();
            this.gridListaProductos = new System.Windows.Forms.DataGridView();
            this.col_NomProductoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PrecioP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stockP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxProductos
            // 
            this.gbxProductos.BackColor = System.Drawing.Color.Lavender;
            this.gbxProductos.Controls.Add(this.txtBuscarPro);
            this.gbxProductos.Controls.Add(this.btnBuscarPro);
            this.gbxProductos.Controls.Add(this.lblTilProductos);
            this.gbxProductos.Location = new System.Drawing.Point(12, 3);
            this.gbxProductos.Name = "gbxProductos";
            this.gbxProductos.Size = new System.Drawing.Size(776, 76);
            this.gbxProductos.TabIndex = 0;
            this.gbxProductos.TabStop = false;
            // 
            // txtBuscarPro
            // 
            this.txtBuscarPro.Location = new System.Drawing.Point(561, 36);
            this.txtBuscarPro.Name = "txtBuscarPro";
            this.txtBuscarPro.Size = new System.Drawing.Size(192, 20);
            this.txtBuscarPro.TabIndex = 2;
            // 
            // btnBuscarPro
            // 
            this.btnBuscarPro.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBuscarPro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarPro.Location = new System.Drawing.Point(468, 33);
            this.btnBuscarPro.Name = "btnBuscarPro";
            this.btnBuscarPro.Size = new System.Drawing.Size(71, 25);
            this.btnBuscarPro.TabIndex = 1;
            this.btnBuscarPro.Text = "Buscar";
            this.btnBuscarPro.UseVisualStyleBackColor = false;
            // 
            // lblTilProductos
            // 
            this.lblTilProductos.AutoSize = true;
            this.lblTilProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTilProductos.Location = new System.Drawing.Point(12, 16);
            this.lblTilProductos.Name = "lblTilProductos";
            this.lblTilProductos.Size = new System.Drawing.Size(109, 25);
            this.lblTilProductos.TabIndex = 0;
            this.lblTilProductos.Text = "Productos";
            // 
            // gridListaProductos
            // 
            this.gridListaProductos.AllowUserToAddRows = false;
            this.gridListaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridListaProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridListaProductos.BackgroundColor = System.Drawing.Color.Lavender;
            this.gridListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_NomProductoP,
            this.col_PrecioP,
            this.col_stockP});
            this.gridListaProductos.Location = new System.Drawing.Point(12, 85);
            this.gridListaProductos.Name = "gridListaProductos";
            this.gridListaProductos.Size = new System.Drawing.Size(776, 353);
            this.gridListaProductos.TabIndex = 1;
            // 
            // col_NomProductoP
            // 
            this.col_NomProductoP.HeaderText = "Nombre Producto";
            this.col_NomProductoP.Name = "col_NomProductoP";
            // 
            // col_PrecioP
            // 
            this.col_PrecioP.HeaderText = "Precio";
            this.col_PrecioP.Name = "col_PrecioP";
            // 
            // col_stockP
            // 
            this.col_stockP.HeaderText = "Stock";
            this.col_stockP.Name = "col_stockP";
            // 
            // ListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.gridListaProductos);
            this.Controls.Add(this.gbxProductos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaProductos";
            this.Text = "Lista Productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxProductos.ResumeLayout(false);
            this.gbxProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxProductos;
        private System.Windows.Forms.TextBox txtBuscarPro;
        private System.Windows.Forms.Button btnBuscarPro;
        private System.Windows.Forms.Label lblTilProductos;
        private System.Windows.Forms.DataGridView gridListaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NomProductoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PrecioP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stockP;
    }
}

