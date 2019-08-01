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
    public partial class EditMarcas : Form
    {
        public EditMarcas()
        {
            InitializeComponent();
        }
        public DataGridCarros.QuerysInnerJoinDataSet.MarcasRow MarcasRow;
        private void EditMarcas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Marcas);
            tbNome.Text = MarcasRow.Nome;
         
        }

        private void Button1_Click(object sender, EventArgs e)
        {
             MarcasRow.Nome = tbNome.Text;
            this.Close();
        }
    }
}
