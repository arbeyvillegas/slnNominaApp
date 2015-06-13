namespace NominaApp
{
    partial class FormConfigHoraExtra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsNomina = new NominaApp.dsNomina();
            this.tBCONFIGHORAEXTRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDENTIFICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fACTORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbconfighoraextraTableAdapter1 = new NominaApp.DataSet1TableAdapters.TBCONFIGHORAEXTRATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCONFIGHORAEXTRABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDENTIFICACIONDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.fACTORDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBCONFIGHORAEXTRABindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 375);
            this.dataGridView1.TabIndex = 2;
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
            // iDENTIFICACIONDataGridViewTextBoxColumn
            // 
            this.iDENTIFICACIONDataGridViewTextBoxColumn.DataPropertyName = "IDENTIFICACION";
            this.iDENTIFICACIONDataGridViewTextBoxColumn.HeaderText = "IDENTIFICACION";
            this.iDENTIFICACIONDataGridViewTextBoxColumn.Name = "iDENTIFICACIONDataGridViewTextBoxColumn";
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            // 
            // fACTORDataGridViewTextBoxColumn
            // 
            this.fACTORDataGridViewTextBoxColumn.DataPropertyName = "FACTOR";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.fACTORDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.fACTORDataGridViewTextBoxColumn.HeaderText = "FACTOR";
            this.fACTORDataGridViewTextBoxColumn.Name = "fACTORDataGridViewTextBoxColumn";
            // 
            // tbconfighoraextraTableAdapter1
            // 
            this.tbconfighoraextraTableAdapter1.ClearBeforeFill = true;
            // 
            // FormConfigHoraExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(659, 422);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormConfigHoraExtra";
            this.Text = "Configuración Hora Extra";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCONFIGHORAEXTRABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDENTIFICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fACTORDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tBCONFIGHORAEXTRABindingSource;
        private dsNomina dsNomina;
        private DataSet1TableAdapters.TBCONFIGHORAEXTRATableAdapter tbconfighoraextraTableAdapter1;
    }
}
