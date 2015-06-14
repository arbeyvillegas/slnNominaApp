using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NominaApp
{
    public partial class FormHoraExtra : NominaApp.FormPadre
    {
        public FormHoraExtra():base()
        {
            InitializeComponent();
        }

        protected override void CargarDatos()
        {
            this.tbempleadoTableAdapter1.Fill(this.dsNomina.TBEMPLEADO);
            this.tbconfighoraextraTableAdapter1.Fill(this.dsNomina.TBCONFIGHORAEXTRA);
            this.tbhoraextraTableAdapter1.Fill(this.dsNomina.TBHORAEXTRA);
        }

        protected override void RecargarDatosGrid()
        {
            this.tBEMPLEADOBindingSource.ResetBindings(false);
            this.tBCONFIGHORAEXTRABindingSource.ResetBindings(false);
            this.tBHORAEXTRABindingSource.ResetBindings(false);
        }

        public override void GuardarDatos()
        {
            try
            {
                this.Validate();
                this.tBHORAEXTRABindingSource.EndEdit();
                this.tbhoraextraTableAdapter1.Update(this.dsNomina.TBHORAEXTRA);
                this.EstablecerMensajeActualizacion("Horas extras actualizadas satisfactoriamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar los datos: " + ex.Message);

            }
        }

        private void tBHORAEXTRABindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            this.BindingSource_DataError(sender, e);

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            this.dataGridView_DataError(sender, e);

        }

        private void FormHoraExtra_Load(object sender, EventArgs e)
        {
            this.IniciarCargaDatos();
        }
    }
}
