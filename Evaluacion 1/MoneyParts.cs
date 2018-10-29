using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_1
{
    public class MoneyParts
    {
        public static List<decimal[]> build(decimal entrada)
        {
            var lista = new List<List<decimal>>();

            var denominaciones = new List<decimal>();
            denominaciones.Add(0.05M);
            denominaciones.Add(0.1M);
            denominaciones.Add(0.2M);
            denominaciones.Add(0.5M);
            denominaciones.Add(1);
            denominaciones.Add(2);
            denominaciones.Add(5);
            denominaciones.Add(10);
            denominaciones.Add(20);
            denominaciones.Add(50);
            denominaciones.Add(100);
            denominaciones.Add(200);

            //Hallar maxima denominacion
            decimal resto = 0;
            int maximo = 0;
            for (int j = denominaciones.Count() - 1; j >= 0; j--)
            {
                resto = entrada - denominaciones[j];

                if (resto >= 0)
                {
                    maximo = j;
                    break;
                }
            }

            var nuevalista = new List<decimal>();

            //Bucle de busqueda
            iniciar:
            resto = entrada;
            var count = 0;
            var count1 = 0;
            var cantidad = nuevalista.Count();
            int i = 0;
            decimal restonew = 10;
            decimal anterior = -1;

            nuevalista = new List<decimal>();
            var listares = new List<decimal>();
            for (i = maximo; i >= 0; i--)
            {
                restonew = 10;
                                
                do
                {
                    if (cantidad != 0)
                    {
                        if (cantidad == count1 + 1)
                        {
                            cantidad = 0;
                            if (anterior != denominaciones[i])
                            {
                                maximo--;
                            }
                            break;
                        }
                    }

                    restonew = resto - denominaciones[i];

                    if (restonew >= 0)
                    {
                        if (count == 0)
                        {
                            nuevalista.Add(denominaciones[i]);
                            anterior = denominaciones[i];
                        }

                        count1++;
                        resto = restonew;
                        listares.Add(denominaciones[i]);
                    }
                } while (restonew > 0);

                if (nuevalista.Count > 0)
                {
                    count = 1;
                }

                if (restonew == 0)
                {
                    break;
                }
            }

            lista.Add(listares);

            if (nuevalista[0] != 0.05M)
            {
                goto iniciar;
            }
            
            //ordenar matriz
            var listaresp = new List<decimal[]>();

            for (int k = lista.Count - 1; k >= 0; k--)
            {
                listaresp.Add(lista[k].ToArray());
            }

            return listaresp;
        }
    }
}
