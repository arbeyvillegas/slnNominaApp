namespace NominaApp
{
    partial class FormPagoEmpleado
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
            this.tbpagoempleadoTableAdapter1 = new NominaApp.DataSet1TableAdapters.TBPAGOEMPLEADOTableAdapter();
            this.tbempleadoTableAdapter1 = new NominaApp.DataSet1TableAdapters.TBEMPLEADOTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsNomina = new NominaApp.dsNomina();
            this.tBPAGOEMPLEADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBEMPLEADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPCEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tIPOPAGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORPAGADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPAGOEMPLEADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPLEADOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpagoempleadoTableAdapter1
            // 
            this.tbpagoempleadoTableAdapter1.ClearBeforeFill = true;
            // 
            // tbempleadoTableAdapter1
            // 
            this.tbempleadoTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPCEDDataGridViewTextBoxColumn,
            this.tIPOPAGODataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn,
            this.vALORPAGADODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBPAGOEMPLEADOBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // dsNomina
            // 
            this.dsNomina.DataSetName = "DataSet1";
            this.dsNomina.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBPAGOEMPLEADOBindingSource
            // 
            this.tBPAGOEMPLEADOBindingSource.DataMember = "TBPAGOEMPLEADO";
            this.tBPAGOEMPLEADOBindingSource.DataSource = this.dsNomina;
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
            this.eMPCEDDataGridViewTextBoxColumn.HeaderText = "Empleado";
            this.eMPCEDDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.eMPCEDDataGridViewTextBoxColumn.Name = "eMPCEDDataGridViewTextBoxColumn";
            this.eMPCEDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eMPCEDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eMPCEDDataGridViewTextBoxColumn.ValueMember = "CEDULA";
            this.eMPCEDDataGridViewTextBoxColumn.Width = 200;
            // 
            // tIPOPAGODataGridViewTextBoxColumn
            // 
            this.tIPOPAGODataGridViewTextBoxColumn.DataPropertyName = "TIPOPAGO";
            this.tIPOPAGODataGridViewTextBoxColumn.HeaderText = "Tipo Pago";
            this.tIPOPAGODataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Cesantias",
            "Intereses",
            "Prima",
            "Vacaciones"});
            this.tIPOPAGODataGridViewTextBoxColumn.MinimumWidth = 100;
            this.tIPOPAGODataGridViewTextBoxColumn.Name = "tIPOPAGODataGridViewTextBoxColumn";
            this.tIPOPAGODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tIPOPAGODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tIPOPAGODataGridViewTextBoxColumn.Width = 120;
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
            // FormPagoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(659, 422);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormPagoEmpleado";
            this.Text = "Pago Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPAGOEMPLEADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPLEADOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1TableAdapters.TBPAGOEMPLEADOTableAdapter tbpagoempleadoTableAdapter1;
        private DataSet1TableAdapters.TBEMPLEADOTableAdapter tbempleadoTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tBPAGOEMPLEADOBindingSource;
        private dsNomina dsNomina;
        private System.Windows.Forms.DataGridViewComboBoxColumn eMPCEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tBEMPLEADOBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn tIPOPAGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORPAGADODataGridViewTextBoxColumn;
    }
}
