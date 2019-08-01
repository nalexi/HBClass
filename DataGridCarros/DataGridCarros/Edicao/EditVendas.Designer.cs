namespace DataGridCarros.Edicao
{
    partial class EditVendas
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.carrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.querysInnerJoinDataSet = new DataGridCarros.QuerysInnerJoinDataSet();
            this.carrosTableAdapter = new DataGridCarros.QuerysInnerJoinDataSetTableAdapters.CarrosTableAdapter();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerJoinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modelo";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.carrosBindingSource;
            this.comboBox1.DisplayMember = "Modelo";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "Id";
            // 
            // carrosBindingSource
            // 
            this.carrosBindingSource.DataMember = "Carros";
            this.carrosBindingSource.DataSource = this.querysInnerJoinDataSet;
            // 
            // querysInnerJoinDataSet
            // 
            this.querysInnerJoinDataSet.DataSetName = "QuerysInnerJoinDataSet";
            this.querysInnerJoinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carrosTableAdapter
            // 
            this.carrosTableAdapter.ClearBeforeFill = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(100, 44);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(258, 22);
            this.numericUpDown1.TabIndex = 7;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(100, 71);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(258, 22);
            this.tbValor.TabIndex = 8;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(4, 107);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(354, 37);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // EditVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 153);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditVendas";
            this.Text = "EditVendas";
            this.Load += new System.EventHandler(this.EditVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerJoinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private QuerysInnerJoinDataSet querysInnerJoinDataSet;
        private System.Windows.Forms.BindingSource carrosBindingSource;
        private QuerysInnerJoinDataSetTableAdapters.CarrosTableAdapter carrosTableAdapter;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Button btnSalvar;
    }
}