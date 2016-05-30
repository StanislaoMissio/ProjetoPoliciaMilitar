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

        public static void CadastrarFuncionario(string re, string nome, string senha, string permissao)
        {
            try
            {
                Conexao.Conectar();
                string qryVerifica = "SELECT COUNT(ID_FUNC) FROM USUARIO WHERE RE = @re";
                SqlCommand comando = new SqlCommand(qryVerifica, Conexao.conexao);
                comando.Parameters.AddWithValue("@re", re);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read() == true)
                {
                    reader.Close();
                    string qry = "INSERT INTO Usuario(Nome, RE, senha, permissao) values(@nome, @re, @senha, @permissao)";
                    SqlCommand cmd = new SqlCommand(qry, Conexao.conexao);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@re", re);
                    cmd.Parameters.AddWithValue("@senha", Encriptografar.Encripto(senha));
                    cmd.Parameters.AddWithValue("@permissao", permissao);
                    cmd.ExecuteNonQuery();
                }
                Conexao.Desconectar();
            }
            catch(SqlException e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
        }

        public static void CadastrarPessoa(List<string> dadosPessoais, string dataNascimento)
        {
            try
            {
                Conexao.Conectar();
                string qry = "INSERT INTO Pessoa(RG, Nome, Nome_Pai, Nome_Mae, Nacionalidade, Email, Naturalidade, Sexo, Cutis, Estado_Civil, Profissao, Endereco, Bairro, Municipio, Complemento, CEP, Telefone,data_Nascimento, UF_RG, UF_Municipio)" +
                             "VALUES(@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16,@data, @17, @18)";
                SqlCommand comando = new SqlCommand(qry, Conexao.conexao);
                int i = 0;
                DateTime data = DateTime.Parse(dataNascimento);
                foreach (string dados in dadosPessoais){
                    comando.Parameters.AddWithValue("@"+i, dados);
                    i++;
                }
                comando.Parameters.AddWithValue("@data",data);
                comando.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }

        }

        public static void CadastrarVeiculo(List<string> dados, Dictionary<string,bool> impactos, string anoFabricacao, string vencimentoCNH)
        {
            try
            {
                Conexao.Conectar();
                string qry = "INSERT INTO VEICULO(Codigo_Renavan, Placa,Municipio, UF,Chassis,Marca,Modelo,Ano_Fabricacao,Categoria,Cor_Predominante,Categoria_CNH,NR_CNH,Vencto_CNH,Tipo_Acidente,Condicao_Pista," +
                    "Tipo_Pista,Semaforo,IMPACTO_01,IMPACTO_02,IMPACTO_03,IMPACTO_04,IMPACTO_05,IMPACTO_06,IMPACTO_07,IMPACTO_08,IMPACTO_09,IMPACTO_10,IMPACTO_11,IMPACTO_12,IMPACTO_13,Ponto_Impacto," +
                    "Values(@1,@2,@3,@4,@5,@6,@7,@ano_Fabricacao, @8,@9,@10,@11,@12,@Vencimento_CNH,@13,@14,@15,@16,@17,@18,@19,@20,@21,@22,@23,@24,@25,@26,@27,@28,@29,@30 ";
                SqlCommand cmd = new SqlCommand(qry, Conexao.conexao);
                int fabricacao = Convert.ToInt32(anoFabricacao);
                DateTime vencimento = DateTime.Parse(vencimentoCNH);
                int i = 0;
                foreach (string dadosVeiculo in dados)
                {
                    cmd.Parameters.AddWithValue("@" + i, dados);
                    i++;
                }

                cmd.Parameters.AddWithValue("@ano_Fabricacao", anoFabricacao);
                cmd.Parameters.AddWithValue("@Vencimento_CNH", vencimentoCNH);
            }
            catch(SqlException e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
        }
    }
}
