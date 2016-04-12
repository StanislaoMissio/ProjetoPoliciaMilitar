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

        public static void CadastrarFuncionario(string re, string senha, string permissao)
        {
            try
            {
                Conexao.Conectar();
                string qryVerifica = "SELECT COUNT(ID_FUNC) FROM USUARIO WHERE RE = '@re'";
                SqlCommand comando = new SqlCommand(qryVerifica, Conexao.conexao);
                comando.Parameters.Add("@re", System.Data.SqlDbType.VarChar).Value = re;
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read() == true)
                {
                    string qry = "INSERT INTO Usuario(RE, senha, permissao) values('@re','@senha','@permissao')";
                    SqlCommand cmd = new SqlCommand(qry, Conexao.conexao);
                    cmd.Parameters.Add("@re", System.Data.SqlDbType.VarChar).Value = re;
                    cmd.Parameters.Add("@senha", System.Data.SqlDbType.VarChar).Value = Encriptografar.Encripto(senha);
                    cmd.Parameters.Add("@permissao", System.Data.SqlDbType.VarChar).Value = permissao;
                    cmd.ExecuteNonQuery();
                }
                Conexao.Desconectar();
            }
            catch(SqlException e)
            {
                System.Console.Write(e.Message);
            }
        }

        public static void CadastrarBoletim(List<string> dadosPessoais, DateTime dataNascimento)
        {
            try
            {
                Conexao.Conectar();
                string qry = "INSERT INTO Pessoa(RG, Nome, Nome_Pai, Nome_Mae, Nacionalidade, Email, Naturalidade, Sexo, Data_Nascimento, Cutis, Estado_Civil, Profissao, Endereco, Bairro, Municipio, Complemento, CEP, Telefone)" +
                             "VALUES(@0, @1, @2, @3, @4, @5, @6, @7, @8,@data, @9, @10, @11, @12, @13, @14, @15, @16)";
                SqlCommand comando = new SqlCommand(qry, Conexao.conexao);
                int i = 0;
                foreach(string dados in dadosPessoais){
                    comando.Parameters.Add("@"+i, System.Data.SqlDbType.VarChar).Value = dados;
                    i++;
                }
                comando.Parameters.Add("@data", System.Data.SqlDbType.DateTime).Value = dataNascimento;
                comando.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
