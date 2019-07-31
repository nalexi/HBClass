using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.QuerysInnerJoinDataSet1.CarrosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.carrosTableAdapter1.DeleteQuery(carSelect.Id);
                    break;
            }
            this.carrosTableAdapter1.CustomQuery(querysInnerJoinDataSet1.Carros);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter1.CustomQuery(this.querysInnerJoinDataSet1.Carros);
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.

        }

        private void BtnMarcas_Click(object sender, EventArgs e)
        {
            Form2 frmMarcas = new Form2();
            frmMarcas.ShowDialog();
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            Form3 frmUsuario = new Form3();
            frmUsuario.ShowDialog();
        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            Form4 frmVendas = new Form4();
            frmVendas.ShowDialog();
        }

        private void BtnDesativado_Click(object sender, EventArgs e)
        {
            Form5 frmDesativados = new Form5();
            frmDesativados.ShowDialog();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
