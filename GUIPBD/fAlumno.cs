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
    public partial class fAlumno : Form
    {
        string Modo = "";
        public fAlumno()
        {
            InitializeComponent();
        }

        private void alumnoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alumnoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.progBasDatDataSet);

        }

        private void fAlumno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'progBasDatDataSet.Alumno' Puede moverla o quitarla según sea necesario.
            this.CargaDatos();

        }

        private void CargaDatos()
        {
            try
            {
                this.alumnoTableAdapter.Fill(this.progBasDatDataSet.Alumno);
                this.ModoEdicion("Lectura");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la carga de datos: " + ex.Message.ToString());
            }
        }

        private void ModoEdicion(string modo)
        {
            this.Modo = modo;
            switch (modo)
            {
                case "Lectura":
                    this.pnlBotones.Enabled = true;
                    this.pnlDetalles.Enabled = false;
                    this.alumnoDataGridView.Enabled = true;
                    this.alumnoBindingNavigator.Enabled = true;
                    break;

                case "Insertar":
                    this.pnlBotones.Enabled = false;
                    this.pnlDetalles.Enabled = true;
                    this.alumnoDataGridView.Enabled = false;
                    this.alumnoBindingNavigator.Enabled = false;
                    break;

                case "Actualizar":
                    this.pnlBotones.Enabled = false;
                    this.pnlDetalles.Enabled = true;
                    this.alumnoDataGridView.Enabled = false;
                    this.alumnoBindingNavigator.Enabled = false;
                    break;
            }

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.ModoEdicion("Insertar");
            this.idAlumnoTextBox.Text = "";
            this.nombreTextBox.Text = "";
            this.nombreTextBox.Focus();
            this.primerApellidoTextBox.Text= "";
            this.segundoApellidoTextBox.Text = "";
            this.nombreTextBox.Text = "";
            this.emailTextBox.Text = "";
            this.telefonoTextBox.Text = "";
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
                    //Ejercutar el Deleted de la tabla
                    int id = int.Parse(this.idAlumnoTextBox.Text);
                    this.alumnoTableAdapter.Delete(id);
                    this.CargaDatos();
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

        private bool Valida()
        {
            this.errorProvider1.Clear();
            bool validado = true;
            if (this.nombreTextBox.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.nombreTextBox, "¡Campo requido!");
            }
            if (this.primerApellidoTextBox.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.primerApellidoTextBox, "¡Campo requido!");
            }
            if (this.segundoApellidoTextBox.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.segundoApellidoTextBox, "¡Campo requido!");
            }
            if (this.nuControlTextBox.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.nuControlTextBox, "¡Campo requido!");
            }
            if (this.emailTextBox.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.emailTextBox, "¡Campo requido!");
            }
            if (this.telefonoTextBox.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.telefonoTextBox, "¡Campo requido!");
            }
            return validado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Valida())
                {
                    switch (Modo)
                    {
                        case "Insertar":
                            //Ejecutar el insert de la tabla Empresa.
                            this.alumnoTableAdapter.Insert(this.nombreTextBox.Text, this.primerApellidoTextBox.Text, this.segundoApellidoTextBox.Text, nuControlTextBox.Text, this.emailTextBox.Text, this.telefonoTextBox.Text);
                            break;
                        case "Actualizar":
                            //Ejecutar el Update de la tabla empresa
                            int id = int.Parse(this.idAlumnoTextBox.Text);
                            this.alumnoTableAdapter.Update(this.nombreTextBox.Text, this.primerApellidoTextBox.Text, this.segundoApellidoTextBox.Text, nuControlTextBox.Text, this.emailTextBox.Text, this.telefonoTextBox.Text, id);
                            break;
                    }
                    this.CargaDatos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());
            }
        }
    }
}
