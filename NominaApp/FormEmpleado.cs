using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NominaApp
{
    public partial class FormEmpleado : NominaApp.FormPadre
    {
        public FormEmpleado():base()
        {
            InitializeComponent();
            this.IniciarCargaDatos();
        }
        protected override void CargarDatos()
        {
            this.tbempleadoTableAdapter1.Fill(this.dsNomina.TBEMPLEADO);
        }

        protected override void RecargarDatosGrid()
        {
            this.tBEMPLEADOBindingSource.ResetBindings(false);
        }

        public override void GuardarDatos()
        {
            this.Validate();
            this.tBEMPLEADOBindingSource.EndEdit();
            this.tbempleadoTableAdapter1.Update(this.dsNomina.TBEMPLEADO);
        }
    }
}
