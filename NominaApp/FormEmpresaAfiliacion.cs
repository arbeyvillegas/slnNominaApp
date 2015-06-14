using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NominaApp
{
    public partial class FormEmpresaAfiliacion : NominaApp.FormPadre
    {
        public FormEmpresaAfiliacion():base()
        {
            InitializeComponent();
            this.IniciarCargaDatos();
        }

        protected override void CargarDatos()
        {
            this.tbempresaafiliacionTableAdapter1.Fill(this.dsNomina.TBEMPRESAAFILIACION);
        }

        protected override void RecargarDatosGrid()
        {
            this.tBEMPRESAAFILIACIONBindingSource.ResetBindings(false);
        }

        public override void GuardarDatos()
        {
            this.Validate();
            this.tBEMPRESAAFILIACIONBindingSource.EndEdit();
            this.tbempresaafiliacionTableAdapter1.Update(this.dsNomina.TBEMPRESAAFILIACION);
        }
    }
}
