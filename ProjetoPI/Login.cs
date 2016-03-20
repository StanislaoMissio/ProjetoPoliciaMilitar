using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoPI
{
    class Login
    {
        static private string usuario = null;
        static private string senha = null;
        static private int nivel = 0;
        static private string estado = null;

        public Login(string usuario, string senha)
        {
            try
            {
            string qry = "select Nivel, Estado from funcionario where Usuario = '" + usuario + "' and Convert(VarChar(255),(Senha)) = '" + senha;
            Conexao.Conectar();
            SqlCommand comando = new SqlCommand(qry, Conexao.conexao);
            SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    usuario = usuario;
                    nivel = reader.GetInt32(0);
                    estado = reader.GetString(1);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static bool LoginAdmin(string usuario, string senha, string estado, int nivel)
        {
            
            return true;

            return false;
        }
    }
}
