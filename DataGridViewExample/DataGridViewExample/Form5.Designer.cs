namespace DataGridViewExample
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.querysInnerJoinDataSet1 = new DataGridViewExample.QuerysInnerJoinDataSet1();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new DataGridViewExample.QuerysInnerJoinDataSet1TableAdapters.DataTable1TableAdapter();
            this.ReactivateCommand = new System.Windows.Forms.DataGridViewButtonColumn();
            this.column1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restaurarCommandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableAdapterManager1 = new DataGridViewExample.QuerysInnerJoinDataSet1TableAdapters.TableAdapterManager();
            this.usuariosTableAdapter1 = new DataGridViewExample.QuerysInnerJoinDataSet1TableAdapters.UsuariosTableAdapter();
            this.vendasTableAdapter1 = new DataGridViewExample.QuerysInnerJoinDataSet1TableAdapters.VendasTableAdapter();
            this.dataTable1TableAdapter1 = new DataGridViewExample.QuerysInnerJoinDataSet1TableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerJoinDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReactivateCommand,
            this.column1DataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.restaurarCommandDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 369);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // querysInnerJoinDataSet1
            // 
            this.querysInnerJoinDataSet1.DataSetName = "QuerysInnerJoinDataSet1";
            this.querysInnerJoinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.querysInnerJoinDataSet1;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // ReactivateCommand
            // 
            this.ReactivateCommand.DataPropertyName = "ReactivateCommand";
            this.ReactivateCommand.HeaderText = "Reativar";
            this.ReactivateCommand.MinimumWidth = 6;
            this.ReactivateCommand.Name = "ReactivateCommand";
            this.ReactivateCommand.ReadOnly = true;
            this.ReactivateCommand.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReactivateCommand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ReactivateCommand.Width = 125;
            // 
            // column1DataGridViewTextBoxColumn
            // 
            this.column1DataGridViewTextBoxColumn.DataPropertyName = "Column1";
            this.column1DataGridViewTextBoxColumn.HeaderText = "Column1";
            this.column1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.column1DataGridViewTextBoxColumn.Name = "column1DataGridViewTextBoxColumn";
            this.column1DataGridViewTextBoxColumn.ReadOnly = true;
            this.column1DataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // restaurarCommandDataGridViewTextBoxColumn
            // 
            this.restaurarCommandDataGridViewTextBoxColumn.DataPropertyName = "RestaurarCommand";
            this.restaurarCommandDataGridViewTextBoxColumn.HeaderText = "RestaurarCommand";
            this.restaurarCommandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.restaurarCommandDataGridViewTextBoxColumn.Name = "restaurarCommandDataGridViewTextBoxColumn";
            this.restaurarCommandDataGridViewTextBoxColumn.ReadOnly = true;
            this.restaurarCommandDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.restaurarCommandDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.restaurarCommandDataGridViewTextBoxColumn.Width = 125;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CarrosTableAdapter = null;
            this.tableAdapterManager1.MarcasTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = DataGridViewExample.QuerysInnerJoinDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsuariosTableAdapter = this.usuariosTableAdapter1;
            this.tableAdapterManager1.VendasTableAdapter = this.vendasTableAdapter1;
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // vendasTableAdapter1
            // 
            this.vendasTableAdapter1.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerJoinDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QuerysInnerJoinDataSet1 querysInnerJoinDataSet1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private QuerysInnerJoinDataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn ReactivateCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn restaurarCommandDataGridViewTextBoxColumn;
        private QuerysInnerJoinDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private QuerysInnerJoinDataSet1TableAdapters.UsuariosTableAdapter usuariosTableAdapter1;
        private QuerysInnerJoinDataSet1TableAdapters.VendasTableAdapter vendasTableAdapter1;
        private QuerysInnerJoinDataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
    }
}