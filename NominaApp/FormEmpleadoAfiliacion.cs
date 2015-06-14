using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NominaApp
{
    public partial class FormEmpleadoAfiliacion : NominaApp.FormPadre
    {
        public FormEmpleadoAfiliacion()
        {
            InitializeComponent();
            this.IniciarCargaDatos();
        }

        protected override void CargarDatos()
        {
            this.tbempleadoTableAdapter1.Fill(this.dsNomina.TBEMPLEADO);
            this.tbempresaafiliacionTableAdapter1.Fill(this.dsNomina.TBEMPRESAAFILIACION);
            this.tbempleadoafiliacionTableAdapter1.Fill(this.dsNomina.TBEMPLEADOAFILIACION);
        }

        protected override void RecargarDatosGrid()
        {
            this.tBEMPLEADOBindingSource.ResetBindings(false);
            this.tBEMPRESAAFILIACIONBindingSource.ResetBindings(false);
            this.tBEMPLEADOAFILIACIONBindingSource.ResetBindings(false);
        }

        public override void GuardarDatos()
        {
            this.Validate();
            this.tBEMPLEADOAFILIACIONBindingSource.EndEdit();
            tbempleadoafiliacionTableAdapter1.Update(this.dsNomina.TBEMPLEADOAFILIACION);
        }
    }
}
