using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Numeroporextenso
{
    public class Centena
    {
      public string CentenaPorExtenso(int numero)
        {
            string retorno = "";
            Unidade unidade = new Unidade();
            Dezena dezena = new Dezena();


            if(numero >= 100 && numero <= 199)
            {
                if(numero == 100)
                 retorno = "Cem";
                if(numero >= 101 && numero <= 109)
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "cento e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                else
                {
                    string dzn = numero.ToString().Substring(1,2);
                    retorno = "cento e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dzn));
                    Console.WriteLine(dzn);
                }
            }


            if(numero >= 200 && numero <= 299)
            {
                if(numero == 200)
                 retorno = "Duzentos";
                if(numero >= 101 && numero <= 109)
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "duzentos e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                else
                {
                    string dzn = numero.ToString().Substring(1,2);
                    retorno = "duzentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dzn));
                    
                }
            }

            if(numero >= 300 && numero <= 399)
            {
                if(numero == 300)
                 retorno = "Trezentos";
                if(numero >= 301 && numero <= 309)
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "trezentos e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                else
                {
                    string dzn = numero.ToString().Substring(1,2);
                    retorno = "trezentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dzn));
                    
                }
            }

            if(numero >= 400 && numero <= 499)
            {
                if(numero == 200)
                 retorno = "Quatrocentos";
                if(numero >= 201 && numero <= 209)
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "quatrocentos e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                else
                {
                    string dzn = numero.ToString().Substring(1,2);
                    retorno = "quatrocentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dzn));
                    
                }
            }

            if(numero >= 500 && numero <= 599)
            {
                if(numero == 500)
                 retorno = "Quinhentos";
                if(numero >= 101 && numero <= 109)
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "quinhentos e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                else
                {
                    string dzn = numero.ToString().Substring(1,2);
                    retorno = "quinhentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dzn));
                    
                }
            }

            if(numero >= 600 && numero <= 699)
            {
                if(numero == 600)
                 retorno = "Seissentos";
                if(numero >= 101 && numero <= 109)
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "seissentos e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                else
                {
                    string dzn = numero.ToString().Substring(1,2);
                    retorno = "seissentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dzn));
                  
                }
            }

            if(numero >= 700 && numero <= 799)
            {
                if(numero == 700)
                 retorno = "Setecentos";
                if(numero >= 101 && numero <= 109)
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "setecentos e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                else
                {
                    string dzn = numero.ToString().Substring(1,2);
                    retorno = "setecentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dzn));
                    
                }
            }

            if(numero >= 800 && numero <= 899)
            {
                if(numero == 800)
                 retorno = "Oitocentos";
                if(numero >= 101 && numero <= 109)
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "oitocentos e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                else
                {
                    string dzn = numero.ToString().Substring(1,2);
                    retorno = "oitocentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dzn));
                    
                }
            }

            if(numero >= 900 && numero <= 999)
            {
                if(numero == 900)
                 retorno = "Novecentos";
                if(numero >= 101 && numero <= 109)
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "Novecentos e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                else
                {
                    string dzn = numero.ToString().Substring(1,2);
                    retorno = "Novecentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dzn));
                    
                }
            }
            return retorno;
        }
      }      
}   