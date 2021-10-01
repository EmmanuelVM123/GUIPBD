using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIPBD
{
    public partial class fEmpresa : Form
    {
        public fEmpresa()
        {
            InitializeComponent();
        }

        private void empresaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empresaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.progBasDatDataSet);

        }

        private void fEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'progBasDatDataSet.Empresa' Puede moverla o quitarla según sea necesario.
            this.empresaTableAdapter.Fill(this.progBasDatDataSet.Empresa);

        }

        private void CargaDatos()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la carga de datos: " + ex.Message.ToString());              
            }
        }

        private void ModoEdicion(string modo)
        {
            switch (modo)
            {
                case "Lectura":
                    this.pnlBotones.Enabled = true;
                    this.pnlDetalles.Enabled = false;
                    this.empresaDataGridView.Enabled = true;
                    this.empresaBindingNavigator.Enabled = true;
                    break;

                case "Insertar":
                    this.pnlBotones.Enabled = false;
                    this.pnlDetalles.Enabled = true;
                    this.empresaDataGridView.Enabled = false;
                    this.empresaBindingNavigator.Enabled = false;
                    break;

                case "Actualizarr":
                    this.pnlBotones.Enabled = false;
                    this.pnlDetalles.Enabled = true;
                    this.empresaDataGridView.Enabled = false;
                    this.empresaBindingNavigator.Enabled = false;
                    break;
            }

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.ModoEdicion("Insertar");
            this.idEmpresaTextBox.Text = "";
            this.razonSocialTextBox.Text = "";
            this.razonSocialTextBox.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.ModoEdicion("Actualizar");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    //Ejercutar el Delete de la tabla
                }
                else
                {
                    this.CargaDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar: " + ex.Message.ToString());
            }
        }
    }
}
