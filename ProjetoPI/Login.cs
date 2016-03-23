using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace ProjetoPI
{
    class Login
    {
        private static string estado = null;
        private static int permissao = 0;

        public static string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public static int Permissao
        {
            get
            {
                return permissao;
            }

            set
            {
                permissao = value;
            }
        }

        public void Logar(string usuario, string senha)
        {
            try
            {
                Conexao.Conectar();
                string qry = "select permissao, estado from usuario where username = '"+ usuario + "' and senha = '" + Encriptografar.Encripto(senha) +"'";
                SqlCommand comando = new SqlCommand(qry, Conexao.conexao);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    permissao = reader.GetInt32(0);
                    estado = reader.GetString(1);
                }
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static bool LogarAdministrador()
        {
            if (estado.Equals("A") && permissao == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
