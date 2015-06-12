namespace NominaApp
{
    partial class FormConfigEmpleado
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsNomina = new NominaApp.dsNomina();
            this.tBCONFIGEMPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbconfigempTableAdapter1 = new NominaApp.DataSet1TableAdapters.TBCONFIGEMPTableAdapter();
            this.tbempleadoTableAdapter1 = new NominaApp.DataSet1TableAdapters.TBEMPLEADOTableAdapter();
            this.tBEMPLEADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPCEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sALARIOBASEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUXTRANSPORTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORHORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPJEFEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCONFIGEMPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPLEADOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPCEDDataGridViewTextBoxColumn,
            this.sALARIOBASEDataGridViewTextBoxColumn,
            this.aUXTRANSPORTEDataGridViewTextBoxColumn,
            this.vALORDIADataGridViewTextBoxColumn,
            this.vALORHORADataGridViewTextBoxColumn,
            this.eMPJEFEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBCONFIGEMPBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(596, 431);
            this.dataGridView1.TabIndex = 0;
            // 
            // dsNomina
            // 
            this.dsNomina.DataSetName = "DataSet1";
            this.dsNomina.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBCONFIGEMPBindingSource
            // 
            this.tBCONFIGEMPBindingSource.DataMember = "TBCONFIGEMP";
            this.tBCONFIGEMPBindingSource.DataSource = this.dsNomina;
            // 
            // tbconfigempTableAdapter1
            // 
            this.tbconfigempTableAdapter1.ClearBeforeFill = true;
            // 
            // tbempleadoTableAdapter1
            // 
            this.tbempleadoTableAdapter1.ClearBeforeFill = true;
            // 
            // tBEMPLEADOBindingSource
            // 
            this.tBEMPLEADOBindingSource.DataMember = "TBEMPLEADO";
            this.tBEMPLEADOBindingSource.DataSource = this.dsNomina;
            // 
            // eMPCEDDataGridViewTextBoxColumn
            // 
            this.eMPCEDDataGridViewTextBoxColumn.DataPropertyName = "EMP_CED";
            this.eMPCEDDataGridViewTextBoxColumn.DataSource = this.tBEMPLEADOBindingSource;
            this.eMPCEDDataGridViewTextBoxColumn.DisplayMember = "NOMBRE";
            this.eMPCEDDataGridViewTextBoxColumn.HeaderText = "EMP_CED";
            this.eMPCEDDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.eMPCEDDataGridViewTextBoxColumn.Name = "eMPCEDDataGridViewTextBoxColumn";
            this.eMPCEDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eMPCEDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eMPCEDDataGridViewTextBoxColumn.ValueMember = "CEDULA";
            this.eMPCEDDataGridViewTextBoxColumn.Width = 200;
            // 
            // sALARIOBASEDataGridViewTextBoxColumn
            // 
            this.sALARIOBASEDataGridViewTextBoxColumn.DataPropertyName = "SALARIOBASE";
            this.sALARIOBASEDataGridViewTextBoxColumn.HeaderText = "SALARIOBASE";
            this.sALARIOBASEDataGridViewTextBoxColumn.Name = "sALARIOBASEDataGridViewTextBoxColumn";
            // 
            // aUXTRANSPORTEDataGridViewTextBoxColumn
            // 
            this.aUXTRANSPORTEDataGridViewTextBoxColumn.DataPropertyName = "AUXTRANSPORTE";
            this.aUXTRANSPORTEDataGridViewTextBoxColumn.HeaderText = "AUXTRANSPORTE";
            this.aUXTRANSPORTEDataGridViewTextBoxColumn.Name = "aUXTRANSPORTEDataGridViewTextBoxColumn";
            // 
            // vALORDIADataGridViewTextBoxColumn
            // 
            this.vALORDIADataGridViewTextBoxColumn.DataPropertyName = "VALORDIA";
            this.vALORDIADataGridViewTextBoxColumn.HeaderText = "VALORDIA";
            this.vALORDIADataGridViewTextBoxColumn.Name = "vALORDIADataGridViewTextBoxColumn";
            // 
            // vALORHORADataGridViewTextBoxColumn
            // 
            this.vALORHORADataGridViewTextBoxColumn.DataPropertyName = "VALORHORA";
            this.vALORHORADataGridViewTextBoxColumn.HeaderText = "VALORHORA";
            this.vALORHORADataGridViewTextBoxColumn.Name = "vALORHORADataGridViewTextBoxColumn";
            // 
            // eMPJEFEDataGridViewTextBoxColumn
            // 
            this.eMPJEFEDataGridViewTextBoxColumn.DataPropertyName = "EMP_JEFE";
            this.eMPJEFEDataGridViewTextBoxColumn.DataSource = this.tBEMPLEADOBindingSource;
            this.eMPJEFEDataGridViewTextBoxColumn.DisplayMember = "NOMBRE";
            this.eMPJEFEDataGridViewTextBoxColumn.HeaderText = "EMP_JEFE";
            this.eMPJEFEDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.eMPJEFEDataGridViewTextBoxColumn.Name = "eMPJEFEDataGridViewTextBoxColumn";
            this.eMPJEFEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eMPJEFEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eMPJEFEDataGridViewTextBoxColumn.ValueMember = "CEDULA";
            this.eMPJEFEDataGridViewTextBoxColumn.Width = 200;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 431);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCONFIGEMPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPLEADOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tBCONFIGEMPBindingSource;
        private dsNomina dsNomina;
        private DataSet1TableAdapters.TBCONFIGEMPTableAdapter tbconfigempTableAdapter1;
        private DataSet1TableAdapters.TBEMPLEADOTableAdapter tbempleadoTableAdapter1;
        private System.Windows.Forms.BindingSource tBEMPLEADOBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn eMPCEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALARIOBASEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUXTRANSPORTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORHORADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn eMPJEFEDataGridViewTextBoxColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

