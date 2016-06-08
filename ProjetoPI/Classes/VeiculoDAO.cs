using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoPI.Classes
{
    class VeiculoDAO
    {
        public static void CadastrarVeiculo(VeiculoBean bean)
        {
            try
            {
                Conexao.Conectar();
                string qry = "INSERT INTO VEICULO(FK_Boletim,Codigo_Renavan, Placa,Municipio, UF,Chassis,Marca,Modelo,Ano_Fabricacao,Categoria,Cor_Predominante,"+
                    "Categoria_CNH,NR_CNH,Vencto_CNH,Tipo_Acidente,Condicao_Pista,Tipo_Pista,Semaforo,Impacto_Lanterna_Direita,Impacto_Lanterna_Traseira_Direita,"+
                    "Impacto_Lanterna_Esquerda,Impacto_Lanterna_Traseira_Esquerda,Impacto_Parachoque,Impacto_Parachoque_Traseiro,Impacto_Retrovisor_Direito,"+
                    "Impacto_Retrovisor_Esquerdo,Impacto_Porta_Direita,Impacto_Porta_Esquerda,Impacto_Porta_Traseira_Direita,Impacto_Porta_Traseira_Esquerda,Impacto_Topo, Ponto_Impacto,Danos)"+
                    " Values(@FK_Boletim,@Codigo_Renavan,@Placa,@Municipio,@UF,@Chassis,@Marca,@Modelo,@Ano_Fabricacao, @Categoria,@Cor_Predominante,@Categoria_CNH,"+
                    "@NR_CNH,@Vencto_CNH,@Tipo_Acidente,@Condicao_Pista,@Tipo_Pista,@Semaforo,@Impacto_Lanterna_Direita,@Impacto_Lanterna_Traseira_Direita,"+
                    "@Impacto_Lanterna_Esquerda,@Impacto_Lanterna_Traseira_Esquerda,@Impacto_Parachoque,@Impacto_Parachoque_Traseiro,@Impacto_Retrovisor_Direito,"+
                    "@Impacto_Retrovisor_Esquerdo,@Impacto_Porta_Direita,@Impacto_Porta_Esquerda,@Impacto_Porta_Traseira_Direita,@Impacto_Porta_Traseira_Esquerda,@Impacto_Topo,@Ponto_Impacto,@Danos)";

                SqlCommand cmd = new SqlCommand(qry, Conexao.conexao);

                cmd.Parameters.AddWithValue("@FK_Boletim", bean.Boletim);
                cmd.Parameters.AddWithValue("@Codigo_Renavan", bean.CodRenavan);
                cmd.Parameters.AddWithValue("@Placa", bean.Placa);
                cmd.Parameters.AddWithValue("@Municipio", bean.Municipio);
                cmd.Parameters.AddWithValue("@UF", bean.MunicipioUF);
                cmd.Parameters.AddWithValue("@Chassis", bean.Chassis);
                cmd.Parameters.AddWithValue("@Marca", bean.Marca);
                cmd.Parameters.AddWithValue("@Modelo", bean.Modelo);
                cmd.Parameters.AddWithValue("@Ano_Fabricacao", bean.AnoFabricacao);
                cmd.Parameters.AddWithValue("@Categoria", bean.Categoria);
                cmd.Parameters.AddWithValue("@Cor_Predominante", bean.CorPredominante);
                cmd.Parameters.AddWithValue("@Categoria_CNH", bean.CategoriaCNH);
                cmd.Parameters.AddWithValue("@NR_CNH", bean.NrCNH);
                cmd.Parameters.AddWithValue("@Vencto_CNH", bean.VenctoCNH);
                cmd.Parameters.AddWithValue("@Tipo_Acidente", bean.TipoAcidente);
                cmd.Parameters.AddWithValue("@Condicao_Pista", bean.CondicaoPista);
                cmd.Parameters.AddWithValue("@Tipo_Pista", bean.TipoPista);
                cmd.Parameters.AddWithValue("@Semaforo", bean.Semaforo);
                cmd.Parameters.AddWithValue("@Impacto_Lanterna_Traseira_Direita", bean.ImpactoLanternaTraseiraDireita);
                cmd.Parameters.AddWithValue("@Impacto_Lanterna_Direita", bean.ImpactoLanternaDireita);
                cmd.Parameters.AddWithValue("@Impacto_Lanterna_Esquerda", bean.ImpactoLanternaEsquerda);
                cmd.Parameters.AddWithValue("@Impacto_Lanterna_Traseira_Esquerda", bean.ImpactoLanternaTraseiraEsquerda);
                cmd.Parameters.AddWithValue("@Impacto_Parachoque", bean.ImpactoParachoque);
                cmd.Parameters.AddWithValue("@Impacto_Parachoque_Traseiro", bean.ImpactoParachoqueTraseiro);
                cmd.Parameters.AddWithValue("@Impacto_Retrovisor_Direito", bean.ImpactoRetrovisorDireito);
                cmd.Parameters.AddWithValue("@Impacto_Retrovisor_Esquerdo", bean.ImpactoRetrovisorEsquerdo);
                cmd.Parameters.AddWithValue("@Impacto_Porta_Direita", bean.ImpactoPortaDireita);
                cmd.Parameters.AddWithValue("@Impacto_Porta_Esquerda", bean.ImpactoPortaEsquerda);
                cmd.Parameters.AddWithValue("@Impacto_Porta_Traseira_Direita", bean.ImpactoPortaTraseiraDireita);
                cmd.Parameters.AddWithValue("@Impacto_Porta_Traseira_Esquerda", bean.ImpactoPortaTraseiraEsquerda);
                cmd.Parameters.AddWithValue("@Impacto_Topo", bean.ImpactoTopo);
                cmd.Parameters.AddWithValue("@Ponto_Impacto", bean.PontosImpacto);
                cmd.Parameters.AddWithValue("@Danos", bean.Danos);
                cmd.ExecuteNonQuery();

                Conexao.Desconectar();

            }
            catch (SqlException e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
        }
    }
}
