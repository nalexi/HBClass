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
    public partial class ReativCarros : Form
    {
        public ReativCarros()
        {
            InitializeComponent();
        }

        private void ReativCarros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.AtivarQuery(this.querysInnerJoinDataSet.Carros);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var reativSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridCarros.QuerysInnerJoinDataSet.CarrosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.carrosTableAdapter.ReativQuery(reativSelect.Id);
                    break;
            }
            this.carrosTableAdapter.AtivarQuery(this.querysInnerJoinDataSet.Carros);
        }
    }
}
