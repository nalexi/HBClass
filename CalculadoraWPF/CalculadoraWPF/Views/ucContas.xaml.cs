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

namespace CalculadoraWPF.Views
{
    /// <summary>
    /// Interaction logic for ucContas.xaml
    /// </summary>
    public partial class ucContas : UserControl
    {
        float total = 0;
        public ucContas()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float.TryParse(tbValor1.Text, out float valor1);
            float.TryParse(tbValor2.Text, out float valor2);
            total = valor1 + valor2;
            MostrarResutaldo();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void MostrarResutaldo()
        {
            //MediaPlayer player = new MediaPlayer();
            //player.Play();
            tbxResult.Clear();
            tbxResult.Text = total.ToString();
        }

     
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            float.TryParse(tbValor1.Text, out float valor1);
            float.TryParse(tbValor2.Text, out float valor2);
            total = valor1 - valor2;
            MostrarResutaldo();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            float.TryParse(tbValor1.Text, out float valor1);
            float.TryParse(tbValor2.Text, out float valor2);
            total = valor1 * valor2;
            MostrarResutaldo();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            float.TryParse(tbValor1.Text, out float valor1);
            float.TryParse(tbValor2.Text, out float valor2);
            total = valor1 / valor2;
            MostrarResutaldo();
        }
    }
}
