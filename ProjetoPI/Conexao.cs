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
            conexao.ConnectionString = "Integrated Security=true;Initial Catalog=CSharp;Data Source=stanis-pc\\SQLEXPRESS";
            conexao.Open()
        }

        public static void Desconectar()
        {
            conexao.Close();
        }
    }
}
