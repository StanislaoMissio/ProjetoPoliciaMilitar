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
        public TelaInicial(bool admin)
        {
            InitializeComponent();
            if (admin)
            {
                tabCadastrarUsuario.Visibility = Visibility.Visible;
                tabCadastrarUsuario.IsEnabled = true;                
            }
        }
    }
}
