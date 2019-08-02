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
    public partial class ReativVendas : Form
    {
        public ReativVendas()
        {
            InitializeComponent();
        }

        private void ReativVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.AtivarQuery(this.querysInnerJoinDataSet.Vendas);

        }

        
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var reativSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridCarros.QuerysInnerJoinDataSet.VendasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.vendasTableAdapter.ReativQuery(reativSelect.Id);
                    break;
            }
            this.vendasTableAdapter.AtivarQuery(this.querysInnerJoinDataSet.Vendas);
        }
    }
}
