using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_1
{
    public class OrderRange
    {
        public static void build(int[] array, ref List<int> pares, ref List<int> impares)
        {
            pares = new List<int>();
            impares = new List<int>();

            for (int i = 0; i < array.Count(); i++)
            {
                int residuo = array[i] % 2;

                if (residuo == 0)
                {
                    pares.Add(array[i]);
                }
                else if (residuo == 1)
                {
                    impares.Add(array[i]);
                }
            }

            pares.Sort();
            impares.Sort();
        }
    }
}
