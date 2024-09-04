using System;

class URI
{

    static void Main(string[] args)
    {
        /* Notação: É possivel fazer com o DateTime como nativo do C# porém é necessário estipular a data inicio ex: DateTime(1,1,1) primeiro de janeiro do ano um, para realizar o calculo, como no exercício pede para considerar sempre 365 não dá para utilizar */

        var entrada = Convert.ToInt32(Console.ReadLine());

        int mes = 30;
        int ano = 365;

        int anos = entrada / ano;
        int meses = (entrada % ano) / mes;
        int dias = (entrada % ano) % mes;

        string retorno = $"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)";

        Console.WriteLine(retorno);
    }
}

