
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
            this.IniciarCargaDatos();
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
            this.Validate();
            this.tBCONFIGEMPBindingSource.EndEdit();
            tbconfigempTableAdapter1.Update(this.dsNomina.TBCONFIGEMP);
        }
    }
}
