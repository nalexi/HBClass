using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridCarros.Reativar
{
    public partial class ReativUsuario : Form
    {
        public ReativUsuario()
        {
            InitializeComponent();
        }

        private void ReativUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.AtivarQuery(this.querysInnerJoinDataSet.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var reativSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridCarros.QuerysInnerJoinDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.usuariosTableAdapter.ReativQuery(reativSelect.Id);
                    }
                    break;
            }
            this.usuariosTableAdapter.AtivarQuery(this.querysInnerJoinDataSet.Usuarios);
        }
    }
}
