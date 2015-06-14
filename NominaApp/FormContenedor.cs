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
    public partial class FormContenedor : Form
    {
        private int childFormNumber = 0;

        

        public FormContenedor()
        {
            CultureInfo cultureInfo = new CultureInfo("es-CO");
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void configuracionHoraExtraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormlario<FormConfigHoraExtra>();
            
        }

        private void AbrirFormlario<T>() where T:FormPadre,new()
        {
            T formulario = this.ExisteFormulario<T>();
            if (formulario == null)
            {
                formulario = new T();
                formulario.IniciarProgreso =new IniciaProgresoDelegate(IniciarProgreso) ;
                formulario.TerminarProgreso = new TerminaProgresoDelegate(FinalizarProgreso);
                formulario.EstablecerMensaje = new EstablecerMensajeDelegate(EstablecerMensajeEstado);
                formulario.MdiParent = this;
                formulario.Show();
                formulario.WindowState = FormWindowState.Maximized;
            }
            else
            {
                formulario.Activate();
                if (formulario.WindowState != FormWindowState.Maximized)
                {
                    formulario.WindowState = FormWindowState.Maximized;
                }
            }
        }

        public void IniciarProgreso()
        {
            this.toolStripStatusLabel.Text = "Consultando";
            this.toolStripProgressBar1.Visible = true;
        }

        public void FinalizarProgreso()
        {
            this.toolStripStatusLabel.Text = string.Empty;
            this.toolStripProgressBar1.Visible = false;
        }

        private T ExisteFormulario<T>() where T : FormPadre
        {
            T formulario = null;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if(typeof(T)== this.MdiChildren[i].GetType()){
                    formulario = (T)this.MdiChildren[i];
                    break;
                }
            }
            return formulario;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (HasChildren)
            {
                FormPadre formPadre = this.ActiveMdiChild as FormPadre;
                if (formPadre != null)
                {
                    formPadre.GuardarDatos();
                }
            }
        }

        private void configuracionEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormlario<FormConfigEmpleado>();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormlario<FormEmpleado>();
        }

        private void empresaAfiliacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormlario<FormEmpresaAfiliacion>();
        }

        private void afiliarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormlario<FormEmpleadoAfiliacion>();
        }

        private void bonificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormlario<FormBonificacion>();
        }

        private void deduccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormlario<FormDeduccion>();
        }

        private void horasExtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormlario<FormHoraExtra>();
        }

        private void liquidacionNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormlario<FormLiquidacionNomina>();
        }

        private void pagoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormlario<FormPagoEmpleado>();
        }

        private void pagoEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormlario<FormPagoEmpresa>();
        }

        public void EstablecerMensajeEstado(string mensaje)
        {
            this.toolStripStatusLabel.Text = mensaje;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
