using DataGridCarros.Adicao;
using DataGridCarros.Edicao;
using DataGridCarros.Meme;
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
               as DataGridCarros.QuerysInnerJoinDataSet.CarrosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.carrosTableAdapter.DesativarQuery(carSelect.Id);
                    break;
                case 1:
                    EditMarca frmEditCarro = new EditMarca();
                    frmEditCarro.CarrosRow = carSelect;
                    frmEditCarro.ShowDialog();

                    this.carrosTableAdapter.UpdateQuery(
                        frmEditCarro.CarrosRow.Modelo,
                        frmEditCarro.CarrosRow.Ano.ToString(),
                        frmEditCarro.CarrosRow.Marca,
                        frmEditCarro.CarrosRow.UsuAlt,
                        DateTime.Now,
                        frmEditCarro.CarrosRow.Id
                        );

                    break;
            }
            this.carrosTableAdapter.CustomQuery(querysInnerJoinDataSet.Carros);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Carros);

        }

        private void BtnDesativados_Click(object sender, EventArgs e)
        {
            ReativCarros reativCarros = new ReativCarros();
            reativCarros.ShowDialog();
        }

        private void BtnMarcas_Click(object sender, EventArgs e)
        {
            FormMarca formMarca = new FormMarca();
            formMarca.ShowDialog();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuario formUsuario = new FormUsuario();
            formUsuario.ShowDialog();
        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            FormVendas formVendas = new FormVendas();
            formVendas.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionar frmAdicionar = new frmAdicionar();
            frmAdicionar.ShowDialog();

            if (!string.IsNullOrEmpty(frmAdicionar.carrosRow?.Modelo))
                //inseri no banco de dados
                this.carrosTableAdapter.Insert(
                frmAdicionar.carrosRow.Modelo,
                frmAdicionar.carrosRow.Ano,
                frmAdicionar.carrosRow.Marca,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet.Carros);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Epico epico = new Epico();
            epico.Show();
        }
    }
}
