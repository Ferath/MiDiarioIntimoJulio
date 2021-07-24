using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ProyectoProgramacion.Controladores
{
    public class Encrypt
    {
        public static string GetMD5(string epassword)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding codificar = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(codificar.GetBytes(epassword));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}