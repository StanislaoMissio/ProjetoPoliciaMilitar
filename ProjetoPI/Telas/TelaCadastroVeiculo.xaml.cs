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
    /// Interaction logic for TelaCadastroVeiculo.xaml
    /// </summary>
    public partial class TelaCadastroVeiculo : Window
    {

        public TelaCadastroVeiculo()
        { 
            InitializeComponent();
            lblBoletim.Content = BoletimDAO.UltimoRegistroBoletim().ToString();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            VeiculoBean bean = new VeiculoBean();
            int pontosImpacto = 0;

            if (Lanterna_Direita.IsChecked == true)
            {
                bean.ImpactoLanternaDireita = true;
                pontosImpacto++;
            }
            else if (Lanterna_Esquerda.IsChecked == true)
            {
                bean.ImpactoLanternaDireita = true;
                pontosImpacto++;
            }
            else if (Lanterna_Traseira_Direita.IsChecked == true)
            {
                bean.ImpactoLanternaDireita = true;
                pontosImpacto++;
            }
            else if (Lanterna_Traseira_Esquerda.IsChecked == true)
            {
                bean.ImpactoLanternaDireita = true;
                pontosImpacto++;
            }
            else if (Parachoque.IsChecked == true)
            {
                bean.ImpactoLanternaDireita = true;
                pontosImpacto++;
            }
            else if (Parachoque_Traseiro.IsChecked == true)
            {
                bean.ImpactoLanternaDireita = true;
                pontosImpacto++;
            }
            else if (Espelho_Retrovisor_Direito.IsChecked == true)
            {
                bean.ImpactoLanternaDireita = true;
                pontosImpacto++;
            }
            else if (Espelho_Retrovisor_Esquerdo.IsChecked == true)
            {
                bean.ImpactoLanternaDireita = true;
                pontosImpacto++;
            }
            else if (Topo.IsChecked == true)
            {
                bean.ImpactoLanternaDireita = true;
                pontosImpacto++;
            }
            else if (Porta_Direita.IsChecked == true)
            {
                bean.ImpactoLanternaDireita = true;
                pontosImpacto++;
            }
            else if (Porta_Esquerda.IsChecked == true)
            {
                bean.ImpactoLanternaDireita = true;
                pontosImpacto++;
            }
            else if (Porta_Traseira_Direita.IsChecked == true)
            {
                bean.ImpactoLanternaDireita = true;
                pontosImpacto++;
            }
            else if (Porta_Traseira_Esquerda.IsChecked == true)
            {
                bean.ImpactoLanternaDireita = true;
                pontosImpacto++;
            }
            else
            {
                MessageBox.Show("Selecione algum dano ao carro");
            }
            bean.Boletim = BoletimDAO.UltimoRegistroBoletim();
            bean.CodRenavan = txtCodigoRenavam.Text;
            bean.Placa = txtPlaca.Text;
            bean.Municipio = txtMunicipio.Text;
            bean.MunicipioUF = txtUF_Municipio.Text;
            bean.Chassis = txtChassis.Text;
            bean.Marca = txtMarca.Text;
            bean.Modelo = txtModelo.Text;
            bean.AnoFabricacao = Convert.ToInt32(txtAnoFabricacao.Text);
            bean.Categoria = txtCategoria.Text;
            bean.CorPredominante = txtCor_Predominante.Text;
            bean.CategoriaCNH = txtCategoria_CNH.Text;
            bean.NrCNH = txtNR_CNH.Text;
            bean.VenctoCNH = DateTime.Parse(txtVencimento_CNH.Text);
            bean.TipoAcidente = txtTipo_Acidente.Text;
            bean.CondicaoPista = txtCondicao_Pista.Text;
            bean.TipoPista = txtTipo_Pista.Text;
            bean.Semaforo = txtSemaforo.Text;
            bean.PontosImpacto = pontosImpacto;
            bean.Danos = txtDanos.Text;
            VeiculoDAO.CadastrarVeiculo(bean);            
        }
    }
}
