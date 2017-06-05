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
    /// Interaction logic for TelaBoletim.xaml
    /// </summary>
    public partial class TelaBoletim : Window
    {
        public TelaBoletim()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BoletimBean bean = new BoletimBean();
            bean.ReFunc = RE_Func.Text;
            bean.RgVitima = RG_Vitima.Text;
            bean.HoraComunicacao = DateTime.Parse(Hora_Comunicacao.Text);
            bean.HoraFato = DateTime.Parse(Hora_Fato.Text);
            bean.HoraFinal = DateTime.Parse(Hora_Final.Text);
            bean.HoraLocal = DateTime.Parse(Hora_Local.Text);
            bean.DataEmissao = DateTime.Parse(Data_Emissao.Text);
            bean.SolicitacaoOcorrencia = Solicitacao_Ocorrencia.Text;
            bean.CondicaoEnvolvido = Condicao_Envolvido.Text;
            bean.NomeSolicitante = Nome_Solicitante.Text;
            if(Qualificado_Envolvido_Nao.IsChecked == true)
            {
                bean.QualificacaoEnvolvido = false;
            }
            else if(Qualificado_Envolvido_Sim.IsChecked == true)
            {
                bean.QualificacaoEnvolvido = true;
            }
            bean.EnderecoFornecido = Endereco_Fornecido.Text;
            bean.BairroFornecido = Bairro_Fornecido.Text;
            bean.TelefoneFornecido = Telefone_Fornecido.Text;
            bean.OutrosDados = Outros_Dados.Text;
            bean.NaturezaOcorrecia = Natureza_Ocorrencia.Text;
            bean.Logradouro = Logradouro.Text;
            bean.MunucipioLogradouro = Municipio.Text;
            bean.BairroLogradouro = Bairro.Text;
            bean.PontoReferencia = Ponto_Referencia.Text;
            bean.OutroPontoReferencia = Outro_Local_Referencia.Text;
            bean.PrefixoViatura = Prefixo_Viatura.Text;
            bean.VersaoEnvolvido = Versao_Envolvido.Text;
            bean.CaracteristicasLocal = Caracteristicas_Local.Text;
            bean.Iluminacao = Iluminacao.Text;
            bean.Tempo = Tempo.Text;
            bean.RelatorioPolicial = Relatorio_Policial.Text;
            bean.NomePolicial = Nome_Policial.Text;
            bean.CodRE = RE_Policial.Text;
            BoletimDAO.CadastrarBoletim(bean);
        }
    }
}
