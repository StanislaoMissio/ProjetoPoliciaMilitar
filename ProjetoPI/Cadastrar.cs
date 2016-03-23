using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace ProjetoPI
{
    class Cadastrar
    {
        private string username;
        private string senha;

        public Cadastrar(String username, String senha)
        {
            this.username = username;
            this.senha = senha;
        }

        public void CadastrarFuncionario()
        {
            Conexao.Conectar();
            string qry = "insert into Usuario(username, senha, permissao) values('"+ this.username +"','"+ Encriptografar.Encripto(this.senha) + "','1')";
            SqlCommand comando = new SqlCommand(qry, Conexao.conexao);
            comando.ExecuteNonQuery();
            Conexao.Desconectar();
        }
    }
}
