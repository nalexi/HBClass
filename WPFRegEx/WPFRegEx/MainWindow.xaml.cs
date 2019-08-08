using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using WPFRegEx.Controller;

namespace WPFRegEx
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtSalvar_Click(object sender, RoutedEventArgs e)
        {
            

            if (Validates.ValidEmail(tbEmail.Text))
            {
                MessageBox.Show("certo");
            }
            if (Validates.ValidPhone(tbTelefone.Text))
            {
                MessageBox.Show("certo fone");
            }
            StringBuilder comparar = new StringBuilder();
            comparar.Append(tbNome.Text);
            comparar.Append(tbTelefone.Text);
            comparar.Append(tbEmail.Text);


            MessageBox.Show(comparar.ToString());
        }

     
    }
}
