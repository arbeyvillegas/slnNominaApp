using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NominaApp
{
    public partial class FormLiquidacionNomina : NominaApp.FormPadre
    {
        public FormLiquidacionNomina():base()
        {
            InitializeComponent();
            this.IniciarCargaDatos();
        }

        protected override void CargarDatos()
        {
            this.tbempleadoTableAdapter1.Fill(this.dsNomina.TBEMPLEADO);
            this.tbliqnominaTableAdapter1.Fill(this.dsNomina.TBLIQNOMINA);
        }

        protected override void RecargarDatosGrid()
        {
            this.tBEMPLEADOBindingSource.ResetBindings(false);
            this.tBLIQNOMINABindingSource.ResetBindings(false);
        }

        public override void GuardarDatos()
        {
            this.Validate();
            this.tBLIQNOMINABindingSource.EndEdit();
            this.tbliqnominaTableAdapter1.Update(this.dsNomina.TBLIQNOMINA);
        }
    }
}
