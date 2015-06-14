using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NominaApp
{
    public partial class FormEmpleadoAfiliacion : NominaApp.FormPadre
    {
        public FormEmpleadoAfiliacion():base()
        {
            InitializeComponent();
        }

        protected override void CargarDatos()
        {
            this.tbempleadoTableAdapter1.Fill(this.dsNomina.TBEMPLEADO);
            this.tbempresaafiliacionTableAdapter1.Fill(this.dsNomina.TBEMPRESAAFILIACION);
            this.tbempleadoafiliacionTableAdapter1.Fill(this.dsNomina.TBEMPLEADOAFILIACION);
        }

        protected override void RecargarDatosGrid()
        {
            this.tBEMPLEADOBindingSource.ResetBindings(false);
            this.tBEMPRESAAFILIACIONBindingSource.ResetBindings(false);
            this.tBEMPLEADOAFILIACIONBindingSource.ResetBindings(false);
        }

        public override void GuardarDatos()
        {
            try
            {
                this.Validate();
                this.tBEMPLEADOAFILIACIONBindingSource.EndEdit();
                tbempleadoafiliacionTableAdapter1.Update(this.dsNomina.TBEMPLEADOAFILIACION);
                this.EstablecerMensajeActualizacion("Afiliación empleado actualizada satisfactoriamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar los datos: " + ex.Message);

            }
        }

        private void tBEMPLEADOAFILIACIONBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            this.BindingSource_DataError(sender, e);

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            this.dataGridView_DataError(sender, e);

        }

        private void FormEmpleadoAfiliacion_Load(object sender, EventArgs e)
        {
            this.IniciarCargaDatos();
        }
    }
}
