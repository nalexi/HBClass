using DataGridCarros.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridCarros.Adicao
{
    public partial class AddVendas : Form
    {
        public AddVendas()
        {
            InitializeComponent();
        }
        public Venda vendasRow;

        private void AddVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet.Carros);

        }

       
        private void BtnAddVendas_Click(object sender, EventArgs e)
        {
            decimal.TryParse(tbTextValor.Text, out decimal valor);
            vendasRow = new Venda
            {
                Carro = (int)comboBox1.SelectedValue,
                Quantidade = (int)numericUpDown1.Value,
                Valor = valor
            };
            this.Close();
        }
    }
}
