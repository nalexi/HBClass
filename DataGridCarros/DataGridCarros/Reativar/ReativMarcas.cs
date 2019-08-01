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
    public partial class ReativMarcas : Form
    {
        public ReativMarcas()
        {
            InitializeComponent();
        }

        private void ReativMarcas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.AtivarQuery(this.querysInnerJoinDataSet.Marcas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var reativSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridCarros.QuerysInnerJoinDataSet.MarcasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.marcasTableAdapter.ReativQuery(reativSelect.Id);
                    break;
            }
            this.marcasTableAdapter.AtivarQuery(this.querysInnerJoinDataSet.Marcas);
        }
    }
}
