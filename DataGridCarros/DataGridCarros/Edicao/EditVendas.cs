using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridCarros.Edicao
{
    public partial class EditVendas : Form
    {
        public EditVendas()
        {
            InitializeComponent();
        }

        public DataGridCarros.QuerysInnerJoinDataSet.VendasRow VendasRow;

        private void EditVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.FillBy(this.querysInnerJoinDataSet.Carros);

            comboBox1.SelectedValue = VendasRow.Id;
            numericUpDown1.Value = VendasRow.Quantidade;
            tbValor.Text = VendasRow.Valor.ToString();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            VendasRow.Carro = (int)comboBox1.SelectedValue;
            VendasRow.Quantidade = (int)numericUpDown1.Value;
            VendasRow.Valor = Convert.ToDecimal(tbValor.Text);
        }
    }
}
