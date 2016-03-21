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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetoPI
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class TelaLogin : Window
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login(txtUsername.Text, txtSenha.Password);
        }

        private void btnCadastro_Click(object sender, RoutedEventArgs e)
        {
            Cadastrar cadastro = new Cadastrar(txtUsername.Text, txtSenha.Password);
            cadastro.CadastrarFuncionario();
        }
    }
}
