using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.C_Presentaciones.Vendedor
{
    public partial class MenuVendedor : Form
    {
        private int childFormNumber = 0;

        public MenuVendedor()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void CargarFormularioEnPanel(Form formulario, Panel panelDestino)
        {
            // Limpiar cualquier control anterior en el panel destino
            panelDestino.Controls.Clear();

            // Configurar el formulario como hijo de este contenedor (MDI)
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agregar el formulario al panel destino y mostrarlo
            panelDestino.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnListaProductos_Click(object sender, EventArgs e)
        {
            ListaProductos productosForm = new ListaProductos();
            CargarFormularioEnPanel(new ListaProductos(), panelMuestra);
        }

        private void btnMisVentas_Click(object sender, EventArgs e)
        {
            ListaVentasRealizadas productosForm = new ListaVentasRealizadas();
            CargarFormularioEnPanel(new ListaVentasRealizadas(), panelMuestra);
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            RealizarVenta productosForm = new RealizarVenta();
            CargarFormularioEnPanel(new RealizarVenta(), panelMuestra);
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            AltaCliente productosForm = new AltaCliente();
            CargarFormularioEnPanel(new AltaCliente(), panelMuestra);
        }

        private void btnCancelarAltaC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
