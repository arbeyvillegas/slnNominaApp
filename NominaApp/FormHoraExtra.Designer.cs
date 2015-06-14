namespace NominaApp
{
    partial class FormHoraExtra
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
            this.tBEMPLEADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNomina = new NominaApp.dsNomina();
            this.tBCONFIGHORAEXTRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBHORAEXTRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbhoraextraTableAdapter1 = new NominaApp.DataSet1TableAdapters.TBHORAEXTRATableAdapter();
            this.tbempleadoTableAdapter1 = new NominaApp.DataSet1TableAdapters.TBEMPLEADOTableAdapter();
            this.tbconfighoraextraTableAdapter1 = new NominaApp.DataSet1TableAdapters.TBCONFIGHORAEXTRATableAdapter();
            this.eMPCEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cONFHEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOTIVODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPAPRUEBADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPLEADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCONFIGHORAEXTRABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBHORAEXTRABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPCEDDataGridViewTextBoxColumn,
            this.cONFHEIDDataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn,
            this.cANTIDADDataGridViewTextBoxColumn,
            this.mOTIVODataGridViewTextBoxColumn,
            this.eMPAPRUEBADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBHORAEXTRABindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // tBEMPLEADOBindingSource
            // 
            this.tBEMPLEADOBindingSource.DataMember = "TBEMPLEADO";
            this.tBEMPLEADOBindingSource.DataSource = this.dsNomina;
            // 
            // dsNomina
            // 
            this.dsNomina.DataSetName = "DataSet1";
            this.dsNomina.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBCONFIGHORAEXTRABindingSource
            // 
            this.tBCONFIGHORAEXTRABindingSource.DataMember = "TBCONFIGHORAEXTRA";
            this.tBCONFIGHORAEXTRABindingSource.DataSource = this.dsNomina;
            // 
            // tBHORAEXTRABindingSource
            // 
            this.tBHORAEXTRABindingSource.DataMember = "TBHORAEXTRA";
            this.tBHORAEXTRABindingSource.DataSource = this.dsNomina;
            // 
            // tbhoraextraTableAdapter1
            // 
            this.tbhoraextraTableAdapter1.ClearBeforeFill = true;
            // 
            // tbempleadoTableAdapter1
            // 
            this.tbempleadoTableAdapter1.ClearBeforeFill = true;
            // 
            // tbconfighoraextraTableAdapter1
            // 
            this.tbconfighoraextraTableAdapter1.ClearBeforeFill = true;
            // 
            // eMPCEDDataGridViewTextBoxColumn
            // 
            this.eMPCEDDataGridViewTextBoxColumn.DataPropertyName = "EMP_CED";
            this.eMPCEDDataGridViewTextBoxColumn.DataSource = this.tBEMPLEADOBindingSource;
            this.eMPCEDDataGridViewTextBoxColumn.DisplayMember = "NOMBRE";
            this.eMPCEDDataGridViewTextBoxColumn.HeaderText = "Empleado";
            this.eMPCEDDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.eMPCEDDataGridViewTextBoxColumn.Name = "eMPCEDDataGridViewTextBoxColumn";
            this.eMPCEDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eMPCEDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eMPCEDDataGridViewTextBoxColumn.ValueMember = "CEDULA";
            this.eMPCEDDataGridViewTextBoxColumn.Width = 200;
            // 
            // cONFHEIDDataGridViewTextBoxColumn
            // 
            this.cONFHEIDDataGridViewTextBoxColumn.DataPropertyName = "CONFHE_ID";
            this.cONFHEIDDataGridViewTextBoxColumn.DataSource = this.tBCONFIGHORAEXTRABindingSource;
            this.cONFHEIDDataGridViewTextBoxColumn.DisplayMember = "NOMBRE";
            this.cONFHEIDDataGridViewTextBoxColumn.HeaderText = "Tipo Extra";
            this.cONFHEIDDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.cONFHEIDDataGridViewTextBoxColumn.Name = "cONFHEIDDataGridViewTextBoxColumn";
            this.cONFHEIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cONFHEIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cONFHEIDDataGridViewTextBoxColumn.ValueMember = "IDENTIFICACION";
            this.cONFHEIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // fECHADataGridViewTextBoxColumn
            // 
            this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.fECHADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.fECHADataGridViewTextBoxColumn.HeaderText = "Fecha Extra";
            this.fECHADataGridViewTextBoxColumn.MaxInputLength = 10;
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
            // 
            // cANTIDADDataGridViewTextBoxColumn
            // 
            this.cANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.cANTIDADDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.cANTIDADDataGridViewTextBoxColumn.HeaderText = "Cantidad Horas";
            this.cANTIDADDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.cANTIDADDataGridViewTextBoxColumn.Name = "cANTIDADDataGridViewTextBoxColumn";
            // 
            // mOTIVODataGridViewTextBoxColumn
            // 
            this.mOTIVODataGridViewTextBoxColumn.DataPropertyName = "MOTIVO";
            this.mOTIVODataGridViewTextBoxColumn.HeaderText = "Motivo";
            this.mOTIVODataGridViewTextBoxColumn.MaxInputLength = 100;
            this.mOTIVODataGridViewTextBoxColumn.MinimumWidth = 150;
            this.mOTIVODataGridViewTextBoxColumn.Name = "mOTIVODataGridViewTextBoxColumn";
            this.mOTIVODataGridViewTextBoxColumn.Width = 150;
            // 
            // eMPAPRUEBADataGridViewTextBoxColumn
            // 
            this.eMPAPRUEBADataGridViewTextBoxColumn.DataPropertyName = "EMP_APRUEBA";
            this.eMPAPRUEBADataGridViewTextBoxColumn.DataSource = this.tBEMPLEADOBindingSource;
            this.eMPAPRUEBADataGridViewTextBoxColumn.DisplayMember = "NOMBRE";
            this.eMPAPRUEBADataGridViewTextBoxColumn.HeaderText = "Aprobado por";
            this.eMPAPRUEBADataGridViewTextBoxColumn.MinimumWidth = 150;
            this.eMPAPRUEBADataGridViewTextBoxColumn.Name = "eMPAPRUEBADataGridViewTextBoxColumn";
            this.eMPAPRUEBADataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eMPAPRUEBADataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eMPAPRUEBADataGridViewTextBoxColumn.ValueMember = "CEDULA";
            this.eMPAPRUEBADataGridViewTextBoxColumn.Width = 200;
            // 
            // FormHoraExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(659, 422);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormHoraExtra";
            this.Text = "Horas Extras";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPLEADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCONFIGHORAEXTRABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBHORAEXTRABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tBEMPLEADOBindingSource;
        private dsNomina dsNomina;
        private System.Windows.Forms.BindingSource tBCONFIGHORAEXTRABindingSource;
        private System.Windows.Forms.BindingSource tBHORAEXTRABindingSource;
        private DataSet1TableAdapters.TBHORAEXTRATableAdapter tbhoraextraTableAdapter1;
        private DataSet1TableAdapters.TBEMPLEADOTableAdapter tbempleadoTableAdapter1;
        private DataSet1TableAdapters.TBCONFIGHORAEXTRATableAdapter tbconfighoraextraTableAdapter1;
        private System.Windows.Forms.DataGridViewComboBoxColumn eMPCEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cONFHEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOTIVODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn eMPAPRUEBADataGridViewTextBoxColumn;
    }
}
