﻿namespace NominaApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eMPCEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tBEMPLEADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNomina = new NominaApp.dsNomina();
            this.sALARIOBASEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUXTRANSPORTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORHORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPJEFEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tBCONFIGEMPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbconfigempTableAdapter1 = new NominaApp.DataSet1TableAdapters.TBCONFIGEMPTableAdapter();
            this.tbempleadoTableAdapter1 = new NominaApp.DataSet1TableAdapters.TBEMPLEADOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPLEADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCONFIGEMPBindingSource)).BeginInit();
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
            // sALARIOBASEDataGridViewTextBoxColumn
            // 
            this.sALARIOBASEDataGridViewTextBoxColumn.DataPropertyName = "SALARIOBASE";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C0";
            dataGridViewCellStyle1.NullValue = null;
            this.sALARIOBASEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.sALARIOBASEDataGridViewTextBoxColumn.HeaderText = "Salario Base";
            this.sALARIOBASEDataGridViewTextBoxColumn.Name = "sALARIOBASEDataGridViewTextBoxColumn";
            // 
            // aUXTRANSPORTEDataGridViewTextBoxColumn
            // 
            this.aUXTRANSPORTEDataGridViewTextBoxColumn.DataPropertyName = "AUXTRANSPORTE";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C0";
            dataGridViewCellStyle2.NullValue = null;
            this.aUXTRANSPORTEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.aUXTRANSPORTEDataGridViewTextBoxColumn.HeaderText = "Auxilio Transporte";
            this.aUXTRANSPORTEDataGridViewTextBoxColumn.Name = "aUXTRANSPORTEDataGridViewTextBoxColumn";
            // 
            // vALORDIADataGridViewTextBoxColumn
            // 
            this.vALORDIADataGridViewTextBoxColumn.DataPropertyName = "VALORDIA";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = null;
            this.vALORDIADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.vALORDIADataGridViewTextBoxColumn.HeaderText = "Valor Día";
            this.vALORDIADataGridViewTextBoxColumn.Name = "vALORDIADataGridViewTextBoxColumn";
            // 
            // vALORHORADataGridViewTextBoxColumn
            // 
            this.vALORHORADataGridViewTextBoxColumn.DataPropertyName = "VALORHORA";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C0";
            dataGridViewCellStyle4.NullValue = null;
            this.vALORHORADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.vALORHORADataGridViewTextBoxColumn.HeaderText = "Valor Hora";
            this.vALORHORADataGridViewTextBoxColumn.Name = "vALORHORADataGridViewTextBoxColumn";
            // 
            // eMPJEFEDataGridViewTextBoxColumn
            // 
            this.eMPJEFEDataGridViewTextBoxColumn.DataPropertyName = "EMP_JEFE";
            this.eMPJEFEDataGridViewTextBoxColumn.DataSource = this.tBEMPLEADOBindingSource;
            this.eMPJEFEDataGridViewTextBoxColumn.DisplayMember = "NOMBRE";
            this.eMPJEFEDataGridViewTextBoxColumn.HeaderText = "Jefe";
            this.eMPJEFEDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.eMPJEFEDataGridViewTextBoxColumn.Name = "eMPJEFEDataGridViewTextBoxColumn";
            this.eMPJEFEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eMPJEFEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eMPJEFEDataGridViewTextBoxColumn.ValueMember = "CEDULA";
            this.eMPJEFEDataGridViewTextBoxColumn.Width = 200;
            // 
            // tBCONFIGEMPBindingSource
            // 
            this.tBCONFIGEMPBindingSource.DataMember = "TBCONFIGEMP";
            this.tBCONFIGEMPBindingSource.DataSource = this.dsNomina;
            this.tBCONFIGEMPBindingSource.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.tBCONFIGEMPBindingSource_DataError);
            // 
            // tbconfigempTableAdapter1
            // 
            this.tbconfigempTableAdapter1.ClearBeforeFill = true;
            // 
            // tbempleadoTableAdapter1
            // 
            this.tbempleadoTableAdapter1.ClearBeforeFill = true;
            // 
            // FormConfigEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 431);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormConfigEmpleado";
            this.Text = "Configuración Empleado";
            this.Load += new System.EventHandler(this.FormConfigEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEMPLEADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCONFIGEMPBindingSource)).EndInit();
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
    }
}

