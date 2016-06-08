using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoPI.Classes
{
    class PessoaDAO
    {
        public static void CadastrarPessoa(PessoaBean bean)
        {
            try
            {
                Conexao.Conectar();
                string qry = "INSERT INTO Pessoa(RG, Nome, Nome_Pai, Nome_Mae, Nacionalidade, Email, Naturalidade, Sexo, Cutis, Estado_Civil, Profissao, Endereco, Bairro, Municipio, Complemento, CEP, Telefone,data_Nascimento, UF_RG, UF_Municipio)" +
                             "VALUES(@RG, @Nome, @Nome_Pai, @Nome_Mae, @Nacionalidade, @Email, @Naturalidade, @Sexo, @Cutis, @Estado_Civil, @Profissao, @Endereco, @Bairro, @Municipio, @Complemento, @CEP, @Telefone,@Data_Nascimento, @UF_RG, @UF_Municipio)";
                SqlCommand comando = new SqlCommand(qry, Conexao.conexao);
                comando.Parameters.AddWithValue("@RG", bean.Rg);
                comando.Parameters.AddWithValue("@Nome", bean.Nome);
                comando.Parameters.AddWithValue("@Nome_Pai", bean.NomePai);
                comando.Parameters.AddWithValue("@Nome_Mae", bean.NomeMae);
                comando.Parameters.AddWithValue("@Nacionalidade", bean.Nacionalidade);
                comando.Parameters.AddWithValue("@Email", bean.Email);
                comando.Parameters.AddWithValue("@Naturalidade", bean.Naturalidade);
                comando.Parameters.AddWithValue("@Sexo", bean.Sexo);
                comando.Parameters.AddWithValue("@Cutis", bean.Cutis);
                comando.Parameters.AddWithValue("@Estado_Civil", bean.EstadoCivil);
                comando.Parameters.AddWithValue("@Profissao", bean.Profissao);
                comando.Parameters.AddWithValue("@Endereco", bean.Endereco);
                comando.Parameters.AddWithValue("@Bairro", bean.Bairro);
                comando.Parameters.AddWithValue("@Municipio", bean.Municipio);
                comando.Parameters.AddWithValue("@Complemento", bean.Complemento);
                comando.Parameters.AddWithValue("@CEP", bean.Cep);
                comando.Parameters.AddWithValue("@Data_Nascimento", bean.DataNascimento);
                comando.Parameters.AddWithValue("@UF_RG", bean.UfRG);
                comando.Parameters.AddWithValue("@UF_Municipio", bean.UfMunicipio);
                comando.Parameters.AddWithValue("@Telefone", bean.Telefone);
                comando.ExecuteNonQuery();
                Conexao.Desconectar();
            }
            catch (SqlException e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }

        }
    }
}
