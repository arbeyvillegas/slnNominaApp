
namespace NominaApp
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;
    public partial class FormConfigEmpleado : Form
    {
        public FormConfigEmpleado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.tbempleadoTableAdapter1.Fill(this.dsNomina.TBEMPLEADO);
            this.tbconfigempTableAdapter1.Fill(this.dsNomina.TBCONFIGEMP);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tBEMPLEADOBindingSource.ResetBindings(false);
            tBCONFIGEMPBindingSource.ResetBindings(false);
        }
    }
}
