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
        public TelaInicial()
        {
            InitializeComponent();
        }
        // Cadastrar Funcionario
        private void btnTelaCadastrarFunc_Click(object sender, RoutedEventArgs e)
        {
            Telas.TelaCadastroFuncionario telaCadastrarFunc = new Telas.TelaCadastroFuncionario();
            telaCadastrarFunc.Show();
            this.Hide();
        }
        // Cadastrar Ocorrêmcia
        private void btnCadastrarOcorrencia_Click(object sender, RoutedEventArgs e)
        {
            Telas.TelaCadastroOcorrencia telaCadastrarOcorrencia = new Telas.TelaCadastroOcorrencia();
            telaCadastrarOcorrencia.Show();
            this.Hide();
        }
        // Gerar Relatório
        private void btnGerarRelatorio_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
