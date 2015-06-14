namespace NominaApp
{
    partial class FormBonificacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eMPCEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tBEMPLEADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNomina = new NominaApp.dsNomina();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORBONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOTIVODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ePMOTORGADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tBBONIFICACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbbonificacionTableAdapter1 = new NominaApp.DataSet1TableAdapters.TBBONIFICACIONTableAdapter();
            this.tbempleadoTableAdapter1 = new NominaApp.DataSet1TableAdapters.TBEMPLEADOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPLEADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBBONIFICACIONBindingSource)).BeginInit();
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
            this.vALORBONODataGridViewTextBoxColumn,
            this.mOTIVODataGridViewTextBoxColumn,
            this.ePMOTORGADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBBONIFICACIONBindingSource;
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
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.fECHADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.fECHADataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fECHADataGridViewTextBoxColumn.MaxInputLength = 10;
            this.fECHADataGridViewTextBoxColumn.MinimumWidth = 30;
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
            // 
            // vALORBONODataGridViewTextBoxColumn
            // 
            this.vALORBONODataGridViewTextBoxColumn.DataPropertyName = "VALORBONO";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "C0";
            dataGridViewCellStyle8.NullValue = null;
            this.vALORBONODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.vALORBONODataGridViewTextBoxColumn.HeaderText = "Valor Bono";
            this.vALORBONODataGridViewTextBoxColumn.Name = "vALORBONODataGridViewTextBoxColumn";
            // 
            // mOTIVODataGridViewTextBoxColumn
            // 
            this.mOTIVODataGridViewTextBoxColumn.DataPropertyName = "MOTIVO";
            this.mOTIVODataGridViewTextBoxColumn.HeaderText = "Motivo";
            this.mOTIVODataGridViewTextBoxColumn.MaxInputLength = 100;
            this.mOTIVODataGridViewTextBoxColumn.MinimumWidth = 100;
            this.mOTIVODataGridViewTextBoxColumn.Name = "mOTIVODataGridViewTextBoxColumn";
            this.mOTIVODataGridViewTextBoxColumn.Width = 150;
            // 
            // ePMOTORGADataGridViewTextBoxColumn
            // 
            this.ePMOTORGADataGridViewTextBoxColumn.DataPropertyName = "EPM_OTORGA";
            this.ePMOTORGADataGridViewTextBoxColumn.DataSource = this.tBEMPLEADOBindingSource;
            this.ePMOTORGADataGridViewTextBoxColumn.DisplayMember = "NOMBRE";
            this.ePMOTORGADataGridViewTextBoxColumn.HeaderText = "Otorgado por";
            this.ePMOTORGADataGridViewTextBoxColumn.MinimumWidth = 150;
            this.ePMOTORGADataGridViewTextBoxColumn.Name = "ePMOTORGADataGridViewTextBoxColumn";
            this.ePMOTORGADataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ePMOTORGADataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ePMOTORGADataGridViewTextBoxColumn.ValueMember = "CEDULA";
            this.ePMOTORGADataGridViewTextBoxColumn.Width = 200;
            // 
            // tBBONIFICACIONBindingSource
            // 
            this.tBBONIFICACIONBindingSource.DataMember = "TBBONIFICACION";
            this.tBBONIFICACIONBindingSource.DataSource = this.dsNomina;
            this.tBBONIFICACIONBindingSource.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.tBBONIFICACIONBindingSource_DataError);
            // 
            // tbbonificacionTableAdapter1
            // 
            this.tbbonificacionTableAdapter1.ClearBeforeFill = true;
            // 
            // tbempleadoTableAdapter1
            // 
            this.tbempleadoTableAdapter1.ClearBeforeFill = true;
            // 
            // FormBonificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(659, 422);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormBonificacion";
            this.Text = "Bonificación";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPLEADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBBONIFICACIONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tBEMPLEADOBindingSource;
        private dsNomina dsNomina;
        private System.Windows.Forms.BindingSource tBBONIFICACIONBindingSource;
        private DataSet1TableAdapters.TBBONIFICACIONTableAdapter tbbonificacionTableAdapter1;
        private DataSet1TableAdapters.TBEMPLEADOTableAdapter tbempleadoTableAdapter1;
        private System.Windows.Forms.DataGridViewComboBoxColumn eMPCEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORBONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOTIVODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ePMOTORGADataGridViewTextBoxColumn;
    }
}
