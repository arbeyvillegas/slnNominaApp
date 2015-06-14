namespace NominaApp
{
    partial class FormPagoEmpresa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBPAGOEMPRESABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNomina = new NominaApp.dsNomina();
            this.tbempleadoTableAdapter1 = new NominaApp.DataSet1TableAdapters.TBEMPLEADOTableAdapter();
            this.tbpagoempresaTableAdapter1 = new NominaApp.DataSet1TableAdapters.TBPAGOEMPRESATableAdapter();
            this.tbempresaafiliacionTableAdapter1 = new NominaApp.DataSet1TableAdapters.TBEMPRESAAFILIACIONTableAdapter();
            this.tBEMPRESAAFILIACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBEMPLEADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ePRNITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.eMPCEDULADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tIPOAFILIACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORPAGADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPAGOEMPRESABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPRESAAFILIACIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPLEADOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ePRNITDataGridViewTextBoxColumn,
            this.eMPCEDULADataGridViewTextBoxColumn,
            this.tIPOAFILIACIONDataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn,
            this.vALORPAGADODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBPAGOEMPRESABindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // tBPAGOEMPRESABindingSource
            // 
            this.tBPAGOEMPRESABindingSource.DataMember = "TBPAGOEMPRESA";
            this.tBPAGOEMPRESABindingSource.DataSource = this.dsNomina;
            // 
            // dsNomina
            // 
            this.dsNomina.DataSetName = "DataSet1";
            this.dsNomina.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbempleadoTableAdapter1
            // 
            this.tbempleadoTableAdapter1.ClearBeforeFill = true;
            // 
            // tbpagoempresaTableAdapter1
            // 
            this.tbpagoempresaTableAdapter1.ClearBeforeFill = true;
            // 
            // tbempresaafiliacionTableAdapter1
            // 
            this.tbempresaafiliacionTableAdapter1.ClearBeforeFill = true;
            // 
            // tBEMPRESAAFILIACIONBindingSource
            // 
            this.tBEMPRESAAFILIACIONBindingSource.DataMember = "TBEMPRESAAFILIACION";
            this.tBEMPRESAAFILIACIONBindingSource.DataSource = this.dsNomina;
            // 
            // tBEMPLEADOBindingSource
            // 
            this.tBEMPLEADOBindingSource.DataMember = "TBEMPLEADO";
            this.tBEMPLEADOBindingSource.DataSource = this.dsNomina;
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
            // eMPCEDULADataGridViewTextBoxColumn
            // 
            this.eMPCEDULADataGridViewTextBoxColumn.DataPropertyName = "EMP_CEDULA";
            this.eMPCEDULADataGridViewTextBoxColumn.DataSource = this.tBEMPLEADOBindingSource;
            this.eMPCEDULADataGridViewTextBoxColumn.DisplayMember = "NOMBRE";
            this.eMPCEDULADataGridViewTextBoxColumn.HeaderText = "Empleado";
            this.eMPCEDULADataGridViewTextBoxColumn.MinimumWidth = 150;
            this.eMPCEDULADataGridViewTextBoxColumn.Name = "eMPCEDULADataGridViewTextBoxColumn";
            this.eMPCEDULADataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eMPCEDULADataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eMPCEDULADataGridViewTextBoxColumn.ValueMember = "CEDULA";
            this.eMPCEDULADataGridViewTextBoxColumn.Width = 200;
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
            this.tIPOAFILIACIONDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.tIPOAFILIACIONDataGridViewTextBoxColumn.Name = "tIPOAFILIACIONDataGridViewTextBoxColumn";
            this.tIPOAFILIACIONDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tIPOAFILIACIONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tIPOAFILIACIONDataGridViewTextBoxColumn.Width = 200;
            // 
            // fECHADataGridViewTextBoxColumn
            // 
            this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.fECHADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.fECHADataGridViewTextBoxColumn.HeaderText = "Fecha Pago";
            this.fECHADataGridViewTextBoxColumn.MaxInputLength = 10;
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
            // 
            // vALORPAGADODataGridViewTextBoxColumn
            // 
            this.vALORPAGADODataGridViewTextBoxColumn.DataPropertyName = "VALORPAGADO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C0";
            dataGridViewCellStyle2.NullValue = null;
            this.vALORPAGADODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.vALORPAGADODataGridViewTextBoxColumn.HeaderText = "Valor Pagado";
            this.vALORPAGADODataGridViewTextBoxColumn.MaxInputLength = 13;
            this.vALORPAGADODataGridViewTextBoxColumn.Name = "vALORPAGADODataGridViewTextBoxColumn";
            // 
            // FormPagoEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(659, 422);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormPagoEmpresa";
            this.Text = "Pago Empresa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPAGOEMPRESABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPRESAAFILIACIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPLEADOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tBPAGOEMPRESABindingSource;
        private dsNomina dsNomina;
        private DataSet1TableAdapters.TBEMPLEADOTableAdapter tbempleadoTableAdapter1;
        private DataSet1TableAdapters.TBPAGOEMPRESATableAdapter tbpagoempresaTableAdapter1;
        private DataSet1TableAdapters.TBEMPRESAAFILIACIONTableAdapter tbempresaafiliacionTableAdapter1;
        private System.Windows.Forms.DataGridViewComboBoxColumn ePRNITDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tBEMPRESAAFILIACIONBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn eMPCEDULADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tBEMPLEADOBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn tIPOAFILIACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORPAGADODataGridViewTextBoxColumn;
    }
}
