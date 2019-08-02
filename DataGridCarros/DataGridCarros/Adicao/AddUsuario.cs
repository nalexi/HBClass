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
    public partial class AddUsuario : Form
    {
        public AddUsuario()
        {
            InitializeComponent();
        }

        public Usuario usuariosRow;

        private void BtnAddUsuario_Click(object sender, EventArgs e)
        {
            usuariosRow = new Usuario
            {
                Nome = textBox1.Text,

            };
            this.Close();
        }
    }
}
