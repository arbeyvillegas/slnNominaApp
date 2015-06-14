using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NominaApp
{
    public partial class FormDeduccion : NominaApp.FormPadre
    {
        public FormDeduccion():base()
        {
            InitializeComponent();
        }

        protected override void CargarDatos()
        {
            this.tbempleadoTableAdapter1.Fill(this.dsNomina.TBEMPLEADO);
            this.tbdeduccionTableAdapter1.Fill(this.dsNomina.TBDEDUCCION);
        }

        protected override void RecargarDatosGrid()
        {
            this.tBEMPLEADOBindingSource.ResetBindings(false);
            this.tBDEDUCCIONBindingSource.ResetBindings(false);
        }

        public override void GuardarDatos()
        {
            try
            {
                this.Validate();
                this.tBDEDUCCIONBindingSource.EndEdit();
                this.tbdeduccionTableAdapter1.Update(this.dsNomina.TBDEDUCCION);
                this.EstablecerMensajeActualizacion("Deducciones actualizadas satisfactoriamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar los datos: " + ex.Message);
            }
        }

        private void tBDEDUCCIONBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            this.BindingSource_DataError(sender, e);
    
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            this.dataGridView_DataError(sender, e);

        }

        private void FormDeduccion_Load(object sender, EventArgs e)
        {
            this.IniciarCargaDatos();
        }
    }
}
