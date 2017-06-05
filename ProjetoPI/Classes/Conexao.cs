using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoPI
{
    static class Conexao
    {
        public static SqlConnection conexao = new SqlConnection();

        public static void Conectar()
        {
            conexao.ConnectionString = "Data Source=DESKTOP-044AGP2\\SQLEXPRESS;Initial Catalog=PoliciaMilitar;Integrated Security=True";
            conexao.Open();
        }

        public static void Desconectar()
        {
            conexao.Close();
        }
    }
}
