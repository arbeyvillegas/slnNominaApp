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
            this.IniciarCargaDatos();
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
            this.Validate();
            this.tBDEDUCCIONBindingSource.EndEdit();
            this.tbdeduccionTableAdapter1.Update(this.dsNomina.TBDEDUCCION);
        }
    }
}
