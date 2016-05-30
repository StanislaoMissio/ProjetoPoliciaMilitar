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

namespace ProjetoPI.Telas
{
    /// <summary>
    /// Interaction logic for TelaCadastroVeiculo.xaml
    /// </summary>
    public partial class TelaCadastroVeiculo : Window
    {
        private Dictionary<string, bool> impactos = new Dictionary<string, bool>();

        public TelaCadastroVeiculo()
        {
            try
            {
                impactos.Add("Impacto_01", false);
                impactos.Add("Impacto_02", false);
                impactos.Add("Impacto_03", false);
                impactos.Add("Impacto_04", false);
                impactos.Add("Impacto_05", false);
                impactos.Add("Impacto_06", false);
                impactos.Add("Impacto_07", false);
                impactos.Add("Impacto_08", false);
                impactos.Add("Impacto_09", false);
                impactos.Add("Impacto_10", false);
                impactos.Add("Impacto_11", false);
                impactos.Add("Impacto_12", false);
                impactos.Add("Impacto_13", false);
            }
            catch (ArgumentException e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if (Lanterna_Direita.IsChecked == true)
            {
                impactos["Impacto_01"] = true;
            }
            else if (Lanterna_Esquerda.IsChecked == true)
            {
                impactos["Impacto_02"] = true;
            }
            else if (Lanterna_Traseira_Direita.IsChecked == true)
            {
                impactos["Impacto_03"] = true;
            }
            else if (Lanterna_Traseira_Esquerda.IsChecked == true)
            {
                impactos["Impacto_04"] = true;
            }
            else if (Parachoque.IsChecked == true)
            {
                impactos["Impacto_05"] = true;
            }
            else if (Parachoque_Traseiro.IsChecked == true)
            {
                impactos["Impacto_06"] = true;
            }
            else if (Espelho_Retrovisor_Direito.IsChecked == true)
            {
                impactos["Impacto_07"] = true;
            }
            else if (Espelho_Retrovisor_Esquerdo.IsChecked == true)
            {
                impactos["Impacto_08"] = true;
            }
            else if (Topo.IsChecked == true)
            {
                impactos["Impacto_09"] = true;
            }
            else if (Porta_Direita.IsChecked == true)
            {
                impactos["Impacto_10"] = true;
            }
            else if (Porta_Esquerda.IsChecked == true)
            {
                impactos["Impacto_11"] = true;
            }
            else if (Porta_Traseira_Direita.IsChecked == true)
            {
                impactos["Impacto_12"] = true;
            }
            else if (Porta_Traseira_Esquerda.IsChecked == true)
            {
                impactos["Impacto_13"] = true;
            }

            List<string> dados = new List<string>();
            dados.Add(txtBoletim.Text);
            dados.Add(txtCodigoRenavam.Text);
            dados.Add(txtPlaca.Text);
            dados.Add(txtMunicipio.Text);
            dados.Add(txtUF_Municipio.Text);
            dados.Add(txtChassis.Text);
            dados.Add(txtMarca.Text);
            dados.Add(txtModelo.Text);
            dados.Add(txtCategoria.Text);
            dados.Add(txtCor_Predominante.Text);
            dados.Add(txtCategoria_CNH.Text);
            dados.Add(txtNR_CNH.Text);
            dados.Add(txtTipo_Acidente.Text);
            dados.Add(txtTipo_Pista.Text);
            dados.Add(txtDanos.Text);

            Cadastrar.CadastrarVeiculo(dados, impactos, txtAnoFabricacao.Text, txtVencimento_CNH.Text);
        }
    }
}
