using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CloudFirestore
{
    public class Extracao
    {
        public static string Cpf(string entrada)
        {
            var apenasDigitos = Regex.Replace(entrada, @"\D", "");
            var padrao = @"\d{11}";
            var resultado = Regex.Match(apenasDigitos, padrao);

            if (resultado.Success)
            {
                return resultado.Value;
            }
            else
            {
                return "";
            }
        }

        public static string Nome(string entrada)
        {
            var nomeArquivo = entrada.IndexOf('/') + 1;

            if (nomeArquivo == 0)
            {
                return "";
            }
            else
            {
                var substring = entrada.Substring(nomeArquivo);
                var resultado = Regex.Replace(substring, "[^a-zA-Z_]", "");
                resultado = resultado.Replace('_', ' ');

                return resultado;
            }
        }

        public static byte[] Bytes(ulong? entrada)
        {
            var resultado = entrada ?? 0;
            return BitConverter.GetBytes(resultado);
        }

        public static DateTime Datas(DateTime? entrada)
        {
            var resultado = Convert.ToDateTime(entrada);
            return resultado.ToUniversalTime();
        }
    }
}
