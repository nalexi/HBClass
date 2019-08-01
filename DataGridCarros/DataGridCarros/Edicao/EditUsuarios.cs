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
    public partial class EditUsuarios : Form
    {
        public EditUsuarios()
        {
            InitializeComponent();
        }

        public DataGridCarros.QuerysInnerJoinDataSet.UsuariosRow UsuariosRow;

        private void EditUsuarios_Load(object sender, EventArgs e)
        {
            tbUsuario.Text = UsuariosRow.Usuario;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            UsuariosRow.Usuario = tbUsuario.Text;
            this.Close();
        }

    }
}
