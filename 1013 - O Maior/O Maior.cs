using System;

class URI
{

    static void Main(string[] args)
    {
        string entrada = Console.ReadLine();

        string[] valores = entrada.Split();

        int valorA = int.Parse(valores[0]);
        int valorB = int.Parse(valores[1]);
        int valorC = int.Parse(valores[2]);

        int maiorEntreAB = (valorA + valorB + Math.Abs(valorA - valorB)) / 2;
        int maiorValor = (maiorEntreAB + valorC + Math.Abs(maiorEntreAB - valorC)) / 2;

        Console.WriteLine($"{maiorValor} eh o maior");
    }

}