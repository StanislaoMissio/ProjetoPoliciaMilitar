using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPI.Classes
{
    class FuncionarioBean
    {
        private string nome = null;
        private string re = null;
        private string senha = null;
        private string permissao = null;

        public string Re
        {
            get
            {
                return re;
            }

            set
            {
                re = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public string Permissao
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

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }
    }
}
