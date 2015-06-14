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
    public delegate void IniciaProgresoDelegate();

    public delegate void TerminaProgresoDelegate();

    public delegate void EstablecerMensajeDelegate(string mensaje);

    public partial class FormPadre : Form
    {

        public IniciaProgresoDelegate IniciarProgreso;
        public TerminaProgresoDelegate TerminarProgreso;
        public EstablecerMensajeDelegate EstablecerMensaje;
        

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
            if (this.IniciarProgreso != null)
            {
                this.IniciarProgreso();
            }
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

            if (this.TerminarProgreso != null)
            {
                this.TerminarProgreso();
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

        public void EstablecerMensajeActualizacion(string mensaje)
        {
            if (this.EstablecerMensaje != null)
            {
                this.EstablecerMensaje(mensaje);
            }
        }
    }
}
