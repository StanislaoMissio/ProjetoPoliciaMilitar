using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoPI.Classes
{
    class BoletimDAO
    {
        public static void CadastrarBoletim(BoletimBean bean)
        {
            try
            {
                Conexao.Conectar();
                string qry = "INSERT INTO BOLETIM(FK_Funcionario,FK_Pessoa,Codigo_OPM,Hora_Comunicacao,Hora_Fato,Hora_Local," +
                    "Hora_Final,Data_Emissao,Solicitacao_Ocorrencia,Condicao_Envolvido,Nome_Solicitante," +
                    "Qualificado_como_Envolvido,Endereco_Fornecido,Bairro_Fornecido,Telefone_Fornecido," +
                    "Outros_Dados,Natureza_Ocorrencia, FK_Codigo_Tipo_Ocorrencia,Logradouro_Ocorrencia," +
                    "Municipio_Logradouro,Bairro_Logradouro,Ponto_Referencia,Outro_Local_Referencia,Prefixo_Viatura," +
                    "Versao_Envolvido,Caracteristicas_Local,Iluminacao,Tempo,Relatorio_Policial,Nome_Policial,Cod_RE)" +
                    " VALUES((SELECT ID_FUNCIONARIO FROM USUARIO WHERE RE = @RE),(SELECT ID_PESSOA FROM PESSOA WHERE RG = @RG),@Codigo_OPM," +
                    "@Hora_Comunicacao,@Hora_Fato,@Hora_Local,@Hora_Final,@Data_Emissao,@Solicitacao_Ocorrencia," +
                    "@Condicao_Envolvido,@Nome_Solicitante,@Qualificado_Envolvido,@Endereco_Fornecido,@Bairro_Fornecido," +
                    "@Telefone_Fornecido,@Outros_Dados,@Natureza_Ocorrencia,0,@Logradouro_Ocorrencia,@Municipio_Logradouro," +
                    "@Bairro_Logradouro,@Ponto_Referencia,@Outro_Local_Referencia,@Prefixo_Viatura,@Versao_Envolvido," +
                    "@Caracteristicas_Local,@Iluminacao,@Tempo,@Relatorio_Policial,@Nome_Policial,@Cod_RE)";

                SqlCommand cmd = new SqlCommand(qry, Conexao.conexao);

                cmd.Parameters.AddWithValue("@RE",                    bean.ReFunc);
                cmd.Parameters.AddWithValue("@RG",                    bean.RgVitima);
                cmd.Parameters.AddWithValue("@Codigo_OPM",            bean.CodigoOPM);
                cmd.Parameters.AddWithValue("@Hora_Comunicacao",      bean.HoraComunicacao);
                cmd.Parameters.AddWithValue("@Hora_Fato",             bean.HoraFato);
                cmd.Parameters.AddWithValue("@Hora_Local",            bean.HoraLocal);
                cmd.Parameters.AddWithValue("@Hora_Final",            bean.HoraFinal);
                cmd.Parameters.AddWithValue("@Data_Emissao",          bean.DataEmissao);
                cmd.Parameters.AddWithValue("@Solicitacao_Ocorrencia",bean.SolicitacaoOcorrencia);
                cmd.Parameters.AddWithValue("@Condicao_Envolvido",    bean.CondicaoEnvolvido);
                cmd.Parameters.AddWithValue("@Nome_Solicitante",      bean.NomeSolicitante);
                cmd.Parameters.AddWithValue("@Qualificado_Envolvido", bean.QualificacaoEnvolvido);
                cmd.Parameters.AddWithValue("@Endereco_Fornecido",    bean.EnderecoFornecido);
                cmd.Parameters.AddWithValue("@Bairro_Fornecido",      bean.BairroFornecido);
                cmd.Parameters.AddWithValue("@Telefone_Fornecido",    bean.TelefoneFornecido);
                cmd.Parameters.AddWithValue("@Outros_Dados",          bean.OutrosDados);
                cmd.Parameters.AddWithValue("@Natureza_Ocorrencia",   bean.NaturezaOcorrecia);
                cmd.Parameters.AddWithValue("@Logradouro_Ocorrencia", bean.Logradouro);
                cmd.Parameters.AddWithValue("@Municipio_Logradouro",  bean.MunucipioLogradouro);
                cmd.Parameters.AddWithValue("@Bairro_Logradouro",     bean.BairroLogradouro);
                cmd.Parameters.AddWithValue("@Ponto_Referencia",      bean.PontoReferencia);
                cmd.Parameters.AddWithValue("@Outro_Local_Referencia",bean.OutroPontoReferencia);
                cmd.Parameters.AddWithValue("@Prefixo_Viatura",       bean.PrefixoViatura);
                cmd.Parameters.AddWithValue("@Versao_Envolvido",      bean.VersaoEnvolvido);
                cmd.Parameters.AddWithValue("@Caracteristicas_Local", bean.CaracteristicasLocal);
                cmd.Parameters.AddWithValue("@Iluminacao",            bean.Iluminacao);
                cmd.Parameters.AddWithValue("@Tempo",                 bean.Tempo);
                cmd.Parameters.AddWithValue("@Relatorio_Policial",    bean.RelatorioPolicial);
                cmd.Parameters.AddWithValue("@Nome_Policial",         bean.NomePolicial);
                cmd.Parameters.AddWithValue("@Cod_RE",                bean.CodRE);
                cmd.ExecuteNonQuery();
                Conexao.Desconectar();

            }
            catch (SqlException e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
        }

        public static int UltimoRegistroBoletim()
        {
            int idBoletim = 0;
            try
            {
                Conexao.Conectar();
                string qry = "SELECT MAX(ID_BOLETIM) FROM BOLETIM";
                SqlCommand cmd = new SqlCommand(qry, Conexao.conexao);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    idBoletim = reader.GetInt32(0);
                }
                Conexao.Desconectar();
            }
            catch(SqlException e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
            return idBoletim;
        }
    }
}
