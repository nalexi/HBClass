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
            var vendaSelect = ((System.Data.DataRowView)
              this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
              as DataGridCarros.QuerysInnerJoinDataSet.VendasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.vendasTableAdapter.DesativarQuery(vendaSelect.Id);
                    break;
                case 1:
                    EditVendas frmEditVenda = new EditVendas();
                    frmEditVenda.VendasRow = vendaSelect;
                    frmEditVenda.ShowDialog();

                    this.vendasTableAdapter.Update(frmEditVenda.VendasRow);

                    break;
            }
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Vendas);
        }

        private void BtnDesativados_Click(object sender, EventArgs e)
        {
            ReativVendas reativVendas = new ReativVendas();
            reativVendas.ShowDialog();
        }

        private void BtnAddVendas_Click(object sender, EventArgs e)
        {
            AddVendas addVendas = new AddVendas();
            addVendas.ShowDialog();
            if (addVendas.vendasRow?.Carro > 0
                && addVendas.vendasRow?.Valor > 0)

                this.vendasTableAdapter.Insert(

                addVendas.vendasRow.Carro,
                addVendas.vendasRow.Quantidade,
                addVendas.vendasRow.Valor,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            this.vendasTableAdapter.Fill(this.querysInnerJoinDataSet.Vendas);
        }
    }
}
