using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NominaApp
{
    public partial class FormPadre : Form
    {

        protected BindingSource bindingSource;

        public FormPadre()
        {
            CultureInfo cultureInfo = new CultureInfo("es-CO");
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
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
            if (e.Error == null)
            {
                this.RecargarDatosGrid();
            }
            else
            {
                MessageBox.Show("Ocurrio error en la conexión (Revise la cadena de conexión en .config): " + e.Error.Message);
            }
            
        }


        public virtual void GuardarDatos()
        {
            throw new NotImplementedException();
        }

        public void BindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            MessageBox.Show("Ocurrió un error al actualizar los datos: " + e.Exception.Message);
        }

        public void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ocurrió un error al actualizar los datos: " + e.Exception.Message);
        }
    }
}
