using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ProjetoPI
{
    static class Encriptografar
    {

        public static string Encripto(string senhaOriginal)
        {
            Byte[] byteSenhaOriginal;
            Byte[] codificar;
            MD5 md5;

            md5 = new MD5CryptoServiceProvider();
            byteSenhaOriginal = ASCIIEncoding.Default.GetBytes(senhaOriginal);
            codificar = md5.ComputeHash(byteSenhaOriginal);

            return Convert.ToBase64String(codificar);
        }
    }
}
