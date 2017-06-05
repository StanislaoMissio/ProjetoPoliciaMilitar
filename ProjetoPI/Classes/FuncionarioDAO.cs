using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoPI.Classes
{
    class FuncionarioDAO
    {
        public static void CadastrarFuncionario(FuncionarioBean bean)
        {
            try
            {
                Conexao.Conectar();
                string qryVerifica = "SELECT COUNT(ID_FUNC) FROM USUARIO WHERE RE = @re";
                SqlCommand comando = new SqlCommand(qryVerifica, Conexao.conexao);
                comando.Parameters.AddWithValue("@re", bean.Re);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read() == true)
                {
                    reader.Close();
                    string qry = "INSERT INTO Usuario(Nome, RE, senha, permissao) values(@nome, @re, @senha, @permissao)";
                    SqlCommand cmd = new SqlCommand(qry, Conexao.conexao);
                    cmd.Parameters.AddWithValue("@nome", bean.Nome);
                    cmd.Parameters.AddWithValue("@re", bean.Re);
                    cmd.Parameters.AddWithValue("@senha", Encriptografar.Encripto(bean.Senha));
                    cmd.Parameters.AddWithValue("@permissao", bean.Permissao);
                    cmd.ExecuteNonQuery();
                }
                Conexao.Desconectar();
            }
            catch (SqlException e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
        }
    }
}
