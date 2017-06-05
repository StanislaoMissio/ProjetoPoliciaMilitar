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
using ProjetoPI.Classes;

namespace ProjetoPI.Telas
{
    /// <summary>
    /// Interaction logic for TelaCadastroOcorrencia.xaml
    /// </summary>
    public partial class TelaCadastroOcorrencia : Window
    {
        private string sexo = null;
        private string estadoCivil = null;
        private string cutis = null;
        public static string pessoa = null;

        public TelaCadastroOcorrencia()
        {
            InitializeComponent();
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
        private void Branco_Selected(object sender, RoutedEventArgs e)
        {
            cutis = "Branco";
        }
        private void Negro_Selected(object sender, RoutedEventArgs e)
        {
            cutis = "Negro";
        }
        private void Pardo_Selected(object sender, RoutedEventArgs e)
        {
            cutis = "Pardo";
        }

        private void CadastrarBoletim_Click(object sender, RoutedEventArgs e)
        {
            PessoaBean bean = new PessoaBean();
            bean.Nome = txtNomeCompleto.Text;
            bean.NomePai = txtNomePai.Text;
            bean.NomeMae = txtNomeMae.Text;
            bean.Rg = txtRG.Text;
            bean.Email = txtEmail.Text;
            bean.Nacionalidade = txtNacionalidade.Text;
            bean.Naturalidade = txtNaturalidade.Text;
            bean.Sexo = sexo;
            bean.DataNascimento = DateTime.Parse(txtDataNascimento.Text);
            bean.Cutis = cutis;
            bean.EstadoCivil = estadoCivil;
            bean.Profissao = txtProfissao.Text;
            bean.Endereco = txtEndereco.Text;
            bean.Bairro = txtBairro.Text;
            bean.Municipio = txtMunicipio.Text;
            bean.Complemento = txtComplemento.Text;
            bean.Cep = txtCEP.Text;
            bean.Telefone = txtTelefone.Text;
            bean.UfMunicipio = txtMunicipio_UF.Text;
            bean.UfRG = txtRG_UF.Text;
            PessoaDAO.CadastrarPessoa(bean);

            this.Close();
            TelaBoletim telaBoletim = new TelaBoletim();
            telaBoletim.Show();
        }
    }
}
