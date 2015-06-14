using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NominaApp
{
    public partial class FormEmpleado : NominaApp.FormPadre
    {
        public FormEmpleado():base()
        {
            InitializeComponent();
        }
        protected override void CargarDatos()
        {
            this.tbempleadoTableAdapter1.Fill(this.dsNomina.TBEMPLEADO);
        }

        protected override void RecargarDatosGrid()
        {
            this.tBEMPLEADOBindingSource.ResetBindings(false);
        }

        public override void GuardarDatos()
        {
            try
            {
                this.Validate();
                this.tBEMPLEADOBindingSource.EndEdit();
                this.tbempleadoTableAdapter1.Update(this.dsNomina.TBEMPLEADO);
                this.EstablecerMensajeActualizacion("Empleados actualizados satisfactoriamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar los datos: " + ex.Message);

            }
        }

        private void tBEMPLEADOBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            this.BindingSource_DataError(sender, e);

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            this.dataGridView_DataError(sender, e);

        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            this.IniciarCargaDatos();
        }
    }
}
