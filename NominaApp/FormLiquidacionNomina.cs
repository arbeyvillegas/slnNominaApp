using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NominaApp
{
    public partial class FormLiquidacionNomina : NominaApp.FormPadre
    {
        public FormLiquidacionNomina():base()
        {
            InitializeComponent();
        }

        protected override void CargarDatos()
        {
            this.tbempleadoTableAdapter1.Fill(this.dsNomina.TBEMPLEADO);
            this.tbliqnominaTableAdapter1.Fill(this.dsNomina.TBLIQNOMINA);
        }

        protected override void RecargarDatosGrid()
        {
            this.tBEMPLEADOBindingSource.ResetBindings(false);
            this.tBLIQNOMINABindingSource.ResetBindings(false);
        }

        public override void GuardarDatos()
        {
            try
            {
                this.Validate();
                this.tBLIQNOMINABindingSource.EndEdit();
                this.tbliqnominaTableAdapter1.Update(this.dsNomina.TBLIQNOMINA);
                this.EstablecerMensajeActualizacion("Liquidación de nómina actualizada satisfactoriamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar los datos: " + ex.Message);

            }
        }

        private void tBLIQNOMINABindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            this.BindingSource_DataError(sender, e);

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            this.dataGridView_DataError(sender, e);

        }

        private void FormLiquidacionNomina_Load(object sender, EventArgs e)
        {
            this.IniciarCargaDatos();
        }
    }
}
