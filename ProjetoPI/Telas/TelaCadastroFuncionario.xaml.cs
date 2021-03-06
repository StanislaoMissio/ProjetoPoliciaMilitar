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
using ProjetoPI.Classes;

namespace ProjetoPI.Telas
{
    /// <summary>
    /// Interaction logic for TelaCadastroFuncionario.xaml
    /// </summary>
    public partial class TelaCadastroFuncionario : Window
    {
        private string permissao = null;

        public TelaCadastroFuncionario()
        {
            InitializeComponent();
            txtNome.Focus();
        }

        private void Administrador_Selected(object sender, RoutedEventArgs e)
        {
            permissao = "A";
        }

        private void Usuario_Selected(object sender, RoutedEventArgs e)
        {
            permissao = "U";
        }

        private void Chefe_Selected(object sender, RoutedEventArgs e)
        {
            permissao = "C";
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            FuncionarioBean bean = new FuncionarioBean();
            bean.Nome = txtNome.Text;
            bean.Re = txtRE.Text;
            bean.Senha = Encriptografar.Encripto(pswSenha.Password);
            bean.Permissao = permissao;
            FuncionarioDAO.CadastrarFuncionario(bean);
            this.Close();
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
        }
    }
}
