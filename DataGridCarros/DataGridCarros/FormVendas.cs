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
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
