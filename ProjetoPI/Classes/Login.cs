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
        private string permissao = null;
        private bool logado = false;

        public string Permissao
        {
            get
            {
                return permissao;
            }
        }

        public bool Logado
        {
            get
            {
                return logado;
            }
        }

        public void Logar(string RE, string senha)
        {
            try
            {
                Conexao.Conectar();
                string qry = "select permissao from usuario where RE = @re and senha = @senha and estado = 'A'";
                SqlCommand comando = new SqlCommand(qry, Conexao.conexao);

                comando.Parameters.Add("@re",System.Data.SqlDbType.VarChar).Value = RE;
                comando.Parameters.Add("@senha", System.Data.SqlDbType.VarChar).Value = Encriptografar.Encripto(senha).ToString();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    if (reader.VisibleFieldCount == 1)
                    {
                        permissao = reader.GetString(0);
                        logado = true;
                    }
                }
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }
    }
}
