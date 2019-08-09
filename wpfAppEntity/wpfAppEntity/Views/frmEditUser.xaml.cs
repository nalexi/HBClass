﻿using System;
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
using System.Windows.Shapes;
using wpfAppEntity.Data;

namespace wpfAppEntity.Views
{
    /// <summary>
    /// Interaction logic for frmEditUser.xaml
    /// </summary>
    public partial class frmEditUser : Window
    {
        public frmEditUser()
        {
            InitializeComponent();
        }
        public Usuario user;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            user.Nome = tbxNome.Text;
            user.Login= tbxLogin.Text;
            user.Senha= tbxSenha.Text;

            this.DialogResult = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            user.Nome = tbxNome.Text;
            user.Login = tbxLogin.Text;
            user.Senha = tbxSenha.Text;
        }
    }
}
