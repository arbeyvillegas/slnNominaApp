namespace NominaApp
{
    partial class FormDeduccion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eMPCEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tBEMPLEADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNomina = new NominaApp.dsNomina();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOTIVODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBDEDUCCIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbdeduccionTableAdapter1 = new NominaApp.DataSet1TableAdapters.TBDEDUCCIONTableAdapter();
            this.tbempleadoTableAdapter1 = new NominaApp.DataSet1TableAdapters.TBEMPLEADOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPLEADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBDEDUCCIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPCEDDataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn,
            this.mOTIVODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBDEDUCCIONBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 422);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
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
            // fECHADataGridViewTextBoxColumn
            // 
            this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.fECHADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.fECHADataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fECHADataGridViewTextBoxColumn.MaxInputLength = 10;
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
            // 
            // mOTIVODataGridViewTextBoxColumn
            // 
            this.mOTIVODataGridViewTextBoxColumn.DataPropertyName = "MOTIVO";
            this.mOTIVODataGridViewTextBoxColumn.HeaderText = "Motivo";
            this.mOTIVODataGridViewTextBoxColumn.MaxInputLength = 100;
            this.mOTIVODataGridViewTextBoxColumn.MinimumWidth = 150;
            this.mOTIVODataGridViewTextBoxColumn.Name = "mOTIVODataGridViewTextBoxColumn";
            this.mOTIVODataGridViewTextBoxColumn.Width = 200;
            // 
            // tBDEDUCCIONBindingSource
            // 
            this.tBDEDUCCIONBindingSource.DataMember = "TBDEDUCCION";
            this.tBDEDUCCIONBindingSource.DataSource = this.dsNomina;
            this.tBDEDUCCIONBindingSource.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.tBDEDUCCIONBindingSource_DataError);
            // 
            // tbdeduccionTableAdapter1
            // 
            this.tbdeduccionTableAdapter1.ClearBeforeFill = true;
            // 
            // tbempleadoTableAdapter1
            // 
            this.tbempleadoTableAdapter1.ClearBeforeFill = true;
            // 
            // FormDeduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(659, 422);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDeduccion";
            this.Text = "Días Deducción";
            this.Load += new System.EventHandler(this.FormDeduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPLEADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBDEDUCCIONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tBDEDUCCIONBindingSource;
        private dsNomina dsNomina;
        private System.Windows.Forms.DataGridViewComboBoxColumn eMPCEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tBEMPLEADOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOTIVODataGridViewTextBoxColumn;
        private DataSet1TableAdapters.TBDEDUCCIONTableAdapter tbdeduccionTableAdapter1;
        private DataSet1TableAdapters.TBEMPLEADOTableAdapter tbempleadoTableAdapter1;
    }
}
