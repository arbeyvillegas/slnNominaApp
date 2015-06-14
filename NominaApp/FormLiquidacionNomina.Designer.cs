namespace NominaApp
{
    partial class FormLiquidacionNomina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBEMPLEADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNomina = new NominaApp.dsNomina();
            this.tBLIQNOMINABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbliqnominaTableAdapter1 = new NominaApp.DataSet1TableAdapters.TBLIQNOMINATableAdapter();
            this.tbempleadoTableAdapter1 = new NominaApp.DataSet1TableAdapters.TBEMPLEADOTableAdapter();
            this.eMPCEDULADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUINCENADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIASTRABAJODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALARIOBASEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pENSIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALUDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUXILIOTRANSPORTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPLEADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLIQNOMINABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPCEDULADataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn,
            this.mESDataGridViewTextBoxColumn,
            this.qUINCENADataGridViewTextBoxColumn,
            this.dIASTRABAJODataGridViewTextBoxColumn,
            this.sALARIOBASEDataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn,
            this.pENSIONDataGridViewTextBoxColumn,
            this.sALUDDataGridViewTextBoxColumn,
            this.aUXILIOTRANSPORTEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLIQNOMINABindingSource;
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
            // tBLIQNOMINABindingSource
            // 
            this.tBLIQNOMINABindingSource.DataMember = "TBLIQNOMINA";
            this.tBLIQNOMINABindingSource.DataSource = this.dsNomina;
            // 
            // tbliqnominaTableAdapter1
            // 
            this.tbliqnominaTableAdapter1.ClearBeforeFill = true;
            // 
            // tbempleadoTableAdapter1
            // 
            this.tbempleadoTableAdapter1.ClearBeforeFill = true;
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
            // fECHADataGridViewTextBoxColumn
            // 
            this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.fECHADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.fECHADataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fECHADataGridViewTextBoxColumn.MaxInputLength = 10;
            this.fECHADataGridViewTextBoxColumn.MinimumWidth = 35;
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
            // 
            // mESDataGridViewTextBoxColumn
            // 
            this.mESDataGridViewTextBoxColumn.DataPropertyName = "MES";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.mESDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.mESDataGridViewTextBoxColumn.HeaderText = "Mes";
            this.mESDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.mESDataGridViewTextBoxColumn.Name = "mESDataGridViewTextBoxColumn";
            this.mESDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // qUINCENADataGridViewTextBoxColumn
            // 
            this.qUINCENADataGridViewTextBoxColumn.DataPropertyName = "QUINCENA";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.qUINCENADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.qUINCENADataGridViewTextBoxColumn.HeaderText = "Quincena";
            this.qUINCENADataGridViewTextBoxColumn.MaxInputLength = 1;
            this.qUINCENADataGridViewTextBoxColumn.Name = "qUINCENADataGridViewTextBoxColumn";
            this.qUINCENADataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dIASTRABAJODataGridViewTextBoxColumn
            // 
            this.dIASTRABAJODataGridViewTextBoxColumn.DataPropertyName = "DIASTRABAJO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.dIASTRABAJODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dIASTRABAJODataGridViewTextBoxColumn.HeaderText = "Días Trabajados";
            this.dIASTRABAJODataGridViewTextBoxColumn.MaxInputLength = 2;
            this.dIASTRABAJODataGridViewTextBoxColumn.Name = "dIASTRABAJODataGridViewTextBoxColumn";
            // 
            // sALARIOBASEDataGridViewTextBoxColumn
            // 
            this.sALARIOBASEDataGridViewTextBoxColumn.DataPropertyName = "SALARIOBASE";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C0";
            dataGridViewCellStyle5.NullValue = null;
            this.sALARIOBASEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.sALARIOBASEDataGridViewTextBoxColumn.HeaderText = "Salario Base";
            this.sALARIOBASEDataGridViewTextBoxColumn.MaxInputLength = 13;
            this.sALARIOBASEDataGridViewTextBoxColumn.Name = "sALARIOBASEDataGridViewTextBoxColumn";
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "Estado";
            this.eSTADODataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Liquidado",
            "Pendiente"});
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            this.eSTADODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eSTADODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pENSIONDataGridViewTextBoxColumn
            // 
            this.pENSIONDataGridViewTextBoxColumn.DataPropertyName = "PENSION";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C0";
            dataGridViewCellStyle6.NullValue = null;
            this.pENSIONDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.pENSIONDataGridViewTextBoxColumn.HeaderText = "Pensión";
            this.pENSIONDataGridViewTextBoxColumn.MaxInputLength = 13;
            this.pENSIONDataGridViewTextBoxColumn.Name = "pENSIONDataGridViewTextBoxColumn";
            // 
            // sALUDDataGridViewTextBoxColumn
            // 
            this.sALUDDataGridViewTextBoxColumn.DataPropertyName = "SALUD";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C0";
            dataGridViewCellStyle7.NullValue = null;
            this.sALUDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.sALUDDataGridViewTextBoxColumn.HeaderText = "Salud";
            this.sALUDDataGridViewTextBoxColumn.MaxInputLength = 13;
            this.sALUDDataGridViewTextBoxColumn.Name = "sALUDDataGridViewTextBoxColumn";
            // 
            // aUXILIOTRANSPORTEDataGridViewTextBoxColumn
            // 
            this.aUXILIOTRANSPORTEDataGridViewTextBoxColumn.DataPropertyName = "AUXILIOTRANSPORTE";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "C0";
            dataGridViewCellStyle8.NullValue = null;
            this.aUXILIOTRANSPORTEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.aUXILIOTRANSPORTEDataGridViewTextBoxColumn.HeaderText = "Auxilio Transporte";
            this.aUXILIOTRANSPORTEDataGridViewTextBoxColumn.MaxInputLength = 8;
            this.aUXILIOTRANSPORTEDataGridViewTextBoxColumn.Name = "aUXILIOTRANSPORTEDataGridViewTextBoxColumn";
            // 
            // FormLiquidacionNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(659, 422);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormLiquidacionNomina";
            this.Text = "Liquidación Nómina";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPLEADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLIQNOMINABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tBEMPLEADOBindingSource;
        private dsNomina dsNomina;
        private System.Windows.Forms.BindingSource tBLIQNOMINABindingSource;
        private DataSet1TableAdapters.TBLIQNOMINATableAdapter tbliqnominaTableAdapter1;
        private DataSet1TableAdapters.TBEMPLEADOTableAdapter tbempleadoTableAdapter1;
        private System.Windows.Forms.DataGridViewComboBoxColumn eMPCEDULADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUINCENADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIASTRABAJODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALARIOBASEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pENSIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALUDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUXILIOTRANSPORTEDataGridViewTextBoxColumn;
    }
}
