using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using wpfAppEntity.Data;

namespace wpfAppEntity.Views
{
    /// <summary>
    /// Interaction logic for ucLogin.xaml
    /// </summary>
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }

        public event EventHandler success;
        public event EventHandler fail;
        public BibliotecaDBContext context = new BibliotecaDBContext();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nomeUsuario = tbxLogin.Text;
            var senhaUsuario = tbxSenha.Text;
            var result = context.Usuarios.FirstOrDefault(x => x.Login == nomeUsuario && x.Senha == senhaUsuario);

            if (result?.Id > 0)
                success("Logado com sucesso", new EventArgs());
            else
                fail($"Falha ao logar {nomeUsuario}", new EventArgs());
            
        }
    }
}
