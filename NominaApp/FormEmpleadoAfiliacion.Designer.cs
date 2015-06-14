namespace NominaApp
{
    partial class FormEmpleadoAfiliacion
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
            this.ePRNITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tBEMPRESAAFILIACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNomina = new NominaApp.dsNomina();
            this.ePMCEDULADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tBEMPLEADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIPOAFILIACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tBEMPLEADOAFILIACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbempleadoafiliacionTableAdapter1 = new NominaApp.DataSet1TableAdapters.TBEMPLEADOAFILIACIONTableAdapter();
            this.tbempresaafiliacionTableAdapter1 = new NominaApp.DataSet1TableAdapters.TBEMPRESAAFILIACIONTableAdapter();
            this.tbempleadoTableAdapter1 = new NominaApp.DataSet1TableAdapters.TBEMPLEADOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPRESAAFILIACIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPLEADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPLEADOAFILIACIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ePRNITDataGridViewTextBoxColumn,
            this.ePMCEDULADataGridViewTextBoxColumn,
            this.tIPOAFILIACIONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBEMPLEADOAFILIACIONBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 422);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // ePRNITDataGridViewTextBoxColumn
            // 
            this.ePRNITDataGridViewTextBoxColumn.DataPropertyName = "EPR_NIT";
            this.ePRNITDataGridViewTextBoxColumn.DataSource = this.tBEMPRESAAFILIACIONBindingSource;
            this.ePRNITDataGridViewTextBoxColumn.DisplayMember = "NOMBRE";
            this.ePRNITDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.ePRNITDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.ePRNITDataGridViewTextBoxColumn.Name = "ePRNITDataGridViewTextBoxColumn";
            this.ePRNITDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ePRNITDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ePRNITDataGridViewTextBoxColumn.ValueMember = "NIT";
            this.ePRNITDataGridViewTextBoxColumn.Width = 200;
            // 
            // tBEMPRESAAFILIACIONBindingSource
            // 
            this.tBEMPRESAAFILIACIONBindingSource.DataMember = "TBEMPRESAAFILIACION";
            this.tBEMPRESAAFILIACIONBindingSource.DataSource = this.dsNomina;
            // 
            // dsNomina
            // 
            this.dsNomina.DataSetName = "DataSet1";
            this.dsNomina.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ePMCEDULADataGridViewTextBoxColumn
            // 
            this.ePMCEDULADataGridViewTextBoxColumn.DataPropertyName = "EPM_CEDULA";
            this.ePMCEDULADataGridViewTextBoxColumn.DataSource = this.tBEMPLEADOBindingSource;
            this.ePMCEDULADataGridViewTextBoxColumn.DisplayMember = "NOMBRE";
            this.ePMCEDULADataGridViewTextBoxColumn.HeaderText = "Empleado";
            this.ePMCEDULADataGridViewTextBoxColumn.MinimumWidth = 150;
            this.ePMCEDULADataGridViewTextBoxColumn.Name = "ePMCEDULADataGridViewTextBoxColumn";
            this.ePMCEDULADataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ePMCEDULADataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ePMCEDULADataGridViewTextBoxColumn.ValueMember = "CEDULA";
            this.ePMCEDULADataGridViewTextBoxColumn.Width = 200;
            // 
            // tBEMPLEADOBindingSource
            // 
            this.tBEMPLEADOBindingSource.DataMember = "TBEMPLEADO";
            this.tBEMPLEADOBindingSource.DataSource = this.dsNomina;
            // 
            // tIPOAFILIACIONDataGridViewTextBoxColumn
            // 
            this.tIPOAFILIACIONDataGridViewTextBoxColumn.DataPropertyName = "TIPOAFILIACION";
            this.tIPOAFILIACIONDataGridViewTextBoxColumn.HeaderText = "Tipo Afiliación";
            this.tIPOAFILIACIONDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Caja Compensación",
            "EPS",
            "ICBF",
            "Pensión",
            "Sena"});
            this.tIPOAFILIACIONDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.tIPOAFILIACIONDataGridViewTextBoxColumn.Name = "tIPOAFILIACIONDataGridViewTextBoxColumn";
            this.tIPOAFILIACIONDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tIPOAFILIACIONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tIPOAFILIACIONDataGridViewTextBoxColumn.Width = 150;
            // 
            // tBEMPLEADOAFILIACIONBindingSource
            // 
            this.tBEMPLEADOAFILIACIONBindingSource.DataMember = "TBEMPLEADOAFILIACION";
            this.tBEMPLEADOAFILIACIONBindingSource.DataSource = this.dsNomina;
            this.tBEMPLEADOAFILIACIONBindingSource.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.tBEMPLEADOAFILIACIONBindingSource_DataError);
            // 
            // tbempleadoafiliacionTableAdapter1
            // 
            this.tbempleadoafiliacionTableAdapter1.ClearBeforeFill = true;
            // 
            // tbempresaafiliacionTableAdapter1
            // 
            this.tbempresaafiliacionTableAdapter1.ClearBeforeFill = true;
            // 
            // tbempleadoTableAdapter1
            // 
            this.tbempleadoTableAdapter1.ClearBeforeFill = true;
            // 
            // FormEmpleadoAfiliacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(659, 422);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormEmpleadoAfiliacion";
            this.Text = "Empleado Afiliación";
            this.Load += new System.EventHandler(this.FormEmpleadoAfiliacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPRESAAFILIACIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPLEADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPLEADOAFILIACIONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tBEMPLEADOAFILIACIONBindingSource;
        private dsNomina dsNomina;
        private DataSet1TableAdapters.TBEMPLEADOAFILIACIONTableAdapter tbempleadoafiliacionTableAdapter1;
        private DataSet1TableAdapters.TBEMPRESAAFILIACIONTableAdapter tbempresaafiliacionTableAdapter1;
        private DataSet1TableAdapters.TBEMPLEADOTableAdapter tbempleadoTableAdapter1;
        private System.Windows.Forms.BindingSource tBEMPRESAAFILIACIONBindingSource;
        private System.Windows.Forms.BindingSource tBEMPLEADOBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn ePRNITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ePMCEDULADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tIPOAFILIACIONDataGridViewTextBoxColumn;
    }
}
