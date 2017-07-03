using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace PARTE1
{
    public class ChangeString
    {
        public string build(string cadena) 
        {
            string resultado = ""; 
            var chars = cadena.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                string letra = chars[i].ToString();

                if (char.IsLetter(letra[0]))
                {
                    if (!letra.ToUpper().Equals("Z"))
                    {
                        Debug.Assert(letra.Length == 1 && Regex.IsMatch(letra, "[a-yA-y]"));
                        var next = (char)(letra[0] + 1);
                        resultado += next.ToString();
                    }
                    else
                        resultado += letra.ToString();
                }
                else
                    resultado += letra.ToString();
            }



            return resultado;

        }
    }
}

