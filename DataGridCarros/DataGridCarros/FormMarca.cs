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
    public partial class FormMarca : Form
    {
        public FormMarca()
        {
            InitializeComponent();
        }

        private void FormMarca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Marcas);

        }

        private void BtnDesativados_Click(object sender, EventArgs e)
        {
            ReativMarcas reativMarcas = new ReativMarcas();
            reativMarcas.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var marcaSelect = ((System.Data.DataRowView)
              this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
              as DataGridCarros.QuerysInnerJoinDataSet.MarcasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.marcasTableAdapter.DesativarQuery(marcaSelect.Id);
                    break;
                case 1:
                    EditMarcas frmEditMarca = new EditMarcas();
                    frmEditMarca.MarcasRow = marcaSelect;
                    frmEditMarca.ShowDialog();

                    this.marcasTableAdapter.Update(frmEditMarca.MarcasRow);

                    break;
            }
            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Marcas);
        }

        private void BtnAddMarca_Click(object sender, EventArgs e)
        {
            AddMarca addMarca = new AddMarca();
            addMarca.ShowDialog();

            if (!string.IsNullOrEmpty(addMarca.marcasRow?.Nome))
                this.marcasTableAdapter.Insert(
                   addMarca.marcasRow.Nome,
                   true,
                   1,
                   1,
                   DateTime.Now,
                   DateTime.Now
                   );

            this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet.Marcas);
        }
    }
}
