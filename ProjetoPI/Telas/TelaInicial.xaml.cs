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
using System.Windows.Shapes;

namespace ProjetoPI
{
    /// <summary>
    /// Lógica interna para TelaInicial.xaml
    /// </summary>
    public partial class TelaInicial : Window
    {
        private string permissao = null;
        private string sexo = null;
        private string estadoCivil = null;

        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Cadastrar.CadastrarFuncionario(txtRE.Text, pswSenha.Password, permissao);
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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Close();
        }
        private void Feminino_Selected(object sender, RoutedEventArgs e)
        {
            sexo = "F";
        }

        private void Masculino_Selected(object sender, RoutedEventArgs e)
        {
            sexo = "M";
        }

        private void Solteiro_Selected(object sender, RoutedEventArgs e)
        {
            estadoCivil = "Solteiro";
        }

        private void Casado_Selected(object sender, RoutedEventArgs e)
        {
            estadoCivil = "Casado";
        }
        private void Separado_Selected(object sender, RoutedEventArgs e)
        {
            estadoCivil = "Separado";
        }
        private void Viuvo_Selected(object sender, RoutedEventArgs e)
        {
            estadoCivil = "Viuvo";
        }

        private void Divorciado_Selected(object sender, RoutedEventArgs e)
        {
            estadoCivil = "Divorciado";
        }

        private void CadastrarBoletim_Click(object sender, RoutedEventArgs e)
        {
            List<string> dados = new List<string>();
            dados.Add(txtRG.Text);
            dados.Add(txtNomeCompleto.Text);
            dados.Add(txtNomePai.Text);
            dados.Add(txtNomeMae.Text);
            dados.Add(txtNacionalidade.Text);
            dados.Add(txtEmail.Text);
            dados.Add(txtNaturalidade.Text);
            dados.Add(sexo);
            dados.Add(txtCutis.Text);
            dados.Add(estadoCivil);
            dados.Add(txtProfissao.Text);
            dados.Add(txtEndereco.Text);
            dados.Add(txtBairro.Text);
            dados.Add(txtMunicipio.Text);
            dados.Add(txtComplemento.Text);
            dados.Add(txtCEP.Text);
            dados.Add(txtTelefone.Text);
            Cadastrar.CadastrarBoletim(dados, Convert.ToDateTime(txtDataNascimento.Text));
        }
    }
}
