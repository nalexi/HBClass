namespace DataGridCarros.Adicao
{
    partial class AddMarca
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
            this.btnAddMarca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddMarca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddMarca
            // 
            this.btnAddMarca.Location = new System.Drawing.Point(3, 48);
            this.btnAddMarca.Name = "btnAddMarca";
            this.btnAddMarca.Size = new System.Drawing.Size(242, 46);
            this.btnAddMarca.TabIndex = 0;
            this.btnAddMarca.Text = "Adicionar";
            this.btnAddMarca.UseVisualStyleBackColor = true;
            this.btnAddMarca.Click += new System.EventHandler(this.BtnAddMarca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // tbAddMarca
            // 
            this.tbAddMarca.Location = new System.Drawing.Point(64, 10);
            this.tbAddMarca.Name = "tbAddMarca";
            this.tbAddMarca.Size = new System.Drawing.Size(181, 22);
            this.tbAddMarca.TabIndex = 2;
            // 
            // AddMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 106);
            this.Controls.Add(this.tbAddMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddMarca);
            this.Name = "AddMarca";
            this.Text = "AddMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddMarca;
    }
}