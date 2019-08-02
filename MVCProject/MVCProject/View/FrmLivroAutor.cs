using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class FrmLivroAutor : Form
    {
        public FrmLivroAutor()
        {
            InitializeComponent();
        }

        private void FrmLivroAutor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.LivroAutor' table. You can move, or remove it, as needed.
            this.livroAutorTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.LivroAutor);

        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var livAutSelect = ((System.Data.DataRowView)
              this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
              as MVCProject.SistemaBibliotecaDBDataSet.LivroAutorRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        
                    }
                    break;
                case 1:
                    {
                        EditUsuarios editUsuarios = new EditUsuarios();
                        editUsuarios.UsuariosRow = usuarioSelect;
                        editUsuarios.ShowDialog();

                        this.usuariosTableAdapter.Update(editUsuarios.UsuariosRow);

                    }
                    break;
            }
    }
}
