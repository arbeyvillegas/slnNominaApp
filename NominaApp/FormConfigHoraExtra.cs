﻿using System;
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
            this.IniciarCargaDatos();
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
            this.Validate();
            tBCONFIGHORAEXTRABindingSource.EndEdit();
            tbconfighoraextraTableAdapter1.Update(this.dsNomina.TBCONFIGHORAEXTRA);
        }
    }
}
