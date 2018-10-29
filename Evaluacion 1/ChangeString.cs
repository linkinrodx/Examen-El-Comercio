using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_1
{
    public static class ChangeString
    {
        public static string build(string cadenaEntrada)
        {
            string cadenaSalida = string.Empty;
            char[] listaEntrada = cadenaEntrada.ToArray();

            string abecedario = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,ñ,o,p,q,r,s,t,u,v,w,x,y,z";
            string[] listaAbecedario = abecedario.Split(',');

            for (int i = 0; i < listaEntrada.Count(); i++)
            {
                int j = 0; int busq = 0; 
                while (j < listaAbecedario.Count() && busq == 0)
                {
                    if (listaEntrada[i] == Convert.ToChar(listaAbecedario[j]))
                    {
                        busq = 1;
                        if (j != listaAbecedario.Count() - 1)
                        {
                            cadenaSalida = cadenaSalida + listaAbecedario[j + 1];
                        }
                        else
                        {
                            cadenaSalida = cadenaSalida + listaAbecedario[0];
                        }
                    }
                    else if (listaEntrada[i] == Convert.ToChar(listaAbecedario[j].ToUpper()))
                    {
                        busq = 1;
                        if (j != listaAbecedario.Count() - 1)
                        {
                            cadenaSalida = cadenaSalida + listaAbecedario[j + 1].ToUpper();
                        }
                        else
                        {
                            cadenaSalida = cadenaSalida + listaAbecedario[0].ToUpper();
                        }
                    }
                    j++;
                }

                if (busq == 0)
                {
                    cadenaSalida = cadenaSalida + listaEntrada[i];
                }
            }

            return cadenaSalida;
        }
    }
}
