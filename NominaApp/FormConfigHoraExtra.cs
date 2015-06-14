using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NominaApp
{
    public partial class FormConfigHoraExtra : NominaApp.FormPadre
    {
        public FormConfigHoraExtra():base()
        {
            InitializeComponent();
        }

        protected override void CargarDatos()
        {
            tbconfighoraextraTableAdapter1.Fill(this.dsNomina.TBCONFIGHORAEXTRA);
        }

        protected override void RecargarDatosGrid()
        {
            tBCONFIGHORAEXTRABindingSource.ResetBindings(false);
        }

        public override void GuardarDatos()
        {
            try
            {
                this.Validate();
                tBCONFIGHORAEXTRABindingSource.EndEdit();
                tbconfighoraextraTableAdapter1.Update(this.dsNomina.TBCONFIGHORAEXTRA);
                this.EstablecerMensajeActualizacion("Configuración hora extra actualizada satisfactoriamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar los datos: " + ex.Message);
            }
        }

        private void tBCONFIGHORAEXTRABindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            this.BindingSource_DataError(sender, e);

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            this.dataGridView_DataError(sender, e);

        }

        private void FormConfigHoraExtra_Load(object sender, EventArgs e)
        {
            this.IniciarCargaDatos();
        }
    }
}
