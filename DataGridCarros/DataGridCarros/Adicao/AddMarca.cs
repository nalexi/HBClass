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
    public partial class AddMarca : Form
    {
        public AddMarca()
        {
            InitializeComponent();
        }

        public Marca marcasRow;


        private void BtnAddMarca_Click(object sender, EventArgs e)
        {
                       
            marcasRow = new Marca
            {
                Nome = tbAddMarca.Text,
            };
            this.Close();
        }

    }
}
