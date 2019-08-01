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
    public partial class EditMarca : Form
    {
        public EditMarca()
        {
            InitializeComponent();
        }

        public DataGridCarros.QuerysInnerJoinDataSet.CarrosRow CarrosRow;

        private void EditCarros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.FillBy(this.querysInnerJoinDataSet.Marcas);
            tbModelo.Text = CarrosRow.Modelo;
            dateTimePicker1.Value = CarrosRow.Ano;
            comboBox1.SelectedValue = CarrosRow.Marca;

        }
               
        private void Button1_Click(object sender, EventArgs e)
        {
            CarrosRow.Modelo = tbModelo.Text;
            CarrosRow.Ano = dateTimePicker1.Value;
            CarrosRow.Marca = (int)comboBox1.SelectedValue;
            this.Close();
        }
    }
}
