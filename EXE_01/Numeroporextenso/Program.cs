﻿
using Numeroporextenso;

Console.WriteLine("***************************");
Console.WriteLine("Escrever número por extenso");
Console.WriteLine("***************************");

Console.WriteLine("Informe um número inteiro:");
string numero = Console.ReadLine();
int nro;
try
{
    nro = Convert.ToInt32(numero);
}
catch
{
    Console.WriteLine("O número não é valido.");
    return;
}
string retorno = "";
switch(numero.Length)
{
    case 1 :
        Unidade unidade = new Unidade();
        retorno = unidade.UnidadePorExtenso(nro);
    break;

    case 2 :
        Dezena dezena = new Dezena();
        retorno = dezena.DezenaPorExtenso(nro);
    break;

    case 3 :
        Centena centena = new Centena();
        retorno = centena.CentenaPorExtenso(nro);
    break;

    case 4 :
        Milhar milhar = new Milhar();
        retorno = milhar.MilharPorExtenso(nro);
    break;
}
Console.WriteLine(retorno);