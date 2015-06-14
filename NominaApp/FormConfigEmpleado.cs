
namespace NominaApp
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;
    public partial class FormConfigEmpleado  : NominaApp.FormPadre
    {
        public FormConfigEmpleado():base()
        {
            InitializeComponent();
        }


        protected override void CargarDatos()
        {
            this.tbempleadoTableAdapter1.Fill(this.dsNomina.TBEMPLEADO);
            this.tbconfigempTableAdapter1.Fill(this.dsNomina.TBCONFIGEMP);
        }

        protected override void RecargarDatosGrid()
        {
            tBEMPLEADOBindingSource.ResetBindings(false);
            tBCONFIGEMPBindingSource.ResetBindings(false);
        }

        public override void GuardarDatos()
        {
            try
            {
                this.Validate();
                this.tBCONFIGEMPBindingSource.EndEdit();
                tbconfigempTableAdapter1.Update(this.dsNomina.TBCONFIGEMP);
                this.EstablecerMensajeActualizacion("Configuración empleado actualizado satisfactoriamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar los datos: " + ex.Message);
            }
        }

        private void tBCONFIGEMPBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            this.BindingSource_DataError(sender, e);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            this.dataGridView_DataError(sender, e);
        }

        private void FormConfigEmpleado_Load(object sender, EventArgs e)
        {
            this.IniciarCargaDatos();
        }
    }
}
