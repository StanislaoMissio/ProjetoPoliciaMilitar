using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPI.Classes
{
    class VeiculoBean
    {
        private int boletim;
        private string codRenavan;
        private string placa;
        private string municipio;
        private string municipioUF;
        private string chassis;
        private string marca;
        private string modelo;
        private int anoFabricacao;
        private string categoria;
        private string corPredominante;
        private string categoriaCNH;
        private string nrCNH;
        private DateTime venctoCNH;
        private string tipoAcidente;
        private string condicaoPista;
        private string tipoPista;
        private string semaforo;
        private int pontosImpacto;
        private string danos;
        private bool impactoParachoque;
        private bool impactoParachoqueTraseiro;
        private bool impactoLanternaDireita;
        private bool impactoLanternaEsquerda;
        private bool impactoLanternaTraseiraEsquerda;
        private bool impactoLanternaTraseiraDireita;
        private bool impactoRetrovisorDireito;
        private bool impactoRetrovisorEsquerdo;
        private bool impactoPortaDireita;
        private bool impactoPortaEsquerda;
        private bool impactoPortaTraseiraEsquerda;
        private bool impactoPortaTraseiraDireita;
        private bool impactoTopo;

        public string CodRenavan
        {
            get
            {
                return codRenavan;
            }

            set
            {
                codRenavan = value;
            }
        }

        public string Placa
        {
            get
            {
                return placa;
            }

            set
            {
                placa = value;
            }
        }

        public string Municipio
        {
            get
            {
                return municipio;
            }

            set
            {
                municipio = value;
            }
        }

        public string MunicipioUF
        {
            get
            {
                return municipioUF;
            }

            set
            {
                municipioUF = value;
            }
        }

        public string Chassis
        {
            get
            {
                return chassis;
            }

            set
            {
                chassis = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public int AnoFabricacao
        {
            get
            {
                return anoFabricacao;
            }

            set
            {
                anoFabricacao = value;
            }
        }

        public string Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                categoria = value;
            }
        }

        public string CorPredominante
        {
            get
            {
                return corPredominante;
            }

            set
            {
                corPredominante = value;
            }
        }

        public string CategoriaCNH
        {
            get
            {
                return categoriaCNH;
            }

            set
            {
                categoriaCNH = value;
            }
        }

        public string NrCNH
        {
            get
            {
                return nrCNH;
            }

            set
            {
                nrCNH = value;
            }
        }

        public DateTime VenctoCNH
        {
            get
            {
                return venctoCNH;
            }

            set
            {
                venctoCNH = value;
            }
        }

        public string TipoAcidente
        {
            get
            {
                return tipoAcidente;
            }

            set
            {
                tipoAcidente = value;
            }
        }

        public string CondicaoPista
        {
            get
            {
                return condicaoPista;
            }

            set
            {
                condicaoPista = value;
            }
        }

        public string TipoPista
        {
            get
            {
                return tipoPista;
            }

            set
            {
                tipoPista = value;
            }
        }

        public string Semaforo
        {
            get
            {
                return semaforo;
            }

            set
            {
                semaforo = value;
            }
        }

        public int PontosImpacto
        {
            get
            {
                return pontosImpacto;
            }

            set
            {
                pontosImpacto = value;
            }
        }

        public string Danos
        {
            get
            {
                return danos;
            }

            set
            {
                danos = value;
            }
        }

        public bool ImpactoParachoque
        {
            get
            {
                return impactoParachoque;
            }

            set
            {
                impactoParachoque = value;
            }
        }

        public bool ImpactoParachoqueTraseiro
        {
            get
            {
                return impactoParachoqueTraseiro;
            }

            set
            {
                impactoParachoqueTraseiro = value;
            }
        }

        public bool ImpactoLanternaDireita
        {
            get
            {
                return impactoLanternaDireita;
            }

            set
            {
                impactoLanternaDireita = value;
            }
        }

        public bool ImpactoLanternaEsquerda
        {
            get
            {
                return impactoLanternaEsquerda;
            }

            set
            {
                impactoLanternaEsquerda = value;
            }
        }

        public bool ImpactoLanternaTraseiraEsquerda
        {
            get
            {
                return impactoLanternaTraseiraEsquerda;
            }

            set
            {
                impactoLanternaTraseiraEsquerda = value;
            }
        }

        public bool ImpactoLanternaTraseiraDireita
        {
            get
            {
                return impactoLanternaTraseiraDireita;
            }

            set
            {
                impactoLanternaTraseiraDireita = value;
            }
        }

        public bool ImpactoRetrovisorDireito
        {
            get
            {
                return impactoRetrovisorDireito;
            }

            set
            {
                impactoRetrovisorDireito = value;
            }
        }

        public bool ImpactoRetrovisorEsquerdo
        {
            get
            {
                return impactoRetrovisorEsquerdo;
            }

            set
            {
                impactoRetrovisorEsquerdo = value;
            }
        }

        public bool ImpactoPortaDireita
        {
            get
            {
                return impactoPortaDireita;
            }

            set
            {
                impactoPortaDireita = value;
            }
        }

        public bool ImpactoPortaEsquerda
        {
            get
            {
                return impactoPortaEsquerda;
            }

            set
            {
                impactoPortaEsquerda = value;
            }
        }

        public bool ImpactoPortaTraseiraEsquerda
        {
            get
            {
                return impactoPortaTraseiraEsquerda;
            }

            set
            {
                impactoPortaTraseiraEsquerda = value;
            }
        }

        public bool ImpactoPortaTraseiraDireita
        {
            get
            {
                return impactoPortaTraseiraDireita;
            }

            set
            {
                impactoPortaTraseiraDireita = value;
            }
        }

        public bool ImpactoTopo
        {
            get
            {
                return impactoTopo;
            }

            set
            {
                impactoTopo = value;
            }
        }

        public int Boletim
        {
            get
            {
                return boletim;
            }

            set
            {
                boletim = value;
            }
        }
    }
}
