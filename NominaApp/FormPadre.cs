using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NominaApp
{
    public partial class FormPadre : Form
    {
        public FormPadre()
        {
            InitializeComponent();
            
        }

        protected virtual void CargarDatos()
        {
            throw new NotImplementedException();
        }

        protected virtual void RecargarDatosGrid()
        {
            throw new NotImplementedException();
        }

        protected void IniciarCargaDatos()
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.CargarDatos();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.RecargarDatosGrid();
        }
        

        
    }
}
