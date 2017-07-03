using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTE1
{
    public class CompleteRange
    {

        public int[] build(int[] arreglo)
        {
            int max = arreglo.Max();
            int[] resultado = new int[max + 1];
            for (int i = 1; i <= max; i++)
            {
                resultado[i] = i;
            }

            return resultado;
        }

    }
}
