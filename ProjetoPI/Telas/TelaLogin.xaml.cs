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
        public TelaLogin()
        {
            InitializeComponent();
            txtRE.Focus();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Logar(txtRE.Text, txtSenha.Password);
            this.Hide();
            if (login.Logado)
            {
                ExecutarTela(login.Permissao);
            }      
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            var elemento = e.OriginalSource as UIElement;

            if (elemento == null)
                return;

            if (e.Key == Key.Tab)
                elemento.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));

            if (e.Key == Key.Enter)
                btnLogin_Click(sender, e);
        }

        public void ExecutarTela(string permissao)
        {
            TelaInicial telaInicial = new TelaInicial();

            if (permissao.Equals("U"))
            {
            }
            else if (permissao.Equals("C"))
            {
            }
            else
            {
                telaInicial.ShowDialog();
            }
        }
    }
}
