using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NominaApp
{
    public partial class FormPagoEmpresa : NominaApp.FormPadre
    {
        public FormPagoEmpresa():base()
        {
            InitializeComponent();
        }

        protected override void CargarDatos()
        {
            this.tbempresaafiliacionTableAdapter1.Fill(this.dsNomina.TBEMPRESAAFILIACION);
            this.tbempleadoTableAdapter1.Fill(this.dsNomina.TBEMPLEADO);
            this.tbpagoempresaTableAdapter1.Fill(this.dsNomina.TBPAGOEMPRESA);
        }

        protected override void RecargarDatosGrid()
        {
            this.tBEMPRESAAFILIACIONBindingSource.ResetBindings(false);
            this.tBEMPLEADOBindingSource.ResetBindings(false);
            this.tBPAGOEMPRESABindingSource.ResetBindings(false);
        }

        public override void GuardarDatos()
        {
            try
            {
                this.Validate();
                this.tBPAGOEMPRESABindingSource.EndEdit();
                this.tbpagoempresaTableAdapter1.Update(this.dsNomina.TBPAGOEMPRESA);
                this.EstablecerMensajeActualizacion("Pagos empresas actualizados satisfactoriamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar los datos: " + ex.Message);
            }
        }

        private void tBPAGOEMPRESABindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            this.BindingSource_DataError(sender, e);

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            this.dataGridView_DataError(sender, e);

        }

        private void FormPagoEmpresa_Load(object sender, EventArgs e)
        {
            this.IniciarCargaDatos();
        }
    }
}
