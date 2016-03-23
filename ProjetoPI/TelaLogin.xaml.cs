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

namespace ProjetoPI
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class TelaLogin : Window
    {
        private TelaInicial telaInicial;

        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Logar(txtUsername.Text, txtSenha.Password);
            if (Login.LogarAdministrador())
            {
                telaInicial = new TelaInicial(true);
                this.Close();
                telaInicial.Show();
            }
            else
            {
                telaInicial = new TelaInicial(false);
                this.Close();
                telaInicial.Show();
            }
            
        }
    }
}
