using DataGridCarros.Adicao;
using DataGridCarros.Edicao;
using DataGridCarros.Reativar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridCarros
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Usuarios);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ReativUsuario reativUsuario = new ReativUsuario();
            reativUsuario.ShowDialog();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuarioSelect = ((System.Data.DataRowView)
              this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
              as DataGridCarros.QuerysInnerJoinDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.usuariosTableAdapter.DesativarQuery(usuarioSelect.Id);
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
            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Usuarios);
        }

        private void BtnAddUsuario_Click(object sender, EventArgs e)
        {
            AddUsuario addUsuario = new AddUsuario();
            addUsuario.ShowDialog();

            if (!string.IsNullOrEmpty(addUsuario.usuariosRow?.Nome))

                this.usuariosTableAdapter.Insert(

                     addUsuario.usuariosRow.Nome,
                     true,
                     1,
                     1,
                     DateTime.Now,
                     DateTime.Now
                );

            this.usuariosTableAdapter.Fill(this.querysInnerJoinDataSet.Usuarios);
        }
    }
}
