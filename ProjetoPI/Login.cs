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
        private string estado = null;

        public Login(string usuario, string senha)
        {
            try
            {
            Conexao.Conectar();
            string qry = "select count(Id_Func), estado from usuario where username = '"+ usuario + "' and senha = '" + Encriptografar.Encripto(senha) +"' group by estado";
            SqlCommand comando = new SqlCommand(qry, Conexao.conexao);
            SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
