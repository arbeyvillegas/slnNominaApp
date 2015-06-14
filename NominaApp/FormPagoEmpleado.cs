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
            this.IniciarCargaDatos();
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
            this.Validate();
            this.tBPAGOEMPLEADOBindingSource.EndEdit();
            this.tbpagoempleadoTableAdapter1.Update(this.dsNomina.TBPAGOEMPLEADO);
        }
    }
}
