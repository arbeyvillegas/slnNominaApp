using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NominaApp
{
    public partial class FormEmpresaAfiliacion : NominaApp.FormPadre
    {
        public FormEmpresaAfiliacion():base()
        {
            InitializeComponent();
        }

        protected override void CargarDatos()
        {
            this.tbempresaafiliacionTableAdapter1.Fill(this.dsNomina.TBEMPRESAAFILIACION);
        }

        protected override void RecargarDatosGrid()
        {
            this.tBEMPRESAAFILIACIONBindingSource.ResetBindings(false);
        }

        public override void GuardarDatos()
        {
            try
            {
                this.Validate();
                this.tBEMPRESAAFILIACIONBindingSource.EndEdit();
                this.tbempresaafiliacionTableAdapter1.Update(this.dsNomina.TBEMPRESAAFILIACION);
                this.EstablecerMensajeActualizacion("Empresas actualizadas satisfactoriamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar los datos: " + ex.Message);
            }
        }

        private void tBEMPRESAAFILIACIONBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            this.BindingSource_DataError(sender, e);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            this.dataGridView_DataError(sender, e);
        }

        private void FormEmpresaAfiliacion_Load(object sender, EventArgs e)
        {
            this.IniciarCargaDatos();
        }
    }
}
