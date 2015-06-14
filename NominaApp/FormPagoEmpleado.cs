using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NominaApp
{
    public partial class FormPagoEmpleado : NominaApp.FormPadre
    {
        public FormPagoEmpleado()
        {
            InitializeComponent();
        }

        protected override void CargarDatos()
        {
            this.tbempleadoTableAdapter1.Fill(this.dsNomina.TBEMPLEADO);
            this.tbpagoempleadoTableAdapter1.Fill(this.dsNomina.TBPAGOEMPLEADO);
        }

        protected override void RecargarDatosGrid()
        {
            this.tBEMPLEADOBindingSource.ResetBindings(false);
            this.tBPAGOEMPLEADOBindingSource.ResetBindings(false);
        }

        public override void GuardarDatos()
        {
            try
            {
                this.Validate();
                this.tBPAGOEMPLEADOBindingSource.EndEdit();
                this.tbpagoempleadoTableAdapter1.Update(this.dsNomina.TBPAGOEMPLEADO);
                this.EstablecerMensajeActualizacion("Pagos empleados actualizados satisfactoriamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar los datos: " + ex.Message);
            }
        }

        private void tBPAGOEMPLEADOBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            this.BindingSource_DataError(sender, e);

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            this.dataGridView_DataError(sender, e);

        }

        private void FormPagoEmpleado_Load(object sender, EventArgs e)
        {
            this.IniciarCargaDatos();
        }


    }
}
