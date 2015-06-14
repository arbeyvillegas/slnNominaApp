﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NominaApp
{
    public partial class FormBonificacion : NominaApp.FormPadre
    {
        public FormBonificacion():base()
        {
            InitializeComponent();
            this.IniciarCargaDatos();
        }

        protected override void CargarDatos()
        {
            this.tbempleadoTableAdapter1.Fill(this.dsNomina.TBEMPLEADO);
            this.tbbonificacionTableAdapter1.Fill(this.dsNomina.TBBONIFICACION);
        }

        protected override void RecargarDatosGrid()
        {
            this.tBEMPLEADOBindingSource.ResetBindings(false);
            this.tBBONIFICACIONBindingSource.ResetBindings(false);
        }

        public override void GuardarDatos()
        {
            this.Validate();
            this.tBBONIFICACIONBindingSource.EndEdit();
            this.tbbonificacionTableAdapter1.Update(this.dsNomina.TBBONIFICACION);
        }
    }
}