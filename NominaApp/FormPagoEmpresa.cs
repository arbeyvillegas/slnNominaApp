using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NominaApp
{
    public partial class FormPagoEmpresa : NominaApp.FormPadre
    {
        public FormPagoEmpresa():base()
        {
            InitializeComponent();
            this.IniciarCargaDatos();
        }

        protected override void CargarDatos()
        {
            this.tbempresaafiliacionTableAdapter1.Fill(this.dsNomina.TBEMPRESAAFILIACION);
            this.tbempleadoTableAdapter1.Fill(this.dsNomina.TBEMPLEADO);
            this.tbpagoempresaTableAdapter1.Fill(this.dsNomina.TBPAGOEMPRESA);
        }

        protected override void RecargarDatosGrid()
        {
            this.tBEMPRESAAFILIACIONBindingSource.ResetBindings(false);
            this.tBEMPLEADOBindingSource.ResetBindings(false);
            this.tBPAGOEMPRESABindingSource.ResetBindings(false);
        }

        public override void GuardarDatos()
        {
            this.Validate();
            this.tBPAGOEMPRESABindingSource.EndEdit();
            this.tbpagoempresaTableAdapter1.Update(this.dsNomina.TBPAGOEMPRESA);
        }
    }
}
